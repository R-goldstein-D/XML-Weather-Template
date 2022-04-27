namespace XMLWeather
{
    partial class ForecastScreen
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
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nextDayDateOutput = new System.Windows.Forms.Label();
            this.nextDayMaxOutput = new System.Windows.Forms.Label();
            this.nextDayMinOutput = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.date1Icon = new System.Windows.Forms.PictureBox();
            this.date2Icon = new System.Windows.Forms.PictureBox();
            this.date3Icon = new System.Windows.Forms.PictureBox();
            this.date4Icon = new System.Windows.Forms.PictureBox();
            this.date5Icon = new System.Windows.Forms.PictureBox();
            this.date6Icon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.date1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date4Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date5Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date6Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(402, 21);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(124, 43);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "6 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 43);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(366, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 41);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextDayDateOutput
            // 
            this.nextDayDateOutput.AutoSize = true;
            this.nextDayDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.nextDayDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayDateOutput.ForeColor = System.Drawing.Color.White;
            this.nextDayDateOutput.Location = new System.Drawing.Point(47, 180);
            this.nextDayDateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextDayDateOutput.Name = "nextDayDateOutput";
            this.nextDayDateOutput.Size = new System.Drawing.Size(63, 29);
            this.nextDayDateOutput.TabIndex = 75;
            this.nextDayDateOutput.Text = "Date";
            // 
            // nextDayMaxOutput
            // 
            this.nextDayMaxOutput.AutoSize = true;
            this.nextDayMaxOutput.BackColor = System.Drawing.Color.Transparent;
            this.nextDayMaxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayMaxOutput.ForeColor = System.Drawing.Color.White;
            this.nextDayMaxOutput.Location = new System.Drawing.Point(382, 180);
            this.nextDayMaxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextDayMaxOutput.Name = "nextDayMaxOutput";
            this.nextDayMaxOutput.Size = new System.Drawing.Size(57, 29);
            this.nextDayMaxOutput.TabIndex = 76;
            this.nextDayMaxOutput.Text = "Max";
            this.nextDayMaxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nextDayMinOutput
            // 
            this.nextDayMinOutput.AutoSize = true;
            this.nextDayMinOutput.BackColor = System.Drawing.Color.Transparent;
            this.nextDayMinOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDayMinOutput.ForeColor = System.Drawing.Color.White;
            this.nextDayMinOutput.Location = new System.Drawing.Point(257, 180);
            this.nextDayMinOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextDayMinOutput.Name = "nextDayMinOutput";
            this.nextDayMinOutput.Size = new System.Drawing.Size(52, 29);
            this.nextDayMinOutput.TabIndex = 77;
            this.nextDayMinOutput.Text = "Min";
            this.nextDayMinOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(48, 256);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 25);
            this.date.TabIndex = 78;
            this.date.Text = "Date";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(382, 256);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(50, 25);
            this.maxOutput.TabIndex = 79;
            this.maxOutput.Text = "Max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(258, 256);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(44, 25);
            this.minOutput.TabIndex = 80;
            this.minOutput.Text = "Min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // date1Icon
            // 
            this.date1Icon.BackColor = System.Drawing.Color.Transparent;
            this.date1Icon.Location = new System.Drawing.Point(461, 157);
            this.date1Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date1Icon.Name = "date1Icon";
            this.date1Icon.Size = new System.Drawing.Size(66, 68);
            this.date1Icon.TabIndex = 81;
            this.date1Icon.TabStop = false;
            // 
            // date2Icon
            // 
            this.date2Icon.BackColor = System.Drawing.Color.Transparent;
            this.date2Icon.Location = new System.Drawing.Point(478, 243);
            this.date2Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date2Icon.Name = "date2Icon";
            this.date2Icon.Size = new System.Drawing.Size(45, 52);
            this.date2Icon.TabIndex = 82;
            this.date2Icon.TabStop = false;
            // 
            // date3Icon
            // 
            this.date3Icon.BackColor = System.Drawing.Color.Transparent;
            this.date3Icon.Location = new System.Drawing.Point(477, 319);
            this.date3Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date3Icon.Name = "date3Icon";
            this.date3Icon.Size = new System.Drawing.Size(45, 52);
            this.date3Icon.TabIndex = 83;
            this.date3Icon.TabStop = false;
            // 
            // date4Icon
            // 
            this.date4Icon.BackColor = System.Drawing.Color.Transparent;
            this.date4Icon.Location = new System.Drawing.Point(477, 394);
            this.date4Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date4Icon.Name = "date4Icon";
            this.date4Icon.Size = new System.Drawing.Size(45, 52);
            this.date4Icon.TabIndex = 84;
            this.date4Icon.TabStop = false;
            // 
            // date5Icon
            // 
            this.date5Icon.BackColor = System.Drawing.Color.Transparent;
            this.date5Icon.Location = new System.Drawing.Point(477, 470);
            this.date5Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date5Icon.Name = "date5Icon";
            this.date5Icon.Size = new System.Drawing.Size(45, 52);
            this.date5Icon.TabIndex = 85;
            this.date5Icon.TabStop = false;
            // 
            // date6Icon
            // 
            this.date6Icon.BackColor = System.Drawing.Color.Transparent;
            this.date6Icon.Location = new System.Drawing.Point(477, 550);
            this.date6Icon.Margin = new System.Windows.Forms.Padding(2);
            this.date6Icon.Name = "date6Icon";
            this.date6Icon.Size = new System.Drawing.Size(45, 52);
            this.date6Icon.TabIndex = 86;
            this.date6Icon.TabStop = false;
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(563, 694);
            this.pictureBoxBG.TabIndex = 100;
            this.pictureBoxBG.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(15, 24);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(115, 46);
            this.searchLabel.TabIndex = 101;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.date6Icon);
            this.Controls.Add(this.date5Icon);
            this.Controls.Add(this.date4Icon);
            this.Controls.Add(this.date3Icon);
            this.Controls.Add(this.date2Icon);
            this.Controls.Add(this.date1Icon);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nextDayMinOutput);
            this.Controls.Add(this.nextDayMaxOutput);
            this.Controls.Add(this.nextDayDateOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxBG);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(563, 700);
            ((System.ComponentModel.ISupportInitialize)(this.date1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date2Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date4Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date5Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date6Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nextDayDateOutput;
        private System.Windows.Forms.Label nextDayMaxOutput;
        private System.Windows.Forms.Label nextDayMinOutput;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.PictureBox date1Icon;
        private System.Windows.Forms.PictureBox date2Icon;
        private System.Windows.Forms.PictureBox date3Icon;
        private System.Windows.Forms.PictureBox date4Icon;
        private System.Windows.Forms.PictureBox date5Icon;
        private System.Windows.Forms.PictureBox date6Icon;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.Label searchLabel;
    }
}
