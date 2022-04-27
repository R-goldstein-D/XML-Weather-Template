namespace XMLWeather
{
    partial class SearchScreen
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
            this.locationInput = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.stratfordLabel = new System.Windows.Forms.Label();
            this.waterlooLabel = new System.Windows.Forms.Label();
            this.londonLabel = new System.Windows.Forms.Label();
            this.torontoLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // locationInput
            // 
            this.locationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationInput.Location = new System.Drawing.Point(105, 204);
            this.locationInput.Margin = new System.Windows.Forms.Padding(2);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(325, 35);
            this.locationInput.TabIndex = 69;
            this.locationInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.locationInput_MouseClick);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(136, 288);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(257, 43);
            this.searchLabel.TabIndex = 70;
            this.searchLabel.Text = "Suggested Locations";
            // 
            // stratfordLabel
            // 
            this.stratfordLabel.BackColor = System.Drawing.Color.Transparent;
            this.stratfordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratfordLabel.ForeColor = System.Drawing.Color.White;
            this.stratfordLabel.Location = new System.Drawing.Point(204, 353);
            this.stratfordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stratfordLabel.Name = "stratfordLabel";
            this.stratfordLabel.Size = new System.Drawing.Size(107, 33);
            this.stratfordLabel.TabIndex = 71;
            this.stratfordLabel.Text = "Stratford";
            this.stratfordLabel.Click += new System.EventHandler(this.stratfordLabel_Click);
            // 
            // waterlooLabel
            // 
            this.waterlooLabel.BackColor = System.Drawing.Color.Transparent;
            this.waterlooLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterlooLabel.ForeColor = System.Drawing.Color.White;
            this.waterlooLabel.Location = new System.Drawing.Point(204, 423);
            this.waterlooLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waterlooLabel.Name = "waterlooLabel";
            this.waterlooLabel.Size = new System.Drawing.Size(107, 33);
            this.waterlooLabel.TabIndex = 72;
            this.waterlooLabel.Text = "Waterloo";
            this.waterlooLabel.Click += new System.EventHandler(this.waterlooLabel_Click);
            // 
            // londonLabel
            // 
            this.londonLabel.BackColor = System.Drawing.Color.Transparent;
            this.londonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonLabel.ForeColor = System.Drawing.Color.White;
            this.londonLabel.Location = new System.Drawing.Point(204, 495);
            this.londonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.londonLabel.Name = "londonLabel";
            this.londonLabel.Size = new System.Drawing.Size(107, 33);
            this.londonLabel.TabIndex = 73;
            this.londonLabel.Text = "London";
            this.londonLabel.Click += new System.EventHandler(this.londonLabel_Click);
            // 
            // torontoLabel
            // 
            this.torontoLabel.BackColor = System.Drawing.Color.Transparent;
            this.torontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torontoLabel.ForeColor = System.Drawing.Color.White;
            this.torontoLabel.Location = new System.Drawing.Point(204, 562);
            this.torontoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.torontoLabel.Name = "torontoLabel";
            this.torontoLabel.Size = new System.Drawing.Size(107, 33);
            this.torontoLabel.TabIndex = 74;
            this.torontoLabel.Text = "Toronto";
            this.torontoLabel.Click += new System.EventHandler(this.torontoLabel_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(435, 21);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(112, 46);
            this.todayLabel.TabIndex = 75;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(103, 241);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(327, 47);
            this.errorLabel.TabIndex = 76;
            this.errorLabel.Text = "errorMessage";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.searchPictureBox.Location = new System.Drawing.Point(441, 190);
            this.searchPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(45, 49);
            this.searchPictureBox.TabIndex = 77;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 80);
            this.label1.TabIndex = 78;
            this.label1.Text = "Click \"Search\" to find your city!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(262, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 30);
            this.label6.TabIndex = 108;
            this.label6.Text = "♡";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.torontoLabel);
            this.Controls.Add(this.londonLabel);
            this.Controls.Add(this.waterlooLabel);
            this.Controls.Add(this.stratfordLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.locationInput);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(563, 700);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SearchScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label stratfordLabel;
        private System.Windows.Forms.Label waterlooLabel;
        private System.Windows.Forms.Label londonLabel;
        private System.Windows.Forms.Label torontoLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
