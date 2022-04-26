using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {

        // Creates a TextInfo based on the "en-US" culture.
       // TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        //refresh timer counter
        int timerCounter = 0;
        //date and time of computer
        int currentSec = DateTime.Now.Second;
        int currentMin = DateTime.Now.Minute;
        int currentHour = DateTime.Now.Hour;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //play sound 
            Form1.nextScreen.Play();

            //set text outputs
            setText();

            //change bg day/night, night from 7pm-6am
            Form1.timeBGImage(pictureBoxBG);
            Form1.ChooseBGImage(this);
        }
        public void setText()
        {
            //temperatress and city
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;
            dateOutput.Text = DateTime.Now.ToString("dddd, MMMM dd");
            currentTempOutput.Text = Form1.days[0].currentTemp + "°C";
            lowOutput.Text = Form1.days[0].tempLow + "°C";
            highOutput.Text = Form1.days[0].tempHigh + "°C";

            //humidity,visiblilty, feels like, wind, pressure
            humidityOutput.Text = Form1.days[0].humidity + " %";
            visibilityOutput.Text = Form1.days[0].visibility + " KM";
            feelsLikeTempOutput.Text = Form1.days[0].feelsLikeTemp + "°C";
            windOutput.Text = Form1.days[0].windDirection + " " + Form1.days[0].windSpeed + " km/hr";
            pressureOutput.Text = Form1.days[0].pressure + " hPa";

            ////format condition 
            // string temp = Form1.days[0].condition;
            // char c = temp.Substring(0, 1).ToUpper();
            conditionOutput.Text = Form1.days[0].condition;

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

            //get last updated time, convert to timezone and display
            lastUpdatedOutput.Text = DateTime.Now.ToString("dd-MM-yy    hh:mm tt");

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //increase timer
            timerCounter++;

            //if 10 mins have passed, refresh data
            if (timerCounter == 6000)
            {
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                timerCounter = 0;
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //switch to search screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);

            ss.Focus();
        }

    }
}
