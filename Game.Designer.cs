namespace TypeRacer
{
    partial class Game
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
            this.lbGameText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbFirstCharacter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusAccuracy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCorrected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMissed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTotalTimesType = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGameText
            // 
            this.lbGameText.AutoSize = true;
            this.lbGameText.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameText.Location = new System.Drawing.Point(103, 24);
            this.lbGameText.Name = "lbGameText";
            this.lbGameText.Size = new System.Drawing.Size(896, 134);
            this.lbGameText.TabIndex = 1;
            this.lbGameText.Text = "       Type Racer";
            this.lbGameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(243, 143);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbFirstCharacter
            // 
            this.lbFirstCharacter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbFirstCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFirstCharacter.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstCharacter.ForeColor = System.Drawing.Color.Black;
            this.lbFirstCharacter.Location = new System.Drawing.Point(0, 28);
            this.lbFirstCharacter.Name = "lbFirstCharacter";
            this.lbFirstCharacter.Size = new System.Drawing.Size(134, 126);
            this.lbFirstCharacter.TabIndex = 3;
            this.lbFirstCharacter.Text = "a";
            this.lbFirstCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAccuracy,
            this.toolStripStatusCorrected,
            this.toolStripStatusMissed,
            this.toolStripStatusTotalTimesType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1103, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusAccuracy
            // 
            this.toolStripStatusAccuracy.Name = "toolStripStatusAccuracy";
            this.toolStripStatusAccuracy.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusAccuracy.Text = "Accuracy";
            // 
            // toolStripStatusCorrected
            // 
            this.toolStripStatusCorrected.Name = "toolStripStatusCorrected";
            this.toolStripStatusCorrected.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusCorrected.Text = "Corrected";
            // 
            // toolStripStatusMissed
            // 
            this.toolStripStatusMissed.Name = "toolStripStatusMissed";
            this.toolStripStatusMissed.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusMissed.Text = "Missed";
            // 
            // toolStripStatusTotalTimesType
            // 
            this.toolStripStatusTotalTimesType.Name = "toolStripStatusTotalTimesType";
            this.toolStripStatusTotalTimesType.Size = new System.Drawing.Size(43, 20);
            this.toolStripStatusTotalTimesType.Text = "Total";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(712, 232);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1103, 256);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbGameText);
            this.Controls.Add(this.lbFirstCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Racer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGameText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbFirstCharacter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAccuracy;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCorrected;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMissed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTotalTimesType;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

