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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityLabel.Text = Form1.days[0].location;

            date1.Text = Form1.days[1].date;

            double templow1 = Convert.ToDouble(Form1.days[1].tempLow);
            int tempLow1 = Convert.ToInt32(templow1);
            min1.Text = tempLow1 + "\u00B0 C";

            double temphigh1 = Convert.ToDouble(Form1.days[1].tempHigh);
            int tempHigh1 = Convert.ToInt32(temphigh1);
            max1.Text = tempHigh1 + "\u00B0 C";

            double Condition1 = Convert.ToDouble(Form1.days[1].condition);
            if (Condition1 > 800)
            {
                conditionImage1.Image = Properties.Resources._02d;
            }
            else if (Condition1 == 800)
            {
                conditionImage1.Image = Properties.Resources._01d;
            }
            else if (Condition1 >= 600 && Condition1 <= 699)
            {
                conditionImage1.Image = Properties.Resources._13d;
            }
            else if (Condition1 >= 500 && Condition1 <= 599)
            {
                conditionImage1.Image = Properties.Resources._10d;
            }
            else if (Condition1 >= 200 && Condition1 <= 299)
            {
                conditionImage1.Image = Properties.Resources._11d;
            }
            else if (Condition1 >= 300 && Condition1 <= 399)
            {
                conditionImage1.Image = Properties.Resources._10d;
            }

            date2.Text = Form1.days[2].date;

            double templow2 = Convert.ToDouble(Form1.days[2].tempLow);
            int tempLow2 = Convert.ToInt32(templow2);
            min2.Text = tempLow2 + "\u00B0 C";

            double temphigh2 = Convert.ToDouble(Form1.days[2].tempHigh);
            int tempHigh2 = Convert.ToInt32(temphigh2);
            max2.Text = tempHigh2 + "\u00B0 C";

            double Condition2 = Convert.ToDouble(Form1.days[2].condition);
            if (Condition2 > 800)
            {
                conditionImage2.Image = Properties.Resources._02d;
            }
            else if (Condition2 == 800)
            {
                conditionImage2.Image = Properties.Resources._01d;
            }
            else if (Condition2 >= 600 && Condition2 <= 699)
            {
                conditionImage2.Image = Properties.Resources._13d;
            }
            else if (Condition2 >= 500 && Condition2 >= 599)
            {
                conditionImage2.Image = Properties.Resources._10d;
            }
            else if (Condition2 >= 200 && Condition2 <= 299)
            {
                conditionImage2.Image = Properties.Resources._11d;
            }
            else if (Condition2 >= 300 && Condition2 >= 399)
            {
                conditionImage2.Image = Properties.Resources._10d;
            }

            date3.Text = Form1.days[3].date;

            double templow3 = Convert.ToDouble(Form1.days[3].tempLow);
            int tempLow3 = Convert.ToInt32(templow3);
            min3.Text = tempLow3 + "\u00B0 C";

            double temphigh3 = Convert.ToDouble(Form1.days[3].tempHigh);
            int tempHigh3 = Convert.ToInt32(temphigh3);
            max3.Text = tempHigh3 + "\u00B0 C";

            double Condition3 = Convert.ToDouble(Form1.days[3].condition);
            if (Condition3 > 800)
            {
                conditionImage3.Image = Properties.Resources._02d;
            }
            else if (Condition3 == 800)
            {
                conditionImage3.Image = Properties.Resources._01d;
            }
            else if (Condition3 >= 600 && Condition3 <= 699)
            {
                conditionImage3.Image = Properties.Resources._13d;
            }
            else if (Condition3 >= 500 && Condition3 <= 599)
            {
                conditionImage3.Image = Properties.Resources._10d;
            }
            else if (Condition3 >= 200 && Condition3 <= 299)
            {
                conditionImage3.Image = Properties.Resources._11d;
            }
            else if (Condition3 >= 300 && Condition3 <= 399)
            {
                conditionImage3.Image = Properties.Resources._10d;
            }

            this.BackgroundImage = Properties.Resources.cloudy_sky2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
