namespace Migracao
{
    partial class btnIniciar
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
            this.BarGeral = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarIndividual = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BarGeral
            // 
            this.BarGeral.Location = new System.Drawing.Point(11, 25);
            this.BarGeral.Name = "BarGeral";
            this.BarGeral.Size = new System.Drawing.Size(490, 23);
            this.BarGeral.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 148);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Statkus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Progresso Geral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progresso Individual";
            // 
            // BarIndividual
            // 
            this.BarIndividual.Location = new System.Drawing.Point(12, 81);
            this.BarIndividual.Name = "BarIndividual";
            this.BarIndividual.Size = new System.Drawing.Size(489, 23);
            this.BarIndividual.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 190);
            this.Controls.Add(this.BarIndividual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BarGeral);
            this.Name = "btnIniciar";
            this.Text = "Migracao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BarGeral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar BarIndividual;
    }
}
