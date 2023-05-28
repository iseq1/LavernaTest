using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace hometask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CleanLabel();
            WeatherPictureBox.Image = Image.FromFile("main.png");
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Введите город";
        }
        
        //Api-ключ
        private string APIKey = "dda098f0990e23a551c8a6523eaea194";

        private void CleanLabel()
        {
            //Очистка всех лейблов от информации
            CityNameLabel.Text = "Город не указан"; 
            TemperatureLabel.Text = "Tемпература - ";
            DescriptionLabel.Text = "Описание - ";
            HumidityLabel.Text = "Влажность - ";
            PressureLabel.Text = "Давление - ";
            WindSpeedLabel.Text = "Скорость ветра - ";
        }

        private void SetPictureBoxImage(int weatherId)
        {
            //Получаем айди погоды, на основе которого загружаем необходимую картинку 
            if (weatherId >= 200 && weatherId <= 232) // Гроза
            {
                WeatherPictureBox.Image = Image.FromFile("storm.png");
            }
            else if (weatherId >= 959 && weatherId <= 962) // Ветренно
            {
                WeatherPictureBox.Image = Image.FromFile("wind.png");
            }
            else if (weatherId >= 500 && weatherId <= 531) // Дождь
            {
                WeatherPictureBox.Image = Image.FromFile("rain.png");
            }
            else if (weatherId >= 600 && weatherId <= 622) // Снег
            {
                WeatherPictureBox.Image = Image.FromFile("snow.png");
            }
            else if (weatherId >= 801 && weatherId <= 804) // Облачно
            {
                WeatherPictureBox.Image = Image.FromFile("cloud.png");;
            }
            else // Ясно
            {
                WeatherPictureBox.Image = Image.FromFile("clear.png");
            }
        }
        
        private void GetWeather(string city)
        {
            string url = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&lang=ru&appid="+APIKey, city); // Формируем URL запроса с указанием города и API ключа
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); // Создаем запрос на сервер OpenWeatherMap
                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // Получаем ответ от сервера
                StreamReader reader = new StreamReader(response.GetResponseStream()); // Создаем поток для чтения ответа
                string responseString = reader.ReadToEnd(); // Считываем ответ в строку
                response.Close(); // Закрываем ответ

                // Парсим JSON-ответ с помощью библиотеки Newtonsoft.Json
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);
                //Получаем необходимую для отоброжения информацию
                double temp = json.main.temp;
                string description = json.weather[0].description;
                int humidity = json.main.humidity;
                int pressure = json.main.pressure;
                double windSpeed = json.wind.speed;
                int weatherId = json.weather[0].id;
                // Выводим информацию о погоде
                CityNameLabel.Text = String.Format("Погода в городе {0}: ", city); 
                TemperatureLabel.Text = String.Format("Tемпература - {0}°C", temp);
                DescriptionLabel.Text = String.Format("Описание - {0}", description);
                HumidityLabel.Text = String.Format("Влажность - {0}%", humidity);
                PressureLabel.Text = String.Format("Давление - {0} гПа", pressure);
                WindSpeedLabel.Text = String.Format("Скорость ветра - {0} м/с", windSpeed);
                SetPictureBoxImage(weatherId);
            }
            catch (Exception ex)
            {
                //При ошибке выводи картинку с ошибкой и месседжбокс, чистим лейблы 
                WeatherPictureBox.Image = Image.FromFile("404.png");
                CleanLabel();
                MessageBox.Show(ex.Message); // Выводим сообщение об ошибке в случае ее возникновения
            }
        }

        private void GetWeatherBttn_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text; // Получаем город из текстового поля
            GetWeather(city); //получаем и выводим инфу о погоде в городе 
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Введите город";
        }

        
        //Когда текстбокс активен
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите город")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black; // Чтобы изменить цвет текста, когда TextBox активен
            }
        }
        
        //Когда текстбокс не активен
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите город";
                textBox1.ForeColor = Color.Gray; // Чтобы изменить цвет текста, когда TextBox неактивен
            }
        }
    }
}