using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

            cityOutput.Text = Form1.days[0].location;
            
            double currenttemp = Convert.ToDouble(Form1.days[0].currentTemp);
            int currentTemp = Convert.ToInt32(currenttemp);
            tempLabel.Text = currentTemp + "\u00B0 C";

            double templow = Convert.ToDouble(Form1.days[0].tempLow);
            int tempLow = Convert.ToInt32(templow);
            minOutput.Text = tempLow + "\u00B0 C";

            double temphigh = Convert.ToDouble(Form1.days[0].tempHigh);
            int tempHigh = Convert.ToInt32(temphigh);
            maxOutput.Text = tempHigh + "\u00B0 C";

            double feelslike = Convert.ToDouble(Form1.days[0].feelsLike);
            int feelsLike = Convert.ToInt32(feelslike);
            feelsLikeLabel.Text = "Feels like: " + feelsLike + "\u00B0 C";

            timeLabel.Text = DateTime.Now.ToString("hh:mm");
            dateLabel.Text = DateTime.Now.ToString("yy-MM-dd");

            double condition = Convert.ToDouble(Form1.days[0].condition);
            int Condition = Convert.ToInt32(condition);
            if (Condition > 800)
            { 
                this.BackgroundImage = Properties.Resources.cloudy_sky;
                conditionLabel.Text = "Overcast Clouds";
            }
            else if (Condition == 800)
            {
                this.BackgroundImage = Properties.Resources.clear_sky;
                conditionLabel.Text = "Clear Skies";
            }
            else if (Condition <= 600 && Condition >= 699)
            {
                this.BackgroundImage = Properties.Resources.snow;
                conditionLabel.Text = "Snow";
            }
            else if (Condition <= 500 && Condition >= 599)
            {
                this.BackgroundImage = Properties.Resources.rainy_sky;
                conditionLabel.Text = "Rain";
            }
            else if (Condition <= 200 && Condition >= 299)
            {
                this.BackgroundImage = Properties.Resources.cloudy_sky2;
                conditionLabel.Text = "Thunderstorm";
            }
            else if (Condition <= 300 && Condition >= 399)
            {
                this.BackgroundImage = Properties.Resources.cloudy_sky2;
                conditionLabel.Text = "Drizzle";
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
