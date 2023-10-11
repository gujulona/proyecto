
namespace proyecto1
{
    partial class FormaArea
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoBase = new System.Windows.Forms.TextBox();
            this.textoAltura = new System.Windows.Forms.TextBox();
            this.butonCalcular = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área del Triangulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // textoBase
            // 
            this.textoBase.Location = new System.Drawing.Point(351, 167);
            this.textoBase.Name = "textoBase";
            this.textoBase.Size = new System.Drawing.Size(100, 20);
            this.textoBase.TabIndex = 3;
            this.textoBase.TextChanged += new System.EventHandler(this.textoBase_TextChanged);
            // 
            // textoAltura
            // 
            this.textoAltura.Location = new System.Drawing.Point(351, 251);
            this.textoAltura.Name = "textoAltura";
            this.textoAltura.Size = new System.Drawing.Size(100, 20);
            this.textoAltura.TabIndex = 4;
            this.textoAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // butonCalcular
            // 
            this.butonCalcular.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonCalcular.Location = new System.Drawing.Point(605, 392);
            this.butonCalcular.Name = "butonCalcular";
            this.butonCalcular.Size = new System.Drawing.Size(75, 42);
            this.butonCalcular.TabIndex = 7;
            this.butonCalcular.Text = "Calcular";
            this.butonCalcular.UseVisualStyleBackColor = true;
            this.butonCalcular.Click += new System.EventHandler(this.butonCalcular_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelArea.Location = new System.Drawing.Point(346, 359);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 26);
            this.labelArea.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(213, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area: ";
            // 
            // FormaArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.butonCalcular);
            this.Controls.Add(this.textoAltura);
            this.Controls.Add(this.textoBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaArea";
            this.Load += new System.EventHandler(this.FormaArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoBase;
        private System.Windows.Forms.TextBox textoAltura;
        private System.Windows.Forms.Button butonCalcular;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label label4;
    }
}