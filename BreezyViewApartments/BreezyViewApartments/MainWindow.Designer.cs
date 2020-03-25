/*
 * Create a project named BreezyViewApartments that contains a Form for an apartment rental service. 
 * Allow the user to choose a number of bedrooms, number of baths, and view—street or lake. 
 * After the user makes selections, display the monthly rent, 
 * which is calculated using a base price of $450, $550, or $700 per month 
 * for a one-, two-, or three-bedroom apartment, respectively. 
 * $75 is added to the base price for more than one bath, 
 * and $50 additional is added to the price for a lake view. 
 * Use the Controls that you think are best for each function. 
 * Label items appropriately, and use fonts and colors to achieve an attractive design.
*/
namespace BreezyViewApartments
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.comboBoxBedroom = new System.Windows.Forms.ComboBox();
            this.labelBedrooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBath = new System.Windows.Forms.ComboBox();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBedPrice = new System.Windows.Forms.Label();
            this.labelBathPrice = new System.Windows.Forms.Label();
            this.labelViewPrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBedroom
            // 
            this.comboBoxBedroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBedroom.FormattingEnabled = true;
            this.comboBoxBedroom.Items.AddRange(new object[] {
            "1 - Bedroom",
            "2 - Bedroom",
            "3 - Bedroom"});
            this.comboBoxBedroom.Location = new System.Drawing.Point(520, 150);
            this.comboBoxBedroom.Name = "comboBoxBedroom";
            this.comboBoxBedroom.Size = new System.Drawing.Size(250, 33);
            this.comboBoxBedroom.TabIndex = 0;
            this.comboBoxBedroom.SelectedIndexChanged += new System.EventHandler(this.BedroomChange);
            // 
            // labelBedrooms
            // 
            this.labelBedrooms.AutoSize = true;
            this.labelBedrooms.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedrooms.Location = new System.Drawing.Point(194, 150);
            this.labelBedrooms.Name = "labelBedrooms";
            this.labelBedrooms.Size = new System.Drawing.Size(300, 33);
            this.labelBedrooms.TabIndex = 1;
            this.labelBedrooms.Text = "Number of Bedrooms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bungee Shade", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 97);
            this.label1.TabIndex = 2;
            this.label1.Text = "BREEZY VIEW APPARTMENTS";
            // 
            // comboBoxBath
            // 
            this.comboBoxBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBath.FormattingEnabled = true;
            this.comboBoxBath.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxBath.Location = new System.Drawing.Point(520, 250);
            this.comboBoxBath.Name = "comboBoxBath";
            this.comboBoxBath.Size = new System.Drawing.Size(250, 33);
            this.comboBoxBath.TabIndex = 3;
            this.comboBoxBath.SelectedIndexChanged += new System.EventHandler(this.BathChanged);
            // 
            // comboBoxView
            // 
            this.comboBoxView.AutoCompleteCustomSource.AddRange(new string[] {
            "Street View",
            "Lake View"});
            this.comboBoxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "Street View",
            "Lake View"});
            this.comboBoxView.Location = new System.Drawing.Point(520, 350);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(250, 33);
            this.comboBoxView.TabIndex = 4;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.ViewChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Baths:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "View:";
            // 
            // labelBedPrice
            // 
            this.labelBedPrice.AutoSize = true;
            this.labelBedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBedPrice.Location = new System.Drawing.Point(23, 154);
            this.labelBedPrice.Name = "labelBedPrice";
            this.labelBedPrice.Size = new System.Drawing.Size(117, 29);
            this.labelBedPrice.TabIndex = 7;
            this.labelBedPrice.Text = "+ $700.00";
            // 
            // labelBathPrice
            // 
            this.labelBathPrice.AutoSize = true;
            this.labelBathPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBathPrice.Location = new System.Drawing.Point(23, 254);
            this.labelBathPrice.Name = "labelBathPrice";
            this.labelBathPrice.Size = new System.Drawing.Size(104, 29);
            this.labelBathPrice.TabIndex = 8;
            this.labelBathPrice.Text = "+ $75.00";
            // 
            // labelViewPrice
            // 
            this.labelViewPrice.AutoSize = true;
            this.labelViewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPrice.Location = new System.Drawing.Point(23, 354);
            this.labelViewPrice.Name = "labelViewPrice";
            this.labelViewPrice.Size = new System.Drawing.Size(104, 29);
            this.labelViewPrice.TabIndex = 9;
            this.labelViewPrice.Text = "+ $50.00";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(23, 485);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(266, 29);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "TOTAL PRICE: $000.00";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(620, 464);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 50);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelViewPrice);
            this.Controls.Add(this.labelBathPrice);
            this.Controls.Add(this.labelBedPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.comboBoxBath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBedrooms);
            this.Controls.Add(this.comboBoxBedroom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBedroom;
        private System.Windows.Forms.Label labelBedrooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBath;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBedPrice;
        private System.Windows.Forms.Label labelBathPrice;
        private System.Windows.Forms.Label labelViewPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonReset;
    }
}

