namespace XMLWeather
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
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunriseOutput = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunsetOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(221, 78);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(106, 35);
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
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
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
            this.currentTempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(65, 148);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(415, 61);
            this.currentTempOutput.TabIndex = 71;
            this.currentTempOutput.Text = "Temp";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hlLabel
            // 
            this.hlLabel.AutoSize = true;
            this.hlLabel.BackColor = System.Drawing.Color.Transparent;
            this.hlLabel.ForeColor = System.Drawing.Color.White;
            this.hlLabel.Location = new System.Drawing.Point(205, 229);
            this.hlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hlLabel.Name = "hlLabel";
            this.hlLabel.Size = new System.Drawing.Size(110, 20);
            this.hlLabel.TabIndex = 72;
            this.hlLabel.Text = "H:                 L: ";
            // 
            // highOutput
            // 
            this.highOutput.AutoSize = true;
            this.highOutput.BackColor = System.Drawing.Color.Transparent;
            this.highOutput.ForeColor = System.Drawing.Color.White;
            this.highOutput.Location = new System.Drawing.Point(230, 229);
            this.highOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highOutput.Name = "highOutput";
            this.highOutput.Size = new System.Drawing.Size(39, 20);
            this.highOutput.TabIndex = 73;
            this.highOutput.Text = "high";
            // 
            // lowOutput
            // 
            this.lowOutput.AutoSize = true;
            this.lowOutput.BackColor = System.Drawing.Color.Transparent;
            this.lowOutput.ForeColor = System.Drawing.Color.White;
            this.lowOutput.Location = new System.Drawing.Point(310, 229);
            this.lowOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowOutput.Name = "lowOutput";
            this.lowOutput.Size = new System.Drawing.Size(32, 20);
            this.lowOutput.TabIndex = 74;
            this.lowOutput.Text = "low";
            this.lowOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chanceOfLabel
            // 
            this.chanceOfLabel.BackColor = System.Drawing.Color.Transparent;
            this.chanceOfLabel.ForeColor = System.Drawing.Color.White;
            this.chanceOfLabel.Location = new System.Drawing.Point(36, 445);
            this.chanceOfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chanceOfLabel.Name = "chanceOfLabel";
            this.chanceOfLabel.Size = new System.Drawing.Size(193, 21);
            this.chanceOfLabel.TabIndex = 75;
            this.chanceOfLabel.Text = "Chance of Precipitation";
            this.chanceOfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chanceOutput
            // 
            this.chanceOutput.BackColor = System.Drawing.Color.Transparent;
            this.chanceOutput.ForeColor = System.Drawing.Color.White;
            this.chanceOutput.Location = new System.Drawing.Point(36, 478);
            this.chanceOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chanceOutput.Name = "chanceOutput";
            this.chanceOutput.Size = new System.Drawing.Size(163, 21);
            this.chanceOutput.TabIndex = 76;
            this.chanceOutput.Text = "ChancePercent";
            this.chanceOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // precipitationLabel
            // 
            this.precipitationLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipitationLabel.ForeColor = System.Drawing.Color.White;
            this.precipitationLabel.Location = new System.Drawing.Point(53, 538);
            this.precipitationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationLabel.Name = "precipitationLabel";
            this.precipitationLabel.Size = new System.Drawing.Size(130, 21);
            this.precipitationLabel.TabIndex = 77;
            this.precipitationLabel.Text = "Precipitation";
            this.precipitationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // precipitationOutput
            // 
            this.precipitationOutput.BackColor = System.Drawing.Color.Transparent;
            this.precipitationOutput.ForeColor = System.Drawing.Color.White;
            this.precipitationOutput.Location = new System.Drawing.Point(36, 580);
            this.precipitationOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precipitationOutput.Name = "precipitationOutput";
            this.precipitationOutput.Size = new System.Drawing.Size(168, 21);
            this.precipitationOutput.TabIndex = 78;
            this.precipitationOutput.Text = "PrecipitationAmount";
            this.precipitationOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.ForeColor = System.Drawing.Color.White;
            this.sunriseLabel.Location = new System.Drawing.Point(53, 326);
            this.sunriseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(78, 21);
            this.sunriseLabel.TabIndex = 79;
            this.sunriseLabel.Text = "Sunrise";
            this.sunriseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sunriseOutput
            // 
            this.sunriseOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunriseOutput.ForeColor = System.Drawing.Color.White;
            this.sunriseOutput.Location = new System.Drawing.Point(26, 347);
            this.sunriseOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunriseOutput.Name = "sunriseOutput";
            this.sunriseOutput.Size = new System.Drawing.Size(127, 21);
            this.sunriseOutput.TabIndex = 80;
            this.sunriseOutput.Text = "SunriseTime";
            this.sunriseOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.ForeColor = System.Drawing.Color.White;
            this.sunsetLabel.Location = new System.Drawing.Point(452, 313);
            this.sunsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(63, 21);
            this.sunsetLabel.TabIndex = 81;
            this.sunsetLabel.Text = "Sunset";
            this.sunsetLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sunsetOutput
            // 
            this.sunsetOutput.BackColor = System.Drawing.Color.Transparent;
            this.sunsetOutput.ForeColor = System.Drawing.Color.White;
            this.sunsetOutput.Location = new System.Drawing.Point(424, 334);
            this.sunsetOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sunsetOutput.Name = "sunsetOutput";
            this.sunsetOutput.Size = new System.Drawing.Size(124, 21);
            this.sunsetOutput.TabIndex = 82;
            this.sunsetOutput.Text = "SunsetTime";
            this.sunsetOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(433, 408);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(82, 21);
            this.humidityLabel.TabIndex = 84;
            this.humidityLabel.Text = "Humidity";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(406, 429);
            this.humidityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(130, 21);
            this.humidityOutput.TabIndex = 85;
            this.humidityOutput.Text = "HumidityPercent";
            this.humidityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.sunsetOutput);
            this.Controls.Add(this.sunsetLabel);
            this.Controls.Add(this.sunriseOutput);
            this.Controls.Add(this.sunriseLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(563, 700);
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
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunriseOutput;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunsetOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label humidityOutput;
    }
}
