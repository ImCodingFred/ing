namespace ing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            iazon = new DataGridViewTextBoxColumn();
            kerulet = new DataGridViewTextBoxColumn();
            pazon = new DataGridViewTextBoxColumn();
            ar = new DataGridViewTextBoxColumn();
            uazon = new DataGridViewTextBoxColumn();
            nm = new DataGridViewTextBoxColumn();
            tipus = new DataGridViewTextBoxColumn();
            eladdatum = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tb_iazon = new TextBox();
            label2 = new Label();
            tb_ar = new TextBox();
            label3 = new Label();
            tb_tipus = new TextBox();
            label4 = new Label();
            tb_kerulet = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_meret = new TextBox();
            btn_ment = new Button();
            cb_partner = new ComboBox();
            cb_ugynok = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { iazon, kerulet, pazon, ar, uazon, nm, tipus, eladdatum });
            DGV.Location = new Point(26, 28);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(843, 150);
            DGV.TabIndex = 0;
            // 
            // iazon
            // 
            iazon.HeaderText = "Ingatlan azonosító";
            iazon.Name = "iazon";
            iazon.ReadOnly = true;
            // 
            // kerulet
            // 
            kerulet.HeaderText = "Kerület";
            kerulet.Name = "kerulet";
            kerulet.ReadOnly = true;
            // 
            // pazon
            // 
            pazon.HeaderText = "Partner Azonosító";
            pazon.Name = "pazon";
            pazon.ReadOnly = true;
            // 
            // ar
            // 
            ar.HeaderText = "Ár";
            ar.Name = "ar";
            ar.ReadOnly = true;
            // 
            // uazon
            // 
            uazon.HeaderText = "Ügynök azonosító";
            uazon.Name = "uazon";
            uazon.ReadOnly = true;
            // 
            // nm
            // 
            nm.HeaderText = "Méret";
            nm.Name = "nm";
            nm.ReadOnly = true;
            // 
            // tipus
            // 
            tipus.HeaderText = "Típus";
            tipus.Name = "tipus";
            tipus.ReadOnly = true;
            // 
            // eladdatum
            // 
            eladdatum.HeaderText = "Eladás Dátuma";
            eladdatum.Name = "eladdatum";
            eladdatum.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 208);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "ingatlan azonosító";
            // 
            // tb_iazon
            // 
            tb_iazon.Location = new Point(136, 205);
            tb_iazon.Name = "tb_iazon";
            tb_iazon.Size = new Size(100, 23);
            tb_iazon.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(668, 208);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "Ár";
            // 
            // tb_ar
            // 
            tb_ar.Location = new Point(712, 205);
            tb_ar.Name = "tb_ar";
            tb_ar.Size = new Size(100, 23);
            tb_ar.TabIndex = 4;
            tb_ar.TextChanged += tb_ar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 241);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Típus";
            // 
            // tb_tipus
            // 
            tb_tipus.Location = new Point(502, 238);
            tb_tipus.Name = "tb_tipus";
            tb_tipus.Size = new Size(100, 23);
            tb_tipus.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 208);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "kerület";
            // 
            // tb_kerulet
            // 
            tb_kerulet.Location = new Point(301, 205);
            tb_kerulet.Name = "tb_kerulet";
            tb_kerulet.Size = new Size(100, 23);
            tb_kerulet.TabIndex = 2;
            tb_kerulet.TextChanged += tb_kerulet_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 238);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 1;
            label5.Text = "Ügynök azonosító";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 208);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 1;
            label7.Text = "Partner azonosító";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 241);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 1;
            label8.Text = "Méret";
            // 
            // tb_meret
            // 
            tb_meret.Location = new Point(322, 238);
            tb_meret.Name = "tb_meret";
            tb_meret.Size = new Size(100, 23);
            tb_meret.TabIndex = 6;
            tb_meret.TextChanged += tb_meret_TextChanged;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(668, 237);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(144, 23);
            btn_ment.TabIndex = 8;
            btn_ment.Text = "Mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // cb_partner
            // 
            cb_partner.FormattingEnabled = true;
            cb_partner.Location = new Point(541, 205);
            cb_partner.Name = "cb_partner";
            cb_partner.Size = new Size(121, 23);
            cb_partner.TabIndex = 9;
            // 
            // cb_ugynok
            // 
            cb_ugynok.FormattingEnabled = true;
            cb_ugynok.Location = new Point(135, 235);
            cb_ugynok.Name = "cb_ugynok";
            cb_ugynok.Size = new Size(121, 23);
            cb_ugynok.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(903, 450);
            Controls.Add(cb_ugynok);
            Controls.Add(cb_partner);
            Controls.Add(btn_ment);
            Controls.Add(tb_tipus);
            Controls.Add(tb_meret);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(tb_ar);
            Controls.Add(tb_kerulet);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(tb_iazon);
            Controls.Add(label1);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            Load += DGV_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn iazon;
        private DataGridViewTextBoxColumn kerulet;
        private DataGridViewTextBoxColumn pazon;
        private DataGridViewTextBoxColumn ar;
        private DataGridViewTextBoxColumn uazon;
        private DataGridViewTextBoxColumn nm;
        private DataGridViewTextBoxColumn tipus;
        private DataGridViewTextBoxColumn eladdatum;
        private Label label1;
        private TextBox tb_iazon;
        private Label label2;
        private TextBox tb_ar;
        private Label label3;
        private TextBox tb_tipus;
        private Label label4;
        private TextBox tb_kerulet;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox tb_meret;
        private Button btn_ment;
        private ComboBox cb_partner;
        private ComboBox cb_ugynok;
    }
}
