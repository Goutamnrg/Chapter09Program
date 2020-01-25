namespace frmMain
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLeapYearResult = new System.Windows.Forms.Label();
            this.lblEasterResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter year :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(119, 37);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(50, 88);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(144, 88);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLeapYearResult
            // 
            this.lblLeapYearResult.AutoSize = true;
            this.lblLeapYearResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeapYearResult.Location = new System.Drawing.Point(102, 142);
            this.lblLeapYearResult.Name = "lblLeapYearResult";
            this.lblLeapYearResult.Size = new System.Drawing.Size(56, 15);
            this.lblLeapYearResult.TabIndex = 4;
            this.lblLeapYearResult.Text = "Leap year";
            // 
            // lblEasterResult
            // 
            this.lblEasterResult.AutoSize = true;
            this.lblEasterResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEasterResult.Location = new System.Drawing.Point(95, 170);
            this.lblEasterResult.Name = "lblEasterResult";
            this.lblEasterResult.Size = new System.Drawing.Size(69, 15);
            this.lblEasterResult.TabIndex = 5;
            this.lblEasterResult.Text = "Current Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 236);
            this.Controls.Add(this.lblEasterResult);
            this.Controls.Add(this.lblLeapYearResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Class Design";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLeapYearResult;
        private System.Windows.Forms.Label lblEasterResult;
    }
}

