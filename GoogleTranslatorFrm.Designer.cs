namespace RavSoft.GoogleTranslator
{
    partial class GoogleTranslatorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleTranslatorFrm));
            this.label1 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this._lnkSourceEnglish = new System.Windows.Forms.LinkLabel();
            this._lnkTargetEnglish = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source language:";
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(8, 24);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(156, 25);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 1;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(184, 24);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(156, 25);
            this._comboTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target language:";
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.Location = new System.Drawing.Point(131, 196);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(75, 23);
            this._btnTranslate.TabIndex = 13;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(6, 220);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(20, 17);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "   ";
            // 
            // _lnkSourceEnglish
            // 
            this._lnkSourceEnglish.AutoSize = true;
            this._lnkSourceEnglish.Location = new System.Drawing.Point(128, 8);
            this._lnkSourceEnglish.Name = "_lnkSourceEnglish";
            this._lnkSourceEnglish.Size = new System.Drawing.Size(50, 17);
            this._lnkSourceEnglish.TabIndex = 2;
            this._lnkSourceEnglish.TabStop = true;
            this._lnkSourceEnglish.Text = "English";
            this._lnkSourceEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkSourceEnglish_LinkClicked);
            // 
            // _lnkTargetEnglish
            // 
            this._lnkTargetEnglish.AutoSize = true;
            this._lnkTargetEnglish.Location = new System.Drawing.Point(304, 8);
            this._lnkTargetEnglish.Name = "_lnkTargetEnglish";
            this._lnkTargetEnglish.Size = new System.Drawing.Size(50, 17);
            this._lnkTargetEnglish.TabIndex = 5;
            this._lnkTargetEnglish.TabStop = true;
            this._lnkTargetEnglish.Text = "English";
            this._lnkTargetEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkTargetEnglish_LinkClicked);
            // 
            // GoogleTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 231);
            this.Controls.Add(this._lnkTargetEnglish);
            this.Controls.Add(this._lnkSourceEnglish);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 278);
            this.MinimumSize = new System.Drawing.Size(360, 278);
            this.Name = "GoogleTranslatorFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Translator Demo";
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.LinkLabel _lnkSourceEnglish;
        private System.Windows.Forms.LinkLabel _lnkTargetEnglish;
    }
}