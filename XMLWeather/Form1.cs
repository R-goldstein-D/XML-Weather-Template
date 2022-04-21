﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        String symbol = "°";
        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day newDay = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                //get low and high and remove decimals
                reader.ReadToFollowing("temperature");
                newDay.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
                newDay.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");

                //get precipitation probability, amount, and type
                reader.ReadToFollowing("precipitation");
                newDay.precipProb = reader.GetAttribute("probability");
                newDay.precipAmount = reader.GetAttribute("value");
                newDay.precipType = reader.GetAttribute("type");

                //if day object not null add to the days list
                if (newDay.date != null)
                {
                    days.Add(newDay);
                }
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //get temp and round
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");

            //get humidity
            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            //


            ////get sunrise and sunsest ///ask why it is crashing///
            //reader.ReadToFollowing("sun");
            //days[0].sunrise = reader.GetAttribute("rise");
            //days[0].sunset = reader.GetAttribute("set");
            //days[0].sunrise = days[0].sunrise;
            //days[0].sunset = days[0].sunset;


        }


    }
}
