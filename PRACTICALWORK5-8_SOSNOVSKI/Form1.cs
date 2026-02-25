using Microsoft.EntityFrameworkCore;
using PRACTICALWORK5_8_SOSNOVSKI.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRACTICALWORK5_8_SOSNOVSKI
{
    public partial class Form1 : Form
    {
        private Ispr2522SosnovskiySePz58Context _context;
        private FlowLayoutPanel flowLayoutPanelCards;

        public Form1()
        {
            InitializeComponent();
            _context = new Ispr2522SosnovskiySePz58Context();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeCardPanel();
            LoadCarCards();
        }

        private void InitializeCardPanel()
        {
            flowLayoutPanelCards = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Dock = DockStyle.Fill,
                Padding = new Padding(15),
                BackColor = System.Drawing.Color.FromArgb(245, 245, 245),
                Name = "flowLayoutPanelCards"
            };

            this.Controls.Add(flowLayoutPanelCards);
            flowLayoutPanelCards.BringToFront();
        }

        private void LoadCarCards()
        {
            flowLayoutPanelCards.Controls.Clear();

            try
            {
                var cars = _context.Cars
                    .Include(c => c.Brand)
                    .AsNoTracking()
                    .ToList();

                lblCount.Text = $"Автомобилей: {cars.Count}";

                if (cars.Count == 0)
                {
                    var lblEmpty = new Label
                    {
                        Text = "Нет автомобилей. Добавьте первый!",
                        AutoSize = true,
                        Font = new System.Drawing.Font("Segoe UI", 14F),
                        ForeColor = System.Drawing.Color.Gray
                    };
                    flowLayoutPanelCards.Controls.Add(lblEmpty);
                    return;
                }

                foreach (var car in cars)
                {
                    var card = new CarCard(car, _context, this);
                    flowLayoutPanelCards.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ ДОБАВЛЕНИЕ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var editForm = new EditForm(_context))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCarCards();
                    MessageBox.Show("Автомобиль добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ✅ ОБНОВЛЕНИЕ СПИСКА (вызывается из CarCard)
        public void RefreshCards()
        {
            LoadCarCards();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}