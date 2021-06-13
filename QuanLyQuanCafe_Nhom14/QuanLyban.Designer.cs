
namespace QuanLyQuanCafe_Nhom14
{
    partial class QuanLyban
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyban));
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTKTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSua = new Guna.UI2.WinForms.Guna2Button();
            this.cbbpositionTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Controls.Add(this.dtgTable);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(3, 152);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(1414, 616);
            this.guna2GroupBox3.TabIndex = 34;
            this.guna2GroupBox3.Text = "Danh Sách Bàn";
            // 
            // dtgTable
            // 
            this.dtgTable.AllowUserToAddRows = false;
            this.dtgTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTable.BackgroundColor = System.Drawing.Color.White;
            this.dtgTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTable.ColumnHeadersHeight = 35;
            this.dtgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTable,
            this.nameTable,
            this.statusTable,
            this.positionTable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTable.EnableHeadersVisualStyles = false;
            this.dtgTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTable.Location = new System.Drawing.Point(3, 40);
            this.dtgTable.Name = "dtgTable";
            this.dtgTable.ReadOnly = true;
            this.dtgTable.RowHeadersVisible = false;
            this.dtgTable.RowTemplate.Height = 35;
            this.dtgTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTable.Size = new System.Drawing.Size(1408, 573);
            this.dtgTable.TabIndex = 0;
            this.dtgTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgTable.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgTable.ThemeStyle.ReadOnly = true;
            this.dtgTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgTable.ThemeStyle.RowsStyle.Height = 35;
            this.dtgTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTable_CellClick);
            // 
            // idTable
            // 
            this.idTable.DataPropertyName = "id";
            this.idTable.HeaderText = "ID";
            this.idTable.Name = "idTable";
            this.idTable.ReadOnly = true;
            // 
            // nameTable
            // 
            this.nameTable.DataPropertyName = "name";
            this.nameTable.HeaderText = "Tên Bàn";
            this.nameTable.Name = "nameTable";
            this.nameTable.ReadOnly = true;
            // 
            // statusTable
            // 
            this.statusTable.DataPropertyName = "status";
            this.statusTable.HeaderText = "Trạng Thái";
            this.statusTable.Name = "statusTable";
            this.statusTable.ReadOnly = true;
            // 
            // positionTable
            // 
            this.positionTable.DataPropertyName = "position";
            this.positionTable.HeaderText = "Vị Trí";
            this.positionTable.Name = "positionTable";
            this.positionTable.ReadOnly = true;
            // 
            // cbbTKTable
            // 
            this.cbbTKTable.BackColor = System.Drawing.Color.Transparent;
            this.cbbTKTable.BorderRadius = 12;
            this.cbbTKTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTKTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTKTable.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTKTable.FocusedState.Parent = this.cbbTKTable;
            this.cbbTKTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTKTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTKTable.FormattingEnabled = true;
            this.cbbTKTable.HoverState.Parent = this.cbbTKTable;
            this.cbbTKTable.ItemHeight = 30;
            this.cbbTKTable.ItemsAppearance.Parent = this.cbbTKTable;
            this.cbbTKTable.Location = new System.Drawing.Point(1037, 23);
            this.cbbTKTable.Name = "cbbTKTable";
            this.cbbTKTable.ShadowDecoration.Parent = this.cbbTKTable;
            this.cbbTKTable.Size = new System.Drawing.Size(245, 36);
            this.cbbTKTable.TabIndex = 43;
            this.cbbTKTable.SelectedIndexChanged += new System.EventHandler(this.cbbTKTable_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.CheckedState.Parent = this.btnExportExcel;
            this.btnExportExcel.HoverState.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportExcel.HoverState.Parent = this.btnExportExcel;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportExcel.Location = new System.Drawing.Point(467, 96);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.PressedState.Parent = this.btnExportExcel;
            this.btnExportExcel.Size = new System.Drawing.Size(75, 36);
            this.btnExportExcel.TabIndex = 41;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(319, 96);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(99, 36);
            this.btnLamMoi.TabIndex = 40;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.BorderRadius = 12;
            this.btnThemSua.CheckedState.Parent = this.btnThemSua;
            this.btnThemSua.CustomImages.Parent = this.btnThemSua;
            this.btnThemSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.ForeColor = System.Drawing.Color.White;
            this.btnThemSua.HoverState.Parent = this.btnThemSua;
            this.btnThemSua.Location = new System.Drawing.Point(172, 96);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.ShadowDecoration.Parent = this.btnThemSua;
            this.btnThemSua.Size = new System.Drawing.Size(99, 36);
            this.btnThemSua.TabIndex = 39;
            this.btnThemSua.Text = "Thêm";
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // cbbpositionTable
            // 
            this.cbbpositionTable.BackColor = System.Drawing.Color.Transparent;
            this.cbbpositionTable.BorderRadius = 12;
            this.cbbpositionTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbpositionTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbpositionTable.FocusedColor = System.Drawing.Color.Empty;
            this.cbbpositionTable.FocusedState.Parent = this.cbbpositionTable;
            this.cbbpositionTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbpositionTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbpositionTable.FormattingEnabled = true;
            this.cbbpositionTable.HoverState.Parent = this.cbbpositionTable;
            this.cbbpositionTable.ItemHeight = 30;
            this.cbbpositionTable.ItemsAppearance.Parent = this.cbbpositionTable;
            this.cbbpositionTable.Location = new System.Drawing.Point(618, 23);
            this.cbbpositionTable.Name = "cbbpositionTable";
            this.cbbpositionTable.ShadowDecoration.Parent = this.cbbpositionTable;
            this.cbbpositionTable.Size = new System.Drawing.Size(245, 36);
            this.cbbpositionTable.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Vị Trí:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên Bàn:";
            // 
            // txtTenTable
            // 
            this.txtTenTable.BorderRadius = 12;
            this.txtTenTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTable.DefaultText = "";
            this.txtTenTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTable.DisabledState.Parent = this.txtTenTable;
            this.txtTenTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTable.FocusedState.Parent = this.txtTenTable;
            this.txtTenTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTable.HoverState.Parent = this.txtTenTable;
            this.txtTenTable.Location = new System.Drawing.Point(172, 23);
            this.txtTenTable.Name = "txtTenTable";
            this.txtTenTable.PasswordChar = '\0';
            this.txtTenTable.PlaceholderText = "";
            this.txtTenTable.SelectedText = "";
            this.txtTenTable.ShadowDecoration.Parent = this.txtTenTable;
            this.txtTenTable.Size = new System.Drawing.Size(246, 36);
            this.txtTenTable.TabIndex = 36;
            // 
            // QuanLyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.cbbTKTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.cbbpositionTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTable);
            this.Name = "QuanLyban";
            this.Size = new System.Drawing.Size(1420, 761);
            this.Load += new System.EventHandler(this.QuanLyban_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTKTable;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThemSua;
        private Guna.UI2.WinForms.Guna2ComboBox cbbpositionTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTable;
        private Guna.UI2.WinForms.Guna2DataGridView dtgTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionTable;
    }
}
