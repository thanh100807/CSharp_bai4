namespace CSharp_bai4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqd = new System.Windows.Forms.TextBox();
            this.btvndtousd = new System.Windows.Forms.Button();
            this.btvndtoeur = new System.Windows.Forms.Button();
            this.btusdtovnd = new System.Windows.Forms.Button();
            this.bteurtovnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(261, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền qui đổi ";
            // 
            // txtqd
            // 
            this.txtqd.Location = new System.Drawing.Point(208, 128);
            this.txtqd.Name = "txtqd";
            this.txtqd.Size = new System.Drawing.Size(307, 20);
            this.txtqd.TabIndex = 2;
            this.txtqd.TextChanged += new System.EventHandler(this.txttqd_TextChanged);
            // 
            // btvndtousd
            // 
            this.btvndtousd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvndtousd.Location = new System.Drawing.Point(109, 187);
            this.btvndtousd.Name = "btvndtousd";
            this.btvndtousd.Size = new System.Drawing.Size(109, 33);
            this.btvndtousd.TabIndex = 3;
            this.btvndtousd.Text = "VNDtoUSD";
            this.btvndtousd.UseVisualStyleBackColor = true;
            this.btvndtousd.Click += new System.EventHandler(this.btvndtousd_Click);
            // 
            // btvndtoeur
            // 
            this.btvndtoeur.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvndtoeur.Location = new System.Drawing.Point(234, 187);
            this.btvndtoeur.Name = "btvndtoeur";
            this.btvndtoeur.Size = new System.Drawing.Size(109, 33);
            this.btvndtoeur.TabIndex = 3;
            this.btvndtoeur.Text = "VNDtoEUR";
            this.btvndtoeur.UseVisualStyleBackColor = true;
            // 
            // btusdtovnd
            // 
            this.btusdtovnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusdtovnd.Location = new System.Drawing.Point(360, 187);
            this.btusdtovnd.Name = "btusdtovnd";
            this.btusdtovnd.Size = new System.Drawing.Size(109, 33);
            this.btusdtovnd.TabIndex = 3;
            this.btusdtovnd.Text = "USDtoVND";
            this.btusdtovnd.UseVisualStyleBackColor = true;
            // 
            // bteurtovnd
            // 
            this.bteurtovnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteurtovnd.Location = new System.Drawing.Point(485, 187);
            this.bteurtovnd.Name = "bteurtovnd";
            this.bteurtovnd.Size = new System.Drawing.Size(109, 33);
            this.bteurtovnd.TabIndex = 3;
            this.bteurtovnd.Text = "EURtoVND";
            this.bteurtovnd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(121, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(208, 271);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(307, 30);
            this.txtkq.TabIndex = 5;
            this.txtkq.TextChanged += new System.EventHandler(this.txtkq_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bteurtovnd);
            this.Controls.Add(this.btusdtovnd);
            this.Controls.Add(this.btvndtoeur);
            this.Controls.Add(this.btvndtousd);
            this.Controls.Add(this.txtqd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqd;
        private System.Windows.Forms.Button btvndtousd;
        private System.Windows.Forms.Button btvndtoeur;
        private System.Windows.Forms.Button btusdtovnd;
        private System.Windows.Forms.Button bteurtovnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

