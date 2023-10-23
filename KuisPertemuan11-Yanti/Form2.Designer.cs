namespace KuisPertemuan11_Yanti
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.alm = new System.Windows.Forms.Label();
            this.prd = new System.Windows.Forms.Label();
            this.hobi = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtal = new System.Windows.Forms.TextBox();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.txthb = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nim.Location = new System.Drawing.Point(56, 141);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(60, 29);
            this.nim.TabIndex = 1;
            this.nim.Text = "Nim";
            this.nim.Click += new System.EventHandler(this.nim_Click);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(56, 223);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(81, 29);
            this.nama.TabIndex = 2;
            this.nama.Text = "Nama";
            this.nama.Click += new System.EventHandler(this.nama_Click);
            // 
            // alm
            // 
            this.alm.AutoSize = true;
            this.alm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alm.Location = new System.Drawing.Point(56, 312);
            this.alm.Name = "alm";
            this.alm.Size = new System.Drawing.Size(92, 29);
            this.alm.TabIndex = 3;
            this.alm.Text = "Alamat";
            this.alm.Click += new System.EventHandler(this.alm_Click);
            // 
            // prd
            // 
            this.prd.AutoSize = true;
            this.prd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prd.Location = new System.Drawing.Point(56, 401);
            this.prd.Name = "prd";
            this.prd.Size = new System.Drawing.Size(76, 29);
            this.prd.TabIndex = 4;
            this.prd.Text = "Prodi";
            this.prd.Click += new System.EventHandler(this.prd_Click);
            // 
            // hobi
            // 
            this.hobi.AutoSize = true;
            this.hobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobi.Location = new System.Drawing.Point(56, 477);
            this.hobi.Name = "hobi";
            this.hobi.Size = new System.Drawing.Size(68, 29);
            this.hobi.TabIndex = 5;
            this.hobi.Text = "Hobi";
            this.hobi.Click += new System.EventHandler(this.hobi_Click);
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(239, 141);
            this.txtnim.Multiline = true;
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(260, 39);
            this.txtnim.TabIndex = 6;
            this.txtnim.TextChanged += new System.EventHandler(this.txtnim_TextChanged);
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(239, 223);
            this.txtnm.Multiline = true;
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(260, 39);
            this.txtnm.TabIndex = 7;
            this.txtnm.TextChanged += new System.EventHandler(this.txtnm_TextChanged);
            // 
            // txtal
            // 
            this.txtal.Location = new System.Drawing.Point(239, 316);
            this.txtal.Multiline = true;
            this.txtal.Name = "txtal";
            this.txtal.Size = new System.Drawing.Size(260, 39);
            this.txtal.TabIndex = 8;
            this.txtal.TextChanged += new System.EventHandler(this.txtal_TextChanged);
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(239, 405);
            this.txtpr.Multiline = true;
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(260, 39);
            this.txtpr.TabIndex = 9;
            this.txtpr.TextChanged += new System.EventHandler(this.txtpr_TextChanged);
            // 
            // txthb
            // 
            this.txthb.Location = new System.Drawing.Point(239, 477);
            this.txthb.Multiline = true;
            this.txthb.Name = "txthb";
            this.txthb.Size = new System.Drawing.Size(260, 39);
            this.txthb.TabIndex = 10;
            this.txthb.TextChanged += new System.EventHandler(this.txthb_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(61, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 59);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCl
            // 
            this.btnCl.BackColor = System.Drawing.Color.IndianRed;
            this.btnCl.Location = new System.Drawing.Point(409, 596);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(127, 59);
            this.btnCl.TabIndex = 12;
            this.btnCl.Text = "Cancel";
            this.btnCl.UseVisualStyleBackColor = false;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 667);
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txthb);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.txtal);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.hobi);
            this.Controls.Add(this.prd);
            this.Controls.Add(this.alm);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nim;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label alm;
        private System.Windows.Forms.Label prd;
        private System.Windows.Forms.Label hobi;
        public System.Windows.Forms.TextBox txtnim;
        public System.Windows.Forms.TextBox txtnm;
        public System.Windows.Forms.TextBox txtal;
        public System.Windows.Forms.TextBox txtpr;
        public System.Windows.Forms.TextBox txthb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCl;
    }
}