namespace Arrays
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
            this.btnVetor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVetor2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVetor3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVetor
            // 
            this.btnVetor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetor.Location = new System.Drawing.Point(86, 77);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(202, 39);
            this.btnVetor.TabIndex = 0;
            this.btnVetor.Text = "Testar Array";
            this.btnVetor.UseVisualStyleBackColor = true;
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exemplo Array 1 - Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exemplo Array 2 - Texto";
            // 
            // btnVetor2
            // 
            this.btnVetor2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetor2.Location = new System.Drawing.Point(86, 200);
            this.btnVetor2.Name = "btnVetor2";
            this.btnVetor2.Size = new System.Drawing.Size(202, 39);
            this.btnVetor2.TabIndex = 2;
            this.btnVetor2.Text = "Testar Array";
            this.btnVetor2.UseVisualStyleBackColor = true;
            this.btnVetor2.Click += new System.EventHandler(this.btnVetor2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exemplo Array Multidimensional";
            // 
            // btnVetor3
            // 
            this.btnVetor3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVetor3.Location = new System.Drawing.Point(86, 332);
            this.btnVetor3.Name = "btnVetor3";
            this.btnVetor3.Size = new System.Drawing.Size(202, 39);
            this.btnVetor3.TabIndex = 6;
            this.btnVetor3.Text = "Testar Array";
            this.btnVetor3.UseVisualStyleBackColor = true;
            this.btnVetor3.Click += new System.EventHandler(this.btnVetor3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 394);
            this.Controls.Add(this.btnVetor3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVetor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVetor);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVetor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVetor3;
    }
}

