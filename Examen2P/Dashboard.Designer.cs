namespace Examen2P
{
    partial class Dashboard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dtgProductos = new DataGridView();
            lblSeller = new Label();
            btnReporte = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dtgProductos, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSeller, 0, 0);
            tableLayoutPanel1.Controls.Add(btnReporte, 3, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4444447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.55556F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgProductos
            // 
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtgProductos, 4);
            dtgProductos.Dock = DockStyle.Fill;
            dtgProductos.Location = new Point(3, 50);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.RowHeadersWidth = 51;
            dtgProductos.Size = new Size(794, 397);
            dtgProductos.TabIndex = 0;
            dtgProductos.CellDoubleClick += dtgProductos_CellDoubleClick;
            // 
            // lblSeller
            // 
            lblSeller.Anchor = AnchorStyles.None;
            lblSeller.AutoSize = true;
            lblSeller.Location = new Point(63, 13);
            lblSeller.Name = "lblSeller";
            lblSeller.Size = new Size(73, 20);
            lblSeller.TabIndex = 4;
            lblSeller.Text = "Vendedor";
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.None;
            btnReporte.Location = new Point(618, 3);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(163, 41);
            btnReporte.TabIndex = 1;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(418, 3);
            button2.Name = "button2";
            button2.Size = new Size(163, 41);
            button2.TabIndex = 2;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Dashboard";
            Text = "Dashboard";
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgProductos;
        private Button btnReporte;
        private Button button2;
        private Label lblSeller;
    }
}