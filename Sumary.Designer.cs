namespace TypeRacer
{
    partial class Sumary
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSumaryTotal = new System.Windows.Forms.Label();
            this.lbSumaryCorrected = new System.Windows.Forms.Label();
            this.lbSumaryMissed = new System.Windows.Forms.Label();
            this.lbSumaryAccuracy = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Corrected:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Missed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Accuracy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // lbSumaryTotal
            // 
            this.lbSumaryTotal.AutoSize = true;
            this.lbSumaryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumaryTotal.Location = new System.Drawing.Point(221, 21);
            this.lbSumaryTotal.Name = "lbSumaryTotal";
            this.lbSumaryTotal.Size = new System.Drawing.Size(0, 29);
            this.lbSumaryTotal.TabIndex = 5;
            // 
            // lbSumaryCorrected
            // 
            this.lbSumaryCorrected.AutoSize = true;
            this.lbSumaryCorrected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumaryCorrected.Location = new System.Drawing.Point(221, 62);
            this.lbSumaryCorrected.Name = "lbSumaryCorrected";
            this.lbSumaryCorrected.Size = new System.Drawing.Size(0, 29);
            this.lbSumaryCorrected.TabIndex = 6;
            // 
            // lbSumaryMissed
            // 
            this.lbSumaryMissed.AutoSize = true;
            this.lbSumaryMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumaryMissed.Location = new System.Drawing.Point(221, 102);
            this.lbSumaryMissed.Name = "lbSumaryMissed";
            this.lbSumaryMissed.Size = new System.Drawing.Size(0, 29);
            this.lbSumaryMissed.TabIndex = 7;
            // 
            // lbSumaryAccuracy
            // 
            this.lbSumaryAccuracy.AutoSize = true;
            this.lbSumaryAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumaryAccuracy.Location = new System.Drawing.Point(221, 141);
            this.lbSumaryAccuracy.Name = "lbSumaryAccuracy";
            this.lbSumaryAccuracy.Size = new System.Drawing.Size(0, 29);
            this.lbSumaryAccuracy.TabIndex = 8;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btExit.Location = new System.Drawing.Point(226, 203);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(137, 38);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAgain
            // 
            this.btAgain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgain.Location = new System.Drawing.Point(27, 203);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(142, 38);
            this.btAgain.TabIndex = 10;
            this.btAgain.Text = "Again ?";
            this.btAgain.UseVisualStyleBackColor = false;
            this.btAgain.Click += new System.EventHandler(this.btAgain_Click);
            // 
            // Sumary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbSumaryAccuracy);
            this.Controls.Add(this.lbSumaryMissed);
            this.Controls.Add(this.lbSumaryCorrected);
            this.Controls.Add(this.lbSumaryTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sumary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumary";
            this.Load += new System.EventHandler(this.Sumary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSumaryTotal;
        private System.Windows.Forms.Label lbSumaryCorrected;
        private System.Windows.Forms.Label lbSumaryMissed;
        private System.Windows.Forms.Label lbSumaryAccuracy;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAgain;
    }
}