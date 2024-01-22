using Newtonsoft.Json.Linq;

namespace HisseFiyatAPI
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://api.collectapi.com");
            //client.DefaultRequestHeaders.Add("content-type", "application/json");
            client.DefaultRequestHeaders.Add("authorization", "apikey APIKEY"); // api key
        }

        async void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                HttpResponseMessage response = await client.GetAsync("/economy/hisseSenedi");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);
                    //JToken succes = json["success"];

                    JToken result = json["result"][listBox1.SelectedIndex];

                    string price = result["lastprice"].ToString();
                    string minPrice = result["min"].ToString();
                    string maxPrice = result["max"].ToString();
                    string time = result["time"].ToString();
                    string code = result["code"].ToString();
                    string name = result["text"].ToString();

                    richTextBox1.Text = "Hisse Adý: " + name + "\n" +
                                        "Hisse Kodu: " + code + "\n" +
                                        "Fiyat : " + price + "\n" +
                                        "Max Fiyat : " + maxPrice + "\n" +
                                        "Min Fiyat : " + minPrice + "\n" +
                                        "Zaman : " + time; 
                }
                else
                    richTextBox1.Text = ("Error: " + response.StatusCode);
            }
        }

        async void Form1_Load(object sender, EventArgs e)
        {
            TakeData();
        }

        async void TakeData()
        {
            HttpResponseMessage response = await client.GetAsync("/economy/hisseSenedi");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                JArray results = (JArray)json["result"];
                int resultLength = results.Count;

                JToken result = json["result"];
                string code;

                for (int i = 0; i < resultLength; i++)
                {
                    result = json["result"][i];
                    code = result["code"].ToString();

                    listBox1.Items.Add(code);
                }
            }
            else
                richTextBox1.Text = ("Error: " + response.StatusCode);
        }
    }
}
