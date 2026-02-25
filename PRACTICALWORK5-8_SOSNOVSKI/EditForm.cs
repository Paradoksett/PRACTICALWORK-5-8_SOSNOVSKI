using Microsoft.EntityFrameworkCore;
using PRACTICALWORK5_8_SOSNOVSKI.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRACTICALWORK5_8_SOSNOVSKI
{
    public partial class EditForm : Form
    {
        private readonly Ispr2522SosnovskiySePz58Context _context;
        public Car CurrentCar { get; set; }
        public bool IsNewRecord { get; set; }

        public EditForm(Ispr2522SosnovskiySePz58Context context, Car car = null)
        {
            InitializeComponent();
            _context = context;
            CurrentCar = car;
            IsNewRecord = car == null;

            // Загружаем бренды
            var brands = _context.Brands.AsNoTracking().ToList();
            brandBindingSource.DataSource = brands;

            cmbBrand.DataSource = brandBindingSource;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "Id";

            if (!IsNewRecord)
            {
                txtModel.Text = CurrentCar.Model;
                txtYear.Text = CurrentCar.Year.ToString();
                txtPrice.Text = CurrentCar.Price.ToString();
                txtMileage.Text = CurrentCar.Mileage.ToString();
                txtColor.Text = CurrentCar.Color;
                if (!string.IsNullOrEmpty(CurrentCar.Vin))
                    txtVIN.Text = CurrentCar.Vin;
                cmbBrand.SelectedValue = CurrentCar.BrandId;
            }

            this.Text = IsNewRecord ? "Добавление автомобиля" : "Редактирование автомобиля";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидация модели
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                errorProvider1.SetError(txtModel, "Модель обязательна!");
                return;
            }
            errorProvider1.SetError(txtModel, "");

            // Валидация года
            if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
            {
                errorProvider1.SetError(txtYear, $"Год от 1900 до {DateTime.Now.Year + 1}!");
                return;
            }
            errorProvider1.SetError(txtYear, "");

            // Валидация цены
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                errorProvider1.SetError(txtPrice, "Цена ≥ 0!");
                return;
            }
            errorProvider1.SetError(txtPrice, "");

            // Валидация пробега
            if (!int.TryParse(txtMileage.Text, out int mileage) || mileage < 0)
            {
                errorProvider1.SetError(txtMileage, "Пробег ≥ 0!");
                return;
            }
            errorProvider1.SetError(txtMileage, "");

            // Валидация VIN (если есть такое поле в БД)
            if (!string.IsNullOrWhiteSpace(txtVIN.Text) && txtVIN.Text.Length != 17)
            {
                errorProvider1.SetError(txtVIN, "VIN = 17 символов!");
                return;
            }
            errorProvider1.SetError(txtVIN, "");

            // Валидация бренда
            if (cmbBrand.SelectedValue == null)
            {
                errorProvider1.SetError(cmbBrand, "Выберите бренд!");
                return;
            }
            errorProvider1.SetError(cmbBrand, "");

            try
            {
                if (IsNewRecord)
                {
                    CurrentCar = new Car
                    {
                        Model = txtModel.Text,
                        Year = year,
                        Price = price,
                        Mileage = mileage,
                        Color = txtColor.Text,
                        Vin = txtVIN.Text,
                        BrandId = (int)cmbBrand.SelectedValue
                    };
                    _context.Cars.Add(CurrentCar);
                }
                else
                {
                    CurrentCar.Model = txtModel.Text;
                    CurrentCar.Year = year;
                    CurrentCar.Price = price;
                    CurrentCar.Mileage = mileage;
                    CurrentCar.Color = txtColor.Text;
                    CurrentCar.Vin = txtVIN.Text;
                    CurrentCar.BrandId = (int)cmbBrand.SelectedValue;
                    _context.Cars.Update(CurrentCar);
                }

                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}