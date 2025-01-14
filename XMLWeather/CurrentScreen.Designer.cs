﻿namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.hlLabel = new System.Windows.Forms.Label();
            this.highOutput = new System.Windows.Forms.Label();
            this.lowOutput = new System.Windows.Forms.Label();
            this.chanceOfLabel = new System.Windows.Forms.Label();
            this.chanceOutput = new System.Windows.Forms.Label();
            this.precipitationLabel = new System.Windows.Forms.Label();
            this.precipitationOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.visibilityLabel = new System.Windows.Forms.Label();
            this.visibilityOutput = new System.Windows.Forms.Label();
            this.feelsLikeTempLabel = new System.Windows.Forms.Label();
            this.feelsLikeTempOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.lastUpdatedOutput = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.windLabel = new System.Windows.Forms.Label();
            this.windOutput = new System.Windows.Forms.Label();
            this.pressureOutput = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(171, 78);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(214, 35);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(196, 209);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(33, 20);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 43);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(424, 22);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(124, 43);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "6 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(202, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 41);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(71, 148);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(415, 75);
            this.currentTempOutput.TabIndex = 71;
            this.currentTempOutput.Text = "Temp";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hlLabel
            // 
            this.hlLabel.AutoSize = true;
            this.hlLabel.BackColor = System.Drawing.Color.Transparent;
            this.hlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlLabel.ForeColor = System.Drawing.Color.White;
            this.hlLabel.Location = new System.Drawing.Point(431, 148);
            this.hlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hlLabel.Name = "hlLabel";
            this.hlLabel.Size = new System.Drawing.Size(62, 75);
            this.hlLabel.TabIndex = 72;
            this.hlLabel.Text = "H:      \r\n        \r\nL: ";
            // 
            // highOutput
            // 
            this.highOutput.AutoSize = true;
            this.highOutput.BackColor = System.Drawing.Color.Transparent;
            this.highOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highOutput.ForeColor = System.Drawing.Color.White;
            this.highOutput.Location = new System.Drawing.Point(472, 148);
            this.highOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highOutput.Name = "highOutput";
            this.highOutput.Size = new System.Drawing.Size(49, 25);
            this.highOutput.TabIndex = 73;
            this.highOutput.Text = "high";
            // 
            // lowOutput
            // 
            this.lowOutput.AutoSize = true;
            this.lowOutput.BackColor = System.Drawing.Color.Transparent;
            this.lowOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowOutput.ForeColor = System.Drawing.Color.White;
            this.lowOutput.Location = new System.Drawing.Point(472, 198);
            this.lowOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowOutput.Name = "lowOutput";
            this.lowOutput.Size = new System.Drawing.Size(41, 25);
            this.lowOutput.TabIndex = 74;
            this.lowOutput.Text = "low";
            this.lowOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chanceOfLabel
            // 
            this.chanceOfLabel.BackColor = System.Drawing.Color.Transparent;
            this.chanceOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceOfLabel.ForeColor = System.Drawing.Color.White;
            this.chanceOfLabel.Location = new System.Drawing.Point(12, 373);
            this.chanceOfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chanceOfLabel.Name = "chanceOfLabel";
            this.chanceOfLabel.Size = new System.Drawing.Size(243, 21);
            this.chanceOfLabel.TabIndex = 75;
            this.chanceOfLabel.Text = "Chance of Precipitation";
            this.chanceOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chanceOutput
            // 
            this.chanceOutput.BackColor = System.Drawing.Color.Transparent;
            this.chanceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceOutput.ForeColor = System.Drawing.Color.White;
            this.chanceOutput.Location = new System.Drawing.Point(12, 403);
            this.chanceOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chanceOutput.Name = "chanceOutput";
            this.chanceOutput.Size = new System.Drawing.Size(163, 21);
            this.chanceOutput.TabIndex = 76;
            this.chanceOutput.Text = "ChancePercent";
            this.chanceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipitationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationLabel.ForeColor = System.Drawing.Color.White;
            this.precipitationLabel.Location = new System.Drawing.Point(12, 465);
            this.precipitationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(130, 21);
            this.precipitationLabel.TabIndex = 77;
            this.precipitationLabel.Text = "Precipitation";
            this.precipitationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.BackColor = System.Drawing.Color.Transparent;
            this.precipitationOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationOutput.ForeColor = System.Drawing.Color.White;
            this.precipitationOutput.Location = new System.Drawing.Point(12, 486);
            this.precipitationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(219, 21);
            this.precipitationOutput.TabIndex = 78;
            this.precipitationOutput.Text = "PrecipitationAmount";
            this.precipitationOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(71, 116);
            this.dateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(415, 32);
            this.dateOutput.TabIndex = 83;
            this.dateOutput.Text = "Date";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(461, 373);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(82, 21);
            this.humidityLabel.TabIndex = 84;
            this.humidityLabel.Text = "Humidity";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(393, 403);
            this.humidityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(155, 21);
            this.humidityOutput.TabIndex = 85;
            this.humidityOutput.Text = "HumidityPercent";
            this.humidityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // visibilityLabel
            // 
            this.visibilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.visibilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilityLabel.ForeColor = System.Drawing.Color.White;
            this.visibilityLabel.Location = new System.Drawing.Point(457, 465);
            this.visibilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visibilityLabel.Name = "visibilityLabel";
            this.visibilityLabel.Size = new System.Drawing.Size(86, 21);
            this.visibilityLabel.TabIndex = 86;
            this.visibilityLabel.Text = "Visibility";
            this.visibilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // visibilityOutput
            // 
            this.visibilityOutput.BackColor = System.Drawing.Color.Transparent;
            this.visibilityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilityOutput.ForeColor = System.Drawing.Color.White;
            this.visibilityOutput.Location = new System.Drawing.Point(392, 486);
            this.visibilityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visibilityOutput.Name = "visibilityOutput";
            this.visibilityOutput.Size = new System.Drawing.Size(151, 21);
            this.visibilityOutput.TabIndex = 87;
            this.visibilityOutput.Text = "VisibilityMeasure";
            this.visibilityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feelsLikeTempLabel
            // 
            this.feelsLikeTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeTempLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeTempLabel.Location = new System.Drawing.Point(173, 271);
            this.feelsLikeTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeTempLabel.Name = "feelsLikeTempLabel";
            this.feelsLikeTempLabel.Size = new System.Drawing.Size(156, 21);
            this.feelsLikeTempLabel.TabIndex = 89;
            this.feelsLikeTempLabel.Text = "Feels Like:";
            this.feelsLikeTempLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // feelsLikeTempOutput
            // 
            this.feelsLikeTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeTempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeTempOutput.ForeColor = System.Drawing.Color.White;
            this.feelsLikeTempOutput.Location = new System.Drawing.Point(302, 273);
            this.feelsLikeTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feelsLikeTempOutput.Name = "feelsLikeTempOutput";
            this.feelsLikeTempOutput.Size = new System.Drawing.Size(111, 21);
            this.feelsLikeTempOutput.TabIndex = 90;
            this.feelsLikeTempOutput.Text = "FeelsLikeTemp";
            this.feelsLikeTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(171, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "♡";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastUpdatedLabel.ForeColor = System.Drawing.Color.White;
            this.lastUpdatedLabel.Location = new System.Drawing.Point(102, 637);
            this.lastUpdatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(179, 21);
            this.lastUpdatedLabel.TabIndex = 92;
            this.lastUpdatedLabel.Text = "Last Updated:";
            this.lastUpdatedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastUpdatedOutput
            // 
            this.lastUpdatedOutput.BackColor = System.Drawing.Color.Transparent;
            this.lastUpdatedOutput.ForeColor = System.Drawing.Color.White;
            this.lastUpdatedOutput.Location = new System.Drawing.Point(245, 637);
            this.lastUpdatedOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastUpdatedOutput.Name = "lastUpdatedOutput";
            this.lastUpdatedOutput.Size = new System.Drawing.Size(179, 21);
            this.lastUpdatedOutput.TabIndex = 93;
            this.lastUpdatedOutput.Text = "LastUpdatedDate/Time";
            this.lastUpdatedOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput.ForeColor = System.Drawing.Color.White;
            this.conditionOutput.Location = new System.Drawing.Point(71, 303);
            this.conditionOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(415, 34);
            this.conditionOutput.TabIndex = 94;
            this.conditionOutput.Text = "Condition";
            this.conditionOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(441, 561);
            this.windLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(98, 21);
            this.windLabel.TabIndex = 95;
            this.windLabel.Text = "Wind";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // windOutput
            // 
            this.windOutput.BackColor = System.Drawing.Color.Transparent;
            this.windOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windOutput.ForeColor = System.Drawing.Color.White;
            this.windOutput.Location = new System.Drawing.Point(360, 585);
            this.windOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windOutput.Name = "windOutput";
            this.windOutput.Size = new System.Drawing.Size(179, 21);
            this.windOutput.TabIndex = 96;
            this.windOutput.Text = "WindDirection/Speed";
            this.windOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pressureOutput
            // 
            this.pressureOutput.BackColor = System.Drawing.Color.Transparent;
            this.pressureOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureOutput.ForeColor = System.Drawing.Color.White;
            this.pressureOutput.Location = new System.Drawing.Point(12, 585);
            this.pressureOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureOutput.Name = "pressureOutput";
            this.pressureOutput.Size = new System.Drawing.Size(192, 21);
            this.pressureOutput.TabIndex = 97;
            this.pressureOutput.Text = "PresureAmount";
            this.pressureOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureLabel
            // 
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.Color.White;
            this.pressureLabel.Location = new System.Drawing.Point(11, 561);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(130, 21);
            this.pressureLabel.TabIndex = 98;
            this.pressureLabel.Text = "Pressure";
            this.pressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(563, 694);
            this.pictureBoxBG.TabIndex = 99;
            this.pictureBoxBG.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(10, 25);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(115, 46);
            this.searchLabel.TabIndex = 100;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-23, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 36);
            this.label2.TabIndex = 101;
            this.label2.Text = "_______________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.pressureOutput);
            this.Controls.Add(this.windOutput);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.lastUpdatedOutput);
            this.Controls.Add(this.lastUpdatedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feelsLikeTempOutput);
            this.Controls.Add(this.feelsLikeTempLabel);
            this.Controls.Add(this.visibilityOutput);
            this.Controls.Add(this.visibilityLabel);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.precipitationOutput);
            this.Controls.Add(this.precipitationLabel);
            this.Controls.Add(this.chanceOutput);
            this.Controls.Add(this.chanceOfLabel);
            this.Controls.Add(this.lowOutput);
            this.Controls.Add(this.highOutput);
            this.Controls.Add(this.hlLabel);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxBG);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(563, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label hlLabel;
        private System.Windows.Forms.Label highOutput;
        private System.Windows.Forms.Label lowOutput;
        private System.Windows.Forms.Label chanceOfLabel;
        private System.Windows.Forms.Label chanceOutput;
        private System.Windows.Forms.Label precipitationLabel;
        private System.Windows.Forms.Label precipitationOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label visibilityLabel;
        private System.Windows.Forms.Label visibilityOutput;
        private System.Windows.Forms.Label feelsLikeTempLabel;
        private System.Windows.Forms.Label feelsLikeTempOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastUpdatedLabel;
        private System.Windows.Forms.Label lastUpdatedOutput;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windOutput;
        private System.Windows.Forms.Label pressureOutput;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label2;
    }
}
