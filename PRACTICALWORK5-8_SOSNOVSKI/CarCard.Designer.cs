namespace PRACTICALWORK5_8_SOSNOVSKI
{
    partial class CarCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblBrand = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            lblMileage = new Label();
            lblColor = new Label();
            lblVIN = new Label();
            btnEditCard = new Button();
            btnDeleteCard = new Button();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblBrand);
            panelMain.Controls.Add(lblModel);
            panelMain.Controls.Add(lblYear);
            panelMain.Controls.Add(lblPrice);
            panelMain.Controls.Add(lblMileage);
            panelMain.Controls.Add(lblColor);
            panelMain.Controls.Add(lblVIN);
            panelMain.Controls.Add(btnEditCard);
            panelMain.Controls.Add(btnDeleteCard);
            panelMain.Location = new Point(3, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(350, 220);
            panelMain.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(52, 152, 219);
            lblBrand.Location = new Point(15, 15);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(99, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Производитель";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblModel.ForeColor = Color.FromArgb(44, 62, 80);
            lblModel.Location = new Point(15, 40);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(66, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Модель";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.ForeColor = Color.FromArgb(127, 140, 141);
            lblYear.Location = new Point(15, 70);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(26, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "Год";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(39, 174, 96);
            lblPrice.Location = new Point(15, 95);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 19);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Цена";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI", 9F);
            lblMileage.ForeColor = Color.FromArgb(127, 140, 141);
            lblMileage.Location = new Point(15, 120);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(48, 15);
            lblMileage.TabIndex = 4;
            lblMileage.Text = "Пробег";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F);
            lblColor.ForeColor = Color.FromArgb(127, 140, 141);
            lblColor.Location = new Point(15, 145);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(33, 15);
            lblColor.TabIndex = 5;
            lblColor.Text = "Цвет";
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Font = new Font("Segoe UI", 8F);
            lblVIN.ForeColor = Color.FromArgb(127, 140, 141);
            lblVIN.Location = new Point(15, 170);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(25, 13);
            lblVIN.TabIndex = 6;
            lblVIN.Text = "VIN";
            // 
            // btnEditCard
            // 
            btnEditCard.BackColor = Color.FromArgb(52, 152, 219);
            btnEditCard.FlatAppearance.BorderSize = 0;
            btnEditCard.FlatStyle = FlatStyle.Flat;
            btnEditCard.Font = new Font("Segoe UI", 9F);
            btnEditCard.ForeColor = Color.White;
            btnEditCard.Location = new Point(220, 15);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(110, 30);
            btnEditCard.TabIndex = 0;
            btnEditCard.Text = "Изменить";
            btnEditCard.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCard
            // 
            btnDeleteCard.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteCard.FlatAppearance.BorderSize = 0;
            btnDeleteCard.FlatStyle = FlatStyle.Flat;
            btnDeleteCard.Font = new Font("Segoe UI", 9F);
            btnDeleteCard.ForeColor = Color.White;
            btnDeleteCard.Location = new Point(220, 50);
            btnDeleteCard.Name = "btnDeleteCard";
            btnDeleteCard.Size = new Size(110, 30);
            btnDeleteCard.TabIndex = 1;
            btnDeleteCard.Text = "Удалить";
            btnDeleteCard.UseVisualStyleBackColor = false;
            // 
            // CarCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            Controls.Add(panelMain);
            Margin = new Padding(5);
            Name = "CarCard";
            Size = new Size(363, 230);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblBrand;
        private Label lblModel;
        private Label lblYear;
        private Label lblPrice;
        private Label lblMileage;
        private Label lblColor;
        private Label lblVIN;
        private Button btnEditCard;
        private Button btnDeleteCard;
    }
}