using System;
using System.Windows.Forms;
using PRACTICALWORK5_8_SOSNOVSKI.Models;

namespace PRACTICALWORK5_8_SOSNOVSKI
{
    public partial class CarCard : UserControl
    {
        public Car CurrentCar { get; set; }
        private Ispr2522SosnovskiySePz58Context _context;
        private Form1 _parentForm;

        public CarCard()
        {
            InitializeComponent();
        }

        public CarCard(Car car, Ispr2522SosnovskiySePz58Context context, Form1 parentForm) : this()
        {
            CurrentCar = car;
            _context = context;
            _parentForm = parentForm;
            LoadCarData();

            btnEditCard.Click += BtnEditCard_Click;
            btnDeleteCard.Click += BtnDeleteCard_Click;
        }

        private void LoadCarData()
        {
            if (CurrentCar == null)
                return;

            lblBrand.Text = CurrentCar.Brand?.Name ?? "Не указан";
            lblModel.Text = CurrentCar.Model;
            lblYear.Text = $"Год: {CurrentCar.Year}";
            lblPrice.Text = $"Цена: {CurrentCar.Price:N0} ₽";
            lblMileage.Text = $"Пробег: {CurrentCar.Mileage:N0} км";
            lblColor.Text = $"Цвет: {CurrentCar.Color}";

            if (!string.IsNullOrEmpty(CurrentCar.Vin))
                lblVIN.Text = $"VIN: {CurrentCar.Vin}";
            else
                lblVIN.Text = "VIN: не указан";
        }

        private void BtnEditCard_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditForm(_context, CurrentCar))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    _parentForm.RefreshCards();
                }
            }
        }

        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Удалить {CurrentCar.Brand?.Name} {CurrentCar.Model}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.Cars.Remove(CurrentCar);
                    _context.SaveChanges();
                    _parentForm.RefreshCards();
                    MessageBox.Show("Удалено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }
    }
}