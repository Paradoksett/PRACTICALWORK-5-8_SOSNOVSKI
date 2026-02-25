namespace PRACTICALWORK5_8_SOSNOVSKI
{
    partial class Form1
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

            panelHeader = new Panel();
            lblTitle = new Label();
            lblCount = new Label();
            btnAdd = new Button();
            btnRefresh = new Button();

            panelHeader.SuspendLayout();
            SuspendLayout();

            // ============================================
            // panelHeader - Верхняя панель
            // ============================================
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 70;
            panelHeader.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            panelHeader.Padding = new Padding(20, 15, 20, 15);

            // ============================================
            // lblTitle - Заголовок
            // ============================================
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(250, 30);
            lblTitle.Text = "🚗 Автосалон";

            // ============================================
            // lblCount - Счётчик автомобилей
            // ============================================
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblCount.ForeColor = System.Drawing.Color.LightGray;
            lblCount.Location = new System.Drawing.Point(20, 48);
            lblCount.Name = "lblCount";
            lblCount.Size = new System.Drawing.Size(150, 21);
            lblCount.Text = "Автомобилей: 0";

            // ============================================
            // btnAdd - Кнопка "Добавить"
            // ============================================
            btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(600, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(150, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+ Добавить авто";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // ============================================
            // btnRefresh - Кнопка "Обновить"
            // ============================================
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(760, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(120, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "🔄 Обновить";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += (s, e) => LoadCarCards();

            // Добавляем контролы на панель
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblCount);
            panelHeader.Controls.Add(btnAdd);
            panelHeader.Controls.Add(btnRefresh);

            // ============================================
            // Form1 - Настройки формы
            // ============================================
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 600);
            Controls.Add(panelHeader);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автосалон - Управление автомобилями";
            MinimumSize = new System.Drawing.Size(800, 500);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblCount;
        private Button btnAdd;
        private Button btnRefresh;
    }
}