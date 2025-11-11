namespace CharChakka
{
    partial class customer_cars
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_cars));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label2 = new Label();
            label1 = new Label();
            bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            CustomerCarDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerCarDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 125);
            panel1.TabIndex = 121;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 3);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(166, 100);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 19;
            guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(392, 84);
            label2.Name = "label2";
            label2.Size = new Size(173, 41);
            label2.TabIndex = 11;
            label2.Text = "Your Cars List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(212, -10);
            label1.Name = "label1";
            label1.Size = new Size(581, 103);
            label1.TabIndex = 10;
            label1.Text = "CharChakka";
            // 
            // bunifuThinButton23
            // 
            bunifuThinButton23.ActiveBorderThickness = 1;
            bunifuThinButton23.ActiveCornerRadius = 20;
            bunifuThinButton23.ActiveFillColor = Color.White;
            bunifuThinButton23.ActiveForecolor = Color.Black;
            bunifuThinButton23.ActiveLineColor = Color.Black;
            bunifuThinButton23.BackColor = Color.LightCoral;
            bunifuThinButton23.BackgroundImage = (Image)resources.GetObject("bunifuThinButton23.BackgroundImage");
            bunifuThinButton23.ButtonText = "BACK";
            bunifuThinButton23.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton23.ForeColor = Color.White;
            bunifuThinButton23.IdleBorderThickness = 1;
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleFillColor = Color.Black;
            bunifuThinButton23.IdleForecolor = Color.White;
            bunifuThinButton23.IdleLineColor = Color.White;
            bunifuThinButton23.Location = new Point(447, 600);
            bunifuThinButton23.Margin = new Padding(5);
            bunifuThinButton23.Name = "bunifuThinButton23";
            bunifuThinButton23.Size = new Size(82, 36);
            bunifuThinButton23.TabIndex = 132;
            bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton23.Click += bunifuThinButton23_Click;
            // 
            // CustomerCarDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            CustomerCarDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            CustomerCarDGV.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            CustomerCarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            CustomerCarDGV.ColumnHeadersHeight = 30;
            CustomerCarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            CustomerCarDGV.DefaultCellStyle = dataGridViewCellStyle6;
            CustomerCarDGV.GridColor = Color.FromArgb(231, 229, 255);
            CustomerCarDGV.Location = new Point(155, 131);
            CustomerCarDGV.Name = "CustomerCarDGV";
            CustomerCarDGV.RowHeadersVisible = false;
            CustomerCarDGV.RowHeadersWidth = 51;
            CustomerCarDGV.RowTemplate.Height = 28;
            CustomerCarDGV.Size = new Size(689, 444);
            CustomerCarDGV.TabIndex = 128;
            CustomerCarDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomerCarDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomerCarDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomerCarDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomerCarDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomerCarDGV.ThemeStyle.BackColor = Color.IndianRed;
            CustomerCarDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomerCarDGV.ThemeStyle.HeaderStyle.BackColor = Color.Brown;
            CustomerCarDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomerCarDGV.ThemeStyle.HeaderStyle.Font = new Font("Bahnschrift SemiLight Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerCarDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomerCarDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerCarDGV.ThemeStyle.HeaderStyle.Height = 30;
            CustomerCarDGV.ThemeStyle.ReadOnly = false;
            CustomerCarDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomerCarDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerCarDGV.ThemeStyle.RowsStyle.Font = new Font("Bahnschrift Light SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerCarDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomerCarDGV.ThemeStyle.RowsStyle.Height = 28;
            CustomerCarDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomerCarDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // customer_cars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1000, 650);
            Controls.Add(panel1);
            Controls.Add(bunifuThinButton23);
            Controls.Add(CustomerCarDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customer_cars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customer_cars";
            Load += customer_cars_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerCarDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Complain;
        private Label label4;
        private TextBox Cu_id;
        private TextBox Comp_id;
        private Label label7;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label2;
        private Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerCarDGV;
        private Label label6;
    }
}