using System.Windows.Forms;

namespace hometask
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetWeatherBttn = new System.Windows.Forms.Button();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.WeatherPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GetWeatherBttn
            // 
            this.GetWeatherBttn.Location = new System.Drawing.Point(169, 641);
            this.GetWeatherBttn.Name = "GetWeatherBttn";
            this.GetWeatherBttn.Size = new System.Drawing.Size(146, 39);
            this.GetWeatherBttn.TabIndex = 0;
            this.GetWeatherBttn.Text = "Узнать погоду";
            this.GetWeatherBttn.UseVisualStyleBackColor = true;
            this.GetWeatherBttn.Click += new System.EventHandler(this.GetWeatherBttn_Click);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 466);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(328, 28);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Температура:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 494);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(328, 28);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Описание:";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Location = new System.Drawing.Point(12, 526);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(328, 28);
            this.HumidityLabel.TabIndex = 4;
            this.HumidityLabel.Text = "Влажность";
            // 
            // PressureLabel
            // 
            this.PressureLabel.Location = new System.Drawing.Point(12, 554);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(328, 28);
            this.PressureLabel.TabIndex = 5;
            this.PressureLabel.Text = "Давление:";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.Location = new System.Drawing.Point(12, 582);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(328, 28);
            this.WindSpeedLabel.TabIndex = 6;
            this.WindSpeedLabel.Text = "Скорость ветра:";
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.Location = new System.Drawing.Point(12, 438);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(328, 28);
            this.CityNameLabel.TabIndex = 7;
            this.CityNameLabel.Text = "Погода в городе";
            // 
            // WeatherPictureBox
            // 
            this.WeatherPictureBox.Location = new System.Drawing.Point(83, 12);
            this.WeatherPictureBox.Name = "WeatherPictureBox";
            this.WeatherPictureBox.Size = new System.Drawing.Size(350, 350);
            this.WeatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherPictureBox.TabIndex = 8;
            this.WeatherPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 703);
            this.Controls.Add(this.WeatherPictureBox);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.GetWeatherBttn);
            this.Name = "Form1";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox WeatherPictureBox;

        private System.Windows.Forms.Label CityNameLabel;

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label WindSpeedLabel;

        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button GetWeatherBttn;

        #endregion
    }
}