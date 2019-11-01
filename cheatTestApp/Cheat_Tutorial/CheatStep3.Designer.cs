namespace Cheat_Tutorial
{
    partial class CheatStep3
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStr3 = new System.Windows.Forms.Button();
            this.btnStr1 = new System.Windows.Forms.Button();
            this.btnStr2 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 152);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Step 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // btnStr3
            // 
            this.btnStr3.Location = new System.Drawing.Point(236, 120);
            this.btnStr3.Name = "btnStr3";
            this.btnStr3.Size = new System.Drawing.Size(75, 23);
            this.btnStr3.TabIndex = 16;
            this.btnStr3.Text = "String 3";
            this.btnStr3.UseVisualStyleBackColor = true;
            this.btnStr3.Click += new System.EventHandler(this.btnStr3_Click);
            // 
            // btnStr1
            // 
            this.btnStr1.Location = new System.Drawing.Point(16, 120);
            this.btnStr1.Name = "btnStr1";
            this.btnStr1.Size = new System.Drawing.Size(75, 23);
            this.btnStr1.TabIndex = 15;
            this.btnStr1.Text = "String 1";
            this.btnStr1.UseVisualStyleBackColor = true;
            this.btnStr1.Click += new System.EventHandler(this.btnStr1_Click);
            // 
            // btnStr2
            // 
            this.btnStr2.Location = new System.Drawing.Point(128, 120);
            this.btnStr2.Name = "btnStr2";
            this.btnStr2.Size = new System.Drawing.Size(75, 23);
            this.btnStr2.TabIndex = 20;
            this.btnStr2.Text = "String 2";
            this.btnStr2.UseVisualStyleBackColor = true;
            this.btnStr2.Click += new System.EventHandler(this.btnStr2_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(8, 40);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(312, 72);
            this.lblOutput.TabIndex = 21;
            this.lblOutput.Text = "SAMPLE TEXT";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CheatStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 189);
            this.Controls.Add(this.btnStr2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStr3);
            this.Controls.Add(this.btnStr1);
            this.Controls.Add(this.lblOutput);
            this.MaximumSize = new System.Drawing.Size(344, 228);
            this.MinimumSize = new System.Drawing.Size(344, 228);
            this.Name = "CheatStep3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheat Engine Tutorial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheatStep3_FormClosing);
            this.Load += new System.EventHandler(this.CheatStep3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStr3;
        private System.Windows.Forms.Button btnStr1;
        private System.Windows.Forms.Button btnStr2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Timer timer1;
    }
}