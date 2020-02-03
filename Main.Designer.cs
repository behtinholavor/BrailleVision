namespace BrailleVision
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.btnShoot = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnReproduce = new MetroFramework.Controls.MetroButton();
            this.btnConvert = new MetroFramework.Controls.MetroButton();
            this.txtInput = new MetroFramework.Controls.MetroTextBox();
            this.lblConvert = new MetroFramework.Controls.MetroLabel();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.lblInput = new MetroFramework.Controls.MetroLabel();
            this.dialogFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblInput);
            this.pnlMain.Controls.Add(this.txtConvert);
            this.pnlMain.Controls.Add(this.lblConvert);
            this.pnlMain.Controls.Add(this.btnShoot);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnReproduce);
            this.pnlMain.Controls.Add(this.btnConvert);
            this.pnlMain.Controls.Add(this.txtInput);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1104, 520);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // btnShoot
            // 
            this.btnShoot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShoot.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShoot.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnShoot.Location = new System.Drawing.Point(617, 414);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(114, 58);
            this.btnShoot.TabIndex = 7;
            this.btnShoot.Text = "FOTO";
            this.btnShoot.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.Location = new System.Drawing.Point(737, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 58);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "FECHAR";
            this.btnClose.UseSelectable = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(497, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 58);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "LIMPAR";
            this.btnClear.UseSelectable = true;
            // 
            // btnReproduce
            // 
            this.btnReproduce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReproduce.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReproduce.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnReproduce.Location = new System.Drawing.Point(377, 414);
            this.btnReproduce.Name = "btnReproduce";
            this.btnReproduce.Size = new System.Drawing.Size(114, 58);
            this.btnReproduce.TabIndex = 4;
            this.btnReproduce.Text = "REPRODUZIR";
            this.btnReproduce.UseSelectable = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvert.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConvert.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnConvert.Location = new System.Drawing.Point(257, 414);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(114, 58);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "CONVERTER";
            this.btnConvert.UseSelectable = true;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtInput.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.CustomButton.Image = null;
            this.txtInput.CustomButton.Location = new System.Drawing.Point(438, 2);
            this.txtInput.CustomButton.Name = "";
            this.txtInput.CustomButton.Size = new System.Drawing.Size(153, 153);
            this.txtInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInput.CustomButton.TabIndex = 1;
            this.txtInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInput.CustomButton.UseSelectable = true;
            this.txtInput.CustomButton.Visible = false;
            this.txtInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInput.Lines = new string[0];
            this.txtInput.Location = new System.Drawing.Point(257, 35);
            this.txtInput.Margin = new System.Windows.Forms.Padding(10);
            this.txtInput.MaximumSize = new System.Drawing.Size(594, 158);
            this.txtInput.MaxLength = 32767;
            this.txtInput.MinimumSize = new System.Drawing.Size(594, 158);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.PromptText = "Informe o texto para conversão/reprodução";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.ShortcutsEnabled = true;
            this.txtInput.Size = new System.Drawing.Size(594, 158);
            this.txtInput.TabIndex = 2;
            this.txtInput.UseSelectable = true;
            this.txtInput.WaterMark = "Informe o texto para conversão/reprodução";
            this.txtInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblConvert
            // 
            this.lblConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConvert.AutoSize = true;
            this.lblConvert.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblConvert.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblConvert.Location = new System.Drawing.Point(257, 203);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(103, 15);
            this.lblConvert.TabIndex = 8;
            this.lblConvert.Text = "Texto convertido";
            // 
            // txtConvert
            // 
            this.txtConvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvert.Location = new System.Drawing.Point(257, 225);
            this.txtConvert.MaximumSize = new System.Drawing.Size(594, 158);
            this.txtConvert.MinimumSize = new System.Drawing.Size(594, 158);
            this.txtConvert.Multiline = true;
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.ReadOnly = true;
            this.txtConvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConvert.Size = new System.Drawing.Size(594, 158);
            this.txtConvert.TabIndex = 9;
            // 
            // lblInput
            // 
            this.lblInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInput.AutoSize = true;
            this.lblInput.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblInput.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInput.Location = new System.Drawing.Point(257, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(102, 15);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "Texto de entrada";
            // 
            // dialogFile
            // 
            this.dialogFile.DefaultExt = "bmp";
            this.dialogFile.FileName = "*.*";
            this.dialogFile.InitialDirectory = "C:\\_avanade\\academia\\BrailleVision\\Resource\\";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 520);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrailleVision";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMain;
        private MetroFramework.Controls.MetroTextBox txtInput;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnReproduce;
        private MetroFramework.Controls.MetroButton btnConvert;
        private MetroFramework.Controls.MetroButton btnShoot;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel lblConvert;
        private MetroFramework.Controls.MetroLabel lblInput;
        private System.Windows.Forms.TextBox txtConvert;
        public System.Windows.Forms.OpenFileDialog dialogFile;
    }
}

