using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PRACTICALWORK5_8_SOSNOVSKI

{
    partial class EditForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblModel = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            lblMileage = new Label();
            lblColor = new Label();
            lblVIN = new Label();
            lblBrand = new Label();

            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            txtMileage = new TextBox();
            txtColor = new TextBox();
            txtVIN = new TextBox();
            cmbBrand = new ComboBox();
            brandBindingSource = new BindingSource(components);

            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();

            // Labels
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 25);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(45, 15);
            lblModel.Text = "Модель:";

            lblYear.AutoSize = true;
            lblYear.Location = new Point(20, 65);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(35, 15);
            lblYear.Text = "Год:";

            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 105);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.Text = "Цена:";

            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(20, 145);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(50, 15);
            lblMileage.Text = "Пробег:";

            lblColor.AutoSize = true;
            lblColor.Location = new Point(20, 185);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(40, 15);
            lblColor.Text = "Цвет:";

            lblVIN.AutoSize = true;
            lblVIN.Location = new Point(20, 225);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(85, 15);
            lblVIN.Text = "VIN-номер:";

            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(20, 265);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(90, 15);
            lblBrand.Text = "Производитель:";

            // TextBoxes
            txtModel.Location = new Point(140, 22);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(300, 23);

            txtYear.Location = new Point(140, 62);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);

            txtPrice.Location = new Point(140, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TextAlign = HorizontalAlignment.Right;

            txtMileage.Location = new Point(140, 142);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(150, 23);
            txtMileage.TextAlign = HorizontalAlignment.Right;

            txtColor.Location = new Point(140, 182);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(200, 23);

            txtVIN.Location = new Point(140, 222);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(200, 23);
            txtVIN.MaxLength = 17;

            // ComboBox
            cmbBrand.DataSource = brandBindingSource;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "Id";
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(140, 262);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(200, 23);

            // BindingSource
            brandBindingSource.DataSource = typeof(Models.Brand);

            // ErrorProvider
            errorProvider1.ContainerControl = this;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Buttons
            btnSave.Location = new Point(140, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            btnCancel.Location = new Point(260, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 360);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbBrand);
            Controls.Add(lblBrand);
            Controls.Add(txtVIN);
            Controls.Add(lblVIN);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Controls.Add(txtMileage);
            Controls.Add(lblMileage);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование автомобиля";

            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblModel;
        private Label lblYear;
        private Label lblPrice;
        private Label lblMileage;
        private Label lblColor;
        private Label lblVIN;
        private Label lblBrand;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private TextBox txtMileage;
        private TextBox txtColor;
        private TextBox txtVIN;
        private ComboBox cmbBrand;
        private Button btnSave;
        private Button btnCancel;
        private BindingSource brandBindingSource;
        private ErrorProvider errorProvider1;
    }
}