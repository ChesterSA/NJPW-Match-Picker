namespace NJPWMatchRecommender
{
    partial class MainForm
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
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblKeyWords = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.lblEngCommentary = new System.Windows.Forms.Label();
            this.cbEngComm = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.cbWorthWatch = new System.Windows.Forms.CheckBox();
            this.cbRecommended = new System.Windows.Forms.CheckBox();
            this.cbHighRec = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(13, 24);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(16, 40);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(125, 20);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(16, 90);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(125, 20);
            this.dtpDateTo.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(13, 73);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "Date To";
            // 
            // lblKeyWords
            // 
            this.lblKeyWords.AutoSize = true;
            this.lblKeyWords.Location = new System.Drawing.Point(159, 24);
            this.lblKeyWords.Name = "lblKeyWords";
            this.lblKeyWords.Size = new System.Drawing.Size(59, 13);
            this.lblKeyWords.TabIndex = 4;
            this.lblKeyWords.Text = "Key Words";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(162, 40);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(125, 20);
            this.txtKeyWords.TabIndex = 5;
            // 
            // lblEngCommentary
            // 
            this.lblEngCommentary.AutoSize = true;
            this.lblEngCommentary.Location = new System.Drawing.Point(159, 73);
            this.lblEngCommentary.Name = "lblEngCommentary";
            this.lblEngCommentary.Size = new System.Drawing.Size(90, 13);
            this.lblEngCommentary.TabIndex = 6;
            this.lblEngCommentary.Text = "Eng. Commentary";
            // 
            // cbEngComm
            // 
            this.cbEngComm.AutoSize = true;
            this.cbEngComm.Location = new System.Drawing.Point(162, 90);
            this.cbEngComm.Name = "cbEngComm";
            this.cbEngComm.Size = new System.Drawing.Size(15, 14);
            this.cbEngComm.TabIndex = 7;
            this.cbEngComm.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Which Match Should I Watch";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 199);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbOutput.Size = new System.Drawing.Size(427, 134);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(16, 125);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbWorthWatch
            // 
            this.cbWorthWatch.AutoSize = true;
            this.cbWorthWatch.Checked = true;
            this.cbWorthWatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWorthWatch.Location = new System.Drawing.Point(305, 40);
            this.cbWorthWatch.Name = "cbWorthWatch";
            this.cbWorthWatch.Size = new System.Drawing.Size(99, 17);
            this.cbWorthWatch.TabIndex = 11;
            this.cbWorthWatch.Text = "Worth a Watch";
            this.cbWorthWatch.UseVisualStyleBackColor = true;
            // 
            // cbRecommended
            // 
            this.cbRecommended.AutoSize = true;
            this.cbRecommended.Checked = true;
            this.cbRecommended.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRecommended.Location = new System.Drawing.Point(306, 64);
            this.cbRecommended.Name = "cbRecommended";
            this.cbRecommended.Size = new System.Drawing.Size(98, 17);
            this.cbRecommended.TabIndex = 12;
            this.cbRecommended.Text = "Recommended";
            this.cbRecommended.UseVisualStyleBackColor = true;
            // 
            // cbHighRec
            // 
            this.cbHighRec.AutoSize = true;
            this.cbHighRec.Checked = true;
            this.cbHighRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHighRec.Location = new System.Drawing.Point(306, 87);
            this.cbHighRec.Name = "cbHighRec";
            this.cbHighRec.Size = new System.Drawing.Size(130, 17);
            this.cbHighRec.TabIndex = 13;
            this.cbHighRec.Text = "Highly Recommended";
            this.cbHighRec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 2);
            this.label1.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHighRec);
            this.Controls.Add(this.cbRecommended);
            this.Controls.Add(this.cbWorthWatch);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEngComm);
            this.Controls.Add(this.lblEngCommentary);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.lblKeyWords);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Name = "MainForm";
            this.Text = "NJPW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblKeyWords;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label lblEngCommentary;
        private System.Windows.Forms.CheckBox cbEngComm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox cbWorthWatch;
        private System.Windows.Forms.CheckBox cbRecommended;
        private System.Windows.Forms.CheckBox cbHighRec;
        private System.Windows.Forms.Label label1;
    }
}

