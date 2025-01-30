namespace SOAP_BaiTap_01_World_Client
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_GetAllCountries = new System.Windows.Forms.Button();
            this.Bt_GetCountryByCode = new System.Windows.Forms.Button();
            this.bt_GetCitiesByCountry = new System.Windows.Forms.Button();
            this.Bt_GetCitysByName = new System.Windows.Forms.Button();
            this.Responsive_Data = new System.Windows.Forms.DataGridView();
            this.Txt_Country = new System.Windows.Forms.TextBox();
            this.Txt_CityName = new System.Windows.Forms.TextBox();
            this.Txt_CountryCode = new System.Windows.Forms.TextBox();
            this.Bt_GetAllContinents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Responsive_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_GetAllCountries
            // 
            this.bt_GetAllCountries.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_GetAllCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GetAllCountries.Location = new System.Drawing.Point(24, 24);
            this.bt_GetAllCountries.Name = "bt_GetAllCountries";
            this.bt_GetAllCountries.Size = new System.Drawing.Size(149, 68);
            this.bt_GetAllCountries.TabIndex = 0;
            this.bt_GetAllCountries.Text = "Get All Countries";
            this.bt_GetAllCountries.UseVisualStyleBackColor = false;
            this.bt_GetAllCountries.Click += new System.EventHandler(this.bt_GetAllCountries_Click);
            // 
            // Bt_GetCountryByCode
            // 
            this.Bt_GetCountryByCode.BackColor = System.Drawing.Color.Gold;
            this.Bt_GetCountryByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_GetCountryByCode.Location = new System.Drawing.Point(24, 569);
            this.Bt_GetCountryByCode.Name = "Bt_GetCountryByCode";
            this.Bt_GetCountryByCode.Size = new System.Drawing.Size(149, 68);
            this.Bt_GetCountryByCode.TabIndex = 1;
            this.Bt_GetCountryByCode.Text = "Get Country By Code";
            this.Bt_GetCountryByCode.UseVisualStyleBackColor = false;
            this.Bt_GetCountryByCode.Click += new System.EventHandler(this.Bt_GetCountryByCode_Click);
            // 
            // bt_GetCitiesByCountry
            // 
            this.bt_GetCitiesByCountry.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_GetCitiesByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GetCitiesByCountry.Location = new System.Drawing.Point(24, 287);
            this.bt_GetCitiesByCountry.Name = "bt_GetCitiesByCountry";
            this.bt_GetCitiesByCountry.Size = new System.Drawing.Size(149, 68);
            this.bt_GetCitiesByCountry.TabIndex = 2;
            this.bt_GetCitiesByCountry.Text = "Get Cities By Country";
            this.bt_GetCitiesByCountry.UseVisualStyleBackColor = false;
            this.bt_GetCitiesByCountry.Click += new System.EventHandler(this.bt_GetCitiesByCountry_Click);
            // 
            // Bt_GetCitysByName
            // 
            this.Bt_GetCitysByName.BackColor = System.Drawing.Color.RosyBrown;
            this.Bt_GetCitysByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_GetCitysByName.Location = new System.Drawing.Point(24, 432);
            this.Bt_GetCitysByName.Name = "Bt_GetCitysByName";
            this.Bt_GetCitysByName.Size = new System.Drawing.Size(149, 68);
            this.Bt_GetCitysByName.TabIndex = 3;
            this.Bt_GetCitysByName.Text = "Get Citys By Name";
            this.Bt_GetCitysByName.UseVisualStyleBackColor = false;
            this.Bt_GetCitysByName.Click += new System.EventHandler(this.Bt_GetCitysByName_Click);
            // 
            // Responsive_Data
            // 
            this.Responsive_Data.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.Responsive_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Responsive_Data.Location = new System.Drawing.Point(325, 24);
            this.Responsive_Data.Name = "Responsive_Data";
            this.Responsive_Data.RowHeadersWidth = 51;
            this.Responsive_Data.RowTemplate.Height = 24;
            this.Responsive_Data.Size = new System.Drawing.Size(621, 603);
            this.Responsive_Data.TabIndex = 4;
            // 
            // Txt_Country
            // 
            this.Txt_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Country.Location = new System.Drawing.Point(198, 314);
            this.Txt_Country.Name = "Txt_Country";
            this.Txt_Country.Size = new System.Drawing.Size(100, 30);
            this.Txt_Country.TabIndex = 5;
            // 
            // Txt_CityName
            // 
            this.Txt_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CityName.Location = new System.Drawing.Point(198, 449);
            this.Txt_CityName.Name = "Txt_CityName";
            this.Txt_CityName.Size = new System.Drawing.Size(100, 30);
            this.Txt_CityName.TabIndex = 6;
            // 
            // Txt_CountryCode
            // 
            this.Txt_CountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CountryCode.Location = new System.Drawing.Point(198, 597);
            this.Txt_CountryCode.Name = "Txt_CountryCode";
            this.Txt_CountryCode.Size = new System.Drawing.Size(100, 30);
            this.Txt_CountryCode.TabIndex = 7;
            // 
            // Bt_GetAllContinents
            // 
            this.Bt_GetAllContinents.BackColor = System.Drawing.SystemColors.Highlight;
            this.Bt_GetAllContinents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_GetAllContinents.Location = new System.Drawing.Point(24, 159);
            this.Bt_GetAllContinents.Name = "Bt_GetAllContinents";
            this.Bt_GetAllContinents.Size = new System.Drawing.Size(149, 68);
            this.Bt_GetAllContinents.TabIndex = 8;
            this.Bt_GetAllContinents.Text = "Get All Continents";
            this.Bt_GetAllContinents.UseVisualStyleBackColor = false;
            this.Bt_GetAllContinents.Click += new System.EventHandler(this.Bt_GetAllContinents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 730);
            this.Controls.Add(this.Bt_GetAllContinents);
            this.Controls.Add(this.Txt_CountryCode);
            this.Controls.Add(this.Txt_CityName);
            this.Controls.Add(this.Txt_Country);
            this.Controls.Add(this.Responsive_Data);
            this.Controls.Add(this.Bt_GetCitysByName);
            this.Controls.Add(this.bt_GetCitiesByCountry);
            this.Controls.Add(this.Bt_GetCountryByCode);
            this.Controls.Add(this.bt_GetAllCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Responsive_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_GetAllCountries;
        private System.Windows.Forms.Button Bt_GetCountryByCode;
        private System.Windows.Forms.Button bt_GetCitiesByCountry;
        private System.Windows.Forms.Button Bt_GetCitysByName;
        private System.Windows.Forms.DataGridView Responsive_Data;
        private System.Windows.Forms.TextBox Txt_Country;
        private System.Windows.Forms.TextBox Txt_CityName;
        private System.Windows.Forms.TextBox Txt_CountryCode;
        private System.Windows.Forms.Button Bt_GetAllContinents;
    }
}

