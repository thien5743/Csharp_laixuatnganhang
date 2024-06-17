namespace Csharp_laixuatnganhang
{
    partial class Form1
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
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.lbltien = new System.Windows.Forms.Label();
            this.lxbketqua = new System.Windows.Forms.ListBox();
            this.lbllaixuat = new System.Windows.Forms.Label();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.lblsonam = new System.Windows.Forms.Label();
            this.txtsonam = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsotien
            // 
            this.txtsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Location = new System.Drawing.Point(390, 46);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(132, 38);
            this.txtsotien.TabIndex = 0;
            this.txtsotien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbltien
            // 
            this.lbltien.AutoSize = true;
            this.lbltien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltien.Location = new System.Drawing.Point(236, 53);
            this.lbltien.Name = "lbltien";
            this.lbltien.Size = new System.Drawing.Size(94, 31);
            this.lbltien.TabIndex = 1;
            this.lbltien.Text = "số tiền";
            this.lbltien.Click += new System.EventHandler(this.label1_Click);
            // 
            // lxbketqua
            // 
            this.lxbketqua.FormattingEnabled = true;
            this.lxbketqua.Location = new System.Drawing.Point(177, 201);
            this.lxbketqua.Name = "lxbketqua";
            this.lxbketqua.Size = new System.Drawing.Size(522, 186);
            this.lxbketqua.TabIndex = 2;
            // 
            // lbllaixuat
            // 
            this.lbllaixuat.AutoSize = true;
            this.lbllaixuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaixuat.Location = new System.Drawing.Point(236, 94);
            this.lbllaixuat.Name = "lbllaixuat";
            this.lbllaixuat.Size = new System.Drawing.Size(100, 31);
            this.lbllaixuat.TabIndex = 4;
            this.lbllaixuat.Text = "lãi suất";
            this.lbllaixuat.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlaisuat.Location = new System.Drawing.Point(390, 94);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(132, 38);
            this.txtlaisuat.TabIndex = 3;
            this.txtlaisuat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblsonam
            // 
            this.lblsonam.AutoSize = true;
            this.lblsonam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsonam.Location = new System.Drawing.Point(236, 140);
            this.lblsonam.Name = "lblsonam";
            this.lblsonam.Size = new System.Drawing.Size(102, 31);
            this.lblsonam.TabIndex = 6;
            this.lblsonam.Text = "số năm";
            this.lblsonam.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsonam
            // 
            this.txtsonam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsonam.Location = new System.Drawing.Point(390, 140);
            this.txtsonam.Name = "txtsonam";
            this.txtsonam.Size = new System.Drawing.Size(132, 38);
            this.txtsonam.TabIndex = 5;
            this.txtsonam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(390, 412);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(106, 45);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblsonam);
            this.Controls.Add(this.txtsonam);
            this.Controls.Add(this.lbllaixuat);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.lxbketqua);
            this.Controls.Add(this.lbltien);
            this.Controls.Add(this.txtsotien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.Label lbltien;
        private System.Windows.Forms.ListBox lxbketqua;
        private System.Windows.Forms.Label lbllaixuat;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.Label lblsonam;
        private System.Windows.Forms.TextBox txtsonam;
        private System.Windows.Forms.Button btntinh;
    }
}

