using Newtonsoft.Json;
using System.Net;

namespace _6thProjectKuis1WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "openWeatherMapAPI";

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", searchTextBox.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labelCondition.Text = Info.weather[0].main;
                labelDetails.Text = Info.weather[0].description;
                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                labelSunset.Text = convertDateTime(Info.sys.sunset).ToString();

                labelWindSpeed.Text = Info.wind.speed.ToString();
                labelPressure.Text = Info.main.pressure.ToString();
            }
        }

        DateTime convertDateTime(long milisec)
        {
            DateTime day = new DateTime(1970, 1,1,0, 0, 0,0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(milisec).ToLocalTime();
            return day;
        }
    }
}