namespace _19_Duy_N1_tinhte.vn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtA_19_duy = new System.Windows.Forms.TextBox();
            this.txtB_19_duy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC_19_duy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_19_duy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResult_19_duy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cạnh a";
            // 
            // txtA_19_duy
            // 
            this.txtA_19_duy.Location = new System.Drawing.Point(235, 91);
            this.txtA_19_duy.Name = "txtA_19_duy";
            this.txtA_19_duy.Size = new System.Drawing.Size(122, 26);
            this.txtA_19_duy.TabIndex = 1;
            // 
            // txtB_19_duy
            // 
            this.txtB_19_duy.Location = new System.Drawing.Point(235, 162);
            this.txtB_19_duy.Name = "txtB_19_duy";
            this.txtB_19_duy.Size = new System.Drawing.Size(122, 26);
            this.txtB_19_duy.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cạnh b";
            // 
            // txtC_19_duy
            // 
            this.txtC_19_duy.Location = new System.Drawing.Point(235, 233);
            this.txtC_19_duy.Name = "txtC_19_duy";
            this.txtC_19_duy.Size = new System.Drawing.Size(122, 26);
            this.txtC_19_duy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cạnh c";
            // 
            // btn_19_duy
            // 
            this.btn_19_duy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_19_duy.Location = new System.Drawing.Point(269, 326);
            this.btn_19_duy.Name = "btn_19_duy";
            this.btn_19_duy.Size = new System.Drawing.Size(211, 68);
            this.btn_19_duy.TabIndex = 6;
            this.btn_19_duy.Text = "Tính diện tích";
            this.btn_19_duy.UseVisualStyleBackColor = true;
            this.btn_19_duy.Click += new System.EventHandler(this.btn_19_duy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diện tích tam giác:";
            // 
            // lbResult_19_duy
            // 
            this.lbResult_19_duy.AutoSize = true;
            this.lbResult_19_duy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult_19_duy.Location = new System.Drawing.Point(696, 156);
            this.lbResult_19_duy.Name = "lbResult_19_duy";
            this.lbResult_19_duy.Size = new System.Drawing.Size(0, 32);
            this.lbResult_19_duy.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult_19_duy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_19_duy);
            this.Controls.Add(this.txtC_19_duy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB_19_duy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA_19_duy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA_19_duy;
        private System.Windows.Forms.TextBox txtB_19_duy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC_19_duy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_19_duy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResult_19_duy;
    }
}

