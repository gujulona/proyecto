
namespace proyecto1
{
    partial class FormaEcuacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.textoValorB = new System.Windows.Forms.TextBox();
            this.textoValorC = new System.Windows.Forms.TextBox();
            this.textoValorA = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.labelUno = new System.Windows.Forms.Label();
            this.labelDos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ecuacion Cuadratica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor C";
            // 
            // textoValorB
            // 
            this.textoValorB.Location = new System.Drawing.Point(304, 259);
            this.textoValorB.Name = "textoValorB";
            this.textoValorB.Size = new System.Drawing.Size(129, 20);
            this.textoValorB.TabIndex = 8;
            // 
            // textoValorC
            // 
            this.textoValorC.Location = new System.Drawing.Point(304, 329);
            this.textoValorC.Name = "textoValorC";
            this.textoValorC.Size = new System.Drawing.Size(129, 20);
            this.textoValorC.TabIndex = 9;
            this.textoValorC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textoValorA
            // 
            this.textoValorA.Location = new System.Drawing.Point(304, 180);
            this.textoValorA.Name = "textoValorA";
            this.textoValorA.Size = new System.Drawing.Size(129, 20);
            this.textoValorA.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(577, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 11;
            this.button5.Text = "Calcular";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelUno
            // 
            this.labelUno.AutoSize = true;
            this.labelUno.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUno.Location = new System.Drawing.Point(201, 430);
            this.labelUno.Name = "labelUno";
            this.labelUno.Size = new System.Drawing.Size(0, 22);
            this.labelUno.TabIndex = 12;
            // 
            // labelDos
            // 
            this.labelDos.AutoSize = true;
            this.labelDos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDos.Location = new System.Drawing.Point(356, 430);
            this.labelDos.Name = "labelDos";
            this.labelDos.Size = new System.Drawing.Size(0, 22);
            this.labelDos.TabIndex = 13;
            this.labelDos.Click += new System.EventHandler(this.labelDos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(200, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "X1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(355, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "X2";
            // 
            // FormaEcuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDos);
            this.Controls.Add(this.labelUno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textoValorA);
            this.Controls.Add(this.textoValorC);
            this.Controls.Add(this.textoValorB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaEcuacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaEcuacion";
            this.Load += new System.EventHandler(this.FormaEcuacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoValorB;
        private System.Windows.Forms.TextBox textoValorC;
        private System.Windows.Forms.TextBox textoValorA;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelUno;
        private System.Windows.Forms.Label labelDos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}