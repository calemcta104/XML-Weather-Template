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
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.conditionImage3 = new System.Windows.Forms.PictureBox();
            this.conditionImage2 = new System.Windows.Forms.PictureBox();
            this.conditionImage1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(318, 17);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.min1.Location = new System.Drawing.Point(268, 173);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(60, 65);
            this.min1.TabIndex = 48;
            this.min1.Text = "min";
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.Red;
            this.max1.Location = new System.Drawing.Point(367, 173);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(61, 65);
            this.max1.TabIndex = 45;
            this.max1.Text = "max";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(275, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(63, 134);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(91, 37);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date1";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(63, 291);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(91, 37);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date2";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.min2.Location = new System.Drawing.Point(268, 332);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(60, 65);
            this.min2.TabIndex = 68;
            this.min2.Text = "min";
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.ForeColor = System.Drawing.Color.Red;
            this.max2.Location = new System.Drawing.Point(368, 331);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(60, 65);
            this.max2.TabIndex = 66;
            this.max2.Text = "max";
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.min3.Location = new System.Drawing.Point(268, 485);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(60, 65);
            this.min3.TabIndex = 70;
            this.min3.Text = "min";
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.ForeColor = System.Drawing.Color.Red;
            this.max3.Location = new System.Drawing.Point(368, 485);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(60, 65);
            this.max3.TabIndex = 71;
            this.max3.Text = "max";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(63, 445);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(91, 37);
            this.date3.TabIndex = 72;
            this.date3.Text = "Date3";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(30, 80);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(48, 29);
            this.cityLabel.TabIndex = 74;
            this.cityLabel.Text = "city";
            // 
            // conditionImage3
            // 
            this.conditionImage3.BackColor = System.Drawing.Color.Transparent;
            this.conditionImage3.Location = new System.Drawing.Point(35, 485);
            this.conditionImage3.Name = "conditionImage3";
            this.conditionImage3.Size = new System.Drawing.Size(108, 100);
            this.conditionImage3.TabIndex = 76;
            this.conditionImage3.TabStop = false;
            // 
            // conditionImage2
            // 
            this.conditionImage2.BackColor = System.Drawing.Color.Transparent;
            this.conditionImage2.Location = new System.Drawing.Point(35, 331);
            this.conditionImage2.Name = "conditionImage2";
            this.conditionImage2.Size = new System.Drawing.Size(108, 95);
            this.conditionImage2.TabIndex = 75;
            this.conditionImage2.TabStop = false;
            // 
            // conditionImage1
            // 
            this.conditionImage1.BackColor = System.Drawing.Color.Transparent;
            this.conditionImage1.Location = new System.Drawing.Point(35, 173);
            this.conditionImage1.Name = "conditionImage1";
            this.conditionImage1.Size = new System.Drawing.Size(104, 87);
            this.conditionImage1.TabIndex = 73;
            this.conditionImage1.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.cloudy_sky2;
            this.Controls.Add(this.conditionImage3);
            this.Controls.Add(this.conditionImage2);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.conditionImage1);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(450, 600);
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.PictureBox conditionImage1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox conditionImage2;
        private System.Windows.Forms.PictureBox conditionImage3;
    }
}
