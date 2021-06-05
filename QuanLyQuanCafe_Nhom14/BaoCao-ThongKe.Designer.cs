
namespace QuanLyQuanCafe_Nhom14
{
    partial class BaoCao_ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeTu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimeDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbbThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKe)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Thức Thống Kê:";
            // 
            // DateTimeTu
            // 
            this.DateTimeTu.BorderRadius = 12;
            this.DateTimeTu.CheckedState.Parent = this.DateTimeTu;
            this.DateTimeTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimeTu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeTu.HoverState.Parent = this.DateTimeTu;
            this.DateTimeTu.Location = new System.Drawing.Point(135, 26);
            this.DateTimeTu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeTu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeTu.Name = "DateTimeTu";
            this.DateTimeTu.ShadowDecoration.Parent = this.DateTimeTu;
            this.DateTimeTu.Size = new System.Drawing.Size(200, 36);
            this.DateTimeTu.TabIndex = 3;
            this.DateTimeTu.Value = new System.DateTime(2021, 5, 23, 10, 2, 23, 606);
            // 
            // DateTimeDen
            // 
            this.DateTimeDen.BorderRadius = 12;
            this.DateTimeDen.CheckedState.Parent = this.DateTimeDen;
            this.DateTimeDen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateTimeDen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeDen.HoverState.Parent = this.DateTimeDen;
            this.DateTimeDen.Location = new System.Drawing.Point(415, 26);
            this.DateTimeDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeDen.Name = "DateTimeDen";
            this.DateTimeDen.ShadowDecoration.Parent = this.DateTimeDen;
            this.DateTimeDen.Size = new System.Drawing.Size(200, 36);
            this.DateTimeDen.TabIndex = 4;
            this.DateTimeDen.Value = new System.DateTime(2021, 5, 23, 10, 2, 23, 606);
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.BackColor = System.Drawing.Color.Transparent;
            this.cbbThongKe.BorderRadius = 12;
            this.cbbThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.cbbThongKe.FocusedState.Parent = this.cbbThongKe;
            this.cbbThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.HoverState.Parent = this.cbbThongKe;
            this.cbbThongKe.ItemHeight = 30;
            this.cbbThongKe.ItemsAppearance.Parent = this.cbbThongKe;
            this.cbbThongKe.Location = new System.Drawing.Point(861, 26);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.ShadowDecoration.Parent = this.cbbThongKe;
            this.cbbThongKe.Size = new System.Drawing.Size(200, 36);
            this.cbbThongKe.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 12;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Location = new System.Drawing.Point(1105, 26);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(180, 36);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Controls.Add(this.dtgThongKe);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 109);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(670, 649);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Dữ Liệu Thống Kê";
            // 
            // dtgThongKe
            // 
            this.dtgThongKe.AllowUserToAddRows = false;
            this.dtgThongKe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dtgThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dtgThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgThongKe.ColumnHeadersHeight = 35;
            this.dtgThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgThongKe.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgThongKe.EnableHeadersVisualStyles = false;
            this.dtgThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgThongKe.Location = new System.Drawing.Point(3, 40);
            this.dtgThongKe.Name = "dtgThongKe";
            this.dtgThongKe.ReadOnly = true;
            this.dtgThongKe.RowHeadersVisible = false;
            this.dtgThongKe.RowTemplate.Height = 35;
            this.dtgThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgThongKe.Size = new System.Drawing.Size(664, 606);
            this.dtgThongKe.TabIndex = 0;
            this.dtgThongKe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgThongKe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgThongKe.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgThongKe.ThemeStyle.ReadOnly = true;
            this.dtgThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgThongKe.ThemeStyle.RowsStyle.Height = 35;
            this.dtgThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Controls.Add(this.chart1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(679, 109);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(738, 649);
            this.guna2GroupBox2.TabIndex = 9;
            this.guna2GroupBox2.Text = "Biểu Đồ Thống Kê";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(48, 74);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(687, 525);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.DateTimeDen);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnThongKe);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.cbbThongKe);
            this.guna2Panel1.Controls.Add(this.DateTimeTu);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1414, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "BaoCao_ThongKe";
            this.Size = new System.Drawing.Size(1420, 761);
            this.Load += new System.EventHandler(this.BaoCao_ThongKe_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKe)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeTu;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeDen;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThongKe;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgThongKe;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
