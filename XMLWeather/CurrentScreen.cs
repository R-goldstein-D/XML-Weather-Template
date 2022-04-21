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
            //set text outputs
            setText();
        }
        public void setText()
        {
            //temperatress and city
            currentTempOutput.Text = Form1.days[0].currentTemp + "°C";
            lowOutput.Text = Form1.days[0].tempLow + "°C";
            highOutput.Text = Form1.days[0].tempHigh + "°C";
            dateOutput.Text = DateTime.Now.ToString("dddd, MMMM dd");
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;

            //humidity
            humidityOutput.Text = Form1.days[0].humidity + " %";

            ////get sunrise and sunset, convert to timezone and display
            //DateTime sunriseTime = Convert.ToDateTime(Form1.days[0].sunrise);
            //sunriseOutput.Text = sunriseTime.ToString("hh:mm tt");
            //DateTime sunsetTime = Convert.ToDateTime(Form1.days[0].sunset);
            //sunsetOutput.Text = sunsetTime.ToString("hh:mm tt");

            //if type not null, display type of precip, else just precip
            if (Form1.days[0].precipType != null)
            {
                chanceOfLabel.Text = "Chance of " + (Form1.days[0].precipType);
            }
            else
            {
                chanceOfLabel.Text = "Chance of Precipitation";
            }
            //display percent chance
            chanceOutput.Text = (Convert.ToDouble(Form1.days[0].precipProb) * 100).ToString() + " %";

            //display precip amount if any, else 0
            if (Form1.days[0].precipAmount != null)
            {
                precipitationOutput.Text = (Convert.ToDouble(Form1.days[0].precipAmount) * 100).ToString() + " cm";
            }
            else
            {
                precipitationOutput.Text = "0 cm";
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
