namespace M7P1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            radioAllBuyers = new RadioButton();
            radioAllEmails = new RadioButton();
            radioSectionList = new RadioButton();
            radioPromotionalProducts = new RadioButton();
            radioAllCities = new RadioButton();
            radioButton1 = new RadioButton();
            comboCity = new ComboBox();
            radioBuyersFromCity = new RadioButton();
            comboCountry = new ComboBox();
            radioAllBuyersFromSpecificCountry = new RadioButton();
            comboPromotionsForSpecificCountry = new ComboBox();
            radioAllPromotionsForSpecificCountry = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 204);
            dataGridView1.TabIndex = 0;
            // 
            // radioAllBuyers
            // 
            radioAllBuyers.AutoSize = true;
            radioAllBuyers.Location = new Point(12, 12);
            radioAllBuyers.Name = "radioAllBuyers";
            radioAllBuyers.Size = new Size(77, 19);
            radioAllBuyers.TabIndex = 1;
            radioAllBuyers.TabStop = true;
            radioAllBuyers.Text = "All buyers";
            radioAllBuyers.UseVisualStyleBackColor = true;
            radioAllBuyers.CheckedChanged += radioAllBuyers_CheckedChanged;
            // 
            // radioAllEmails
            // 
            radioAllEmails.AutoSize = true;
            radioAllEmails.Location = new Point(12, 37);
            radioAllEmails.Name = "radioAllEmails";
            radioAllEmails.Size = new Size(76, 19);
            radioAllEmails.TabIndex = 2;
            radioAllEmails.TabStop = true;
            radioAllEmails.Text = "All Emails";
            radioAllEmails.UseVisualStyleBackColor = true;
            radioAllEmails.CheckedChanged += radioAllEmails_CheckedChanged;
            // 
            // radioSectionList
            // 
            radioSectionList.AutoSize = true;
            radioSectionList.Location = new Point(12, 62);
            radioSectionList.Name = "radioSectionList";
            radioSectionList.Size = new Size(82, 19);
            radioSectionList.TabIndex = 3;
            radioSectionList.TabStop = true;
            radioSectionList.Text = "Section list";
            radioSectionList.UseVisualStyleBackColor = true;
            radioSectionList.CheckedChanged += radioSectionList_CheckedChanged;
            // 
            // radioPromotionalProducts
            // 
            radioPromotionalProducts.AutoSize = true;
            radioPromotionalProducts.Location = new Point(12, 87);
            radioPromotionalProducts.Name = "radioPromotionalProducts";
            radioPromotionalProducts.Size = new Size(176, 19);
            radioPromotionalProducts.TabIndex = 4;
            radioPromotionalProducts.TabStop = true;
            radioPromotionalProducts.Text = "List of promotional products";
            radioPromotionalProducts.UseVisualStyleBackColor = true;
            radioPromotionalProducts.CheckedChanged += radioPromotionalProducts_CheckedChanged;
            // 
            // radioAllCities
            // 
            radioAllCities.AutoSize = true;
            radioAllCities.Location = new Point(12, 112);
            radioAllCities.Name = "radioAllCities";
            radioAllCities.Size = new Size(69, 19);
            radioAllCities.TabIndex = 5;
            radioAllCities.TabStop = true;
            radioAllCities.Text = "All cities";
            radioAllCities.UseVisualStyleBackColor = true;
            radioAllCities.CheckedChanged += radioAllCities_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 137);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "All Countries";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboCity
            // 
            comboCity.FormattingEnabled = true;
            comboCity.Items.AddRange(new object[] { "New York", "Toronto", "London", "Sydney", "Tokyo", "Berlin", "Paris", "Barcelona", "Beijing" });
            comboCity.Location = new Point(246, 8);
            comboCity.Name = "comboCity";
            comboCity.Size = new Size(121, 23);
            comboCity.TabIndex = 7;
            comboCity.SelectedIndexChanged += radioBuyersFromCity_CheckedChanged;
            // 
            // radioBuyersFromCity
            // 
            radioBuyersFromCity.AutoSize = true;
            radioBuyersFromCity.Location = new Point(373, 12);
            radioBuyersFromCity.Name = "radioBuyersFromCity";
            radioBuyersFromCity.Size = new Size(176, 19);
            radioBuyersFromCity.TabIndex = 8;
            radioBuyersFromCity.TabStop = true;
            radioBuyersFromCity.Text = "All buyers from a certain city";
            radioBuyersFromCity.UseVisualStyleBackColor = true;
            radioBuyersFromCity.CheckedChanged += radioBuyersFromCity_CheckedChanged;
            // 
            // comboCountry
            // 
            comboCountry.FormattingEnabled = true;
            comboCountry.Items.AddRange(new object[] { "USA", "Canada", "UK", "Australia", "Japan", "Germany", "France", "Spain", "China" });
            comboCountry.Location = new Point(246, 37);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(121, 23);
            comboCountry.TabIndex = 9;
            comboCountry.SelectedIndexChanged += radioAllBuyersFromSpecificCountry_CheckedChanged;
            // 
            // radioAllBuyersFromSpecificCountry
            // 
            radioAllBuyersFromSpecificCountry.AutoSize = true;
            radioAllBuyersFromSpecificCountry.Location = new Point(373, 41);
            radioAllBuyersFromSpecificCountry.Name = "radioAllBuyersFromSpecificCountry";
            radioAllBuyersFromSpecificCountry.Size = new Size(202, 19);
            radioAllBuyersFromSpecificCountry.TabIndex = 10;
            radioAllBuyersFromSpecificCountry.TabStop = true;
            radioAllBuyersFromSpecificCountry.Text = "All buyers from a specific country";
            radioAllBuyersFromSpecificCountry.UseVisualStyleBackColor = true;
            radioAllBuyersFromSpecificCountry.CheckedChanged += radioAllBuyersFromSpecificCountry_CheckedChanged;
            // 
            // comboPromotionsForSpecificCountry
            // 
            comboPromotionsForSpecificCountry.FormattingEnabled = true;
            comboPromotionsForSpecificCountry.Items.AddRange(new object[] { "USA", "Canada", "UK", "Australia", "Japan", "Germany", "France", "Spain", "China" });
            comboPromotionsForSpecificCountry.Location = new Point(246, 66);
            comboPromotionsForSpecificCountry.Name = "comboPromotionsForSpecificCountry";
            comboPromotionsForSpecificCountry.Size = new Size(121, 23);
            comboPromotionsForSpecificCountry.TabIndex = 11;
            comboPromotionsForSpecificCountry.SelectedIndexChanged += radioAllPromotionsForSpecificCountry_CheckedChanged;
            // 
            // radioAllPromotionsForSpecificCountry
            // 
            radioAllPromotionsForSpecificCountry.AutoSize = true;
            radioAllPromotionsForSpecificCountry.Location = new Point(373, 70);
            radioAllPromotionsForSpecificCountry.Name = "radioAllPromotionsForSpecificCountry";
            radioAllPromotionsForSpecificCountry.Size = new Size(218, 19);
            radioAllPromotionsForSpecificCountry.TabIndex = 12;
            radioAllPromotionsForSpecificCountry.TabStop = true;
            radioAllPromotionsForSpecificCountry.Text = "All promotions for a specific country";
            radioAllPromotionsForSpecificCountry.UseVisualStyleBackColor = true;
            radioAllPromotionsForSpecificCountry.CheckedChanged += radioAllPromotionsForSpecificCountry_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(radioAllPromotionsForSpecificCountry);
            Controls.Add(comboPromotionsForSpecificCountry);
            Controls.Add(radioAllBuyersFromSpecificCountry);
            Controls.Add(comboCountry);
            Controls.Add(radioBuyersFromCity);
            Controls.Add(comboCity);
            Controls.Add(radioButton1);
            Controls.Add(radioAllCities);
            Controls.Add(radioPromotionalProducts);
            Controls.Add(radioSectionList);
            Controls.Add(radioAllEmails);
            Controls.Add(radioAllBuyers);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioAllBuyers;
        private RadioButton radioAllEmails;
        private RadioButton radioSectionList;
        private RadioButton radioPromotionalProducts;
        private RadioButton radioAllCities;
        private RadioButton radioButton1;
        private ComboBox comboCity;
        private RadioButton radioBuyersFromCity;
        private ComboBox comboCountry;
        private RadioButton radioAllBuyersFromSpecificCountry;
        private ComboBox comboPromotionsForSpecificCountry;
        private RadioButton radioAllPromotionsForSpecificCountry;
    }
}
