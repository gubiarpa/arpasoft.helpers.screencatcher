namespace ScreenCatchApp
{
    partial class FrmMain
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
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnShowCatcher = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetPosition = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.grpMeasures = new System.Windows.Forms.GroupBox();
            this.numCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foldMain = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.grpFolderDiag = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpButtons.SuspendLayout();
            this.grpMeasures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
            this.grpFolderDiag.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCatch
            // 
            this.btnCatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCatch.Location = new System.Drawing.Point(6, 119);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(162, 44);
            this.btnCatch.TabIndex = 1;
            this.btnCatch.Text = "Catch";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            // 
            // btnShowCatcher
            // 
            this.btnShowCatcher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowCatcher.Location = new System.Drawing.Point(6, 19);
            this.btnShowCatcher.Name = "btnShowCatcher";
            this.btnShowCatcher.Size = new System.Drawing.Size(162, 44);
            this.btnShowCatcher.TabIndex = 2;
            this.btnShowCatcher.Text = "Show Catcher";
            this.btnShowCatcher.UseVisualStyleBackColor = true;
            this.btnShowCatcher.Click += new System.EventHandler(this.btnShowCatcher_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(6, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetPosition
            // 
            this.btnSetPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetPosition.Location = new System.Drawing.Point(6, 69);
            this.btnSetPosition.Name = "btnSetPosition";
            this.btnSetPosition.Size = new System.Drawing.Size(162, 44);
            this.btnSetPosition.TabIndex = 4;
            this.btnSetPosition.Text = "Set Position";
            this.btnSetPosition.UseVisualStyleBackColor = true;
            this.btnSetPosition.Click += new System.EventHandler(this.btnSetPosition_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnShowCatcher);
            this.grpButtons.Controls.Add(this.btnSetPosition);
            this.grpButtons.Controls.Add(this.btnCatch);
            this.grpButtons.Controls.Add(this.btnExit);
            this.grpButtons.Location = new System.Drawing.Point(12, 12);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(177, 224);
            this.grpButtons.TabIndex = 5;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Buttons";
            // 
            // grpMeasures
            // 
            this.grpMeasures.Controls.Add(this.numCounter);
            this.grpMeasures.Controls.Add(this.label5);
            this.grpMeasures.Controls.Add(this.txtWidth);
            this.grpMeasures.Controls.Add(this.txtHeight);
            this.grpMeasures.Controls.Add(this.txtLeft);
            this.grpMeasures.Controls.Add(this.txtTop);
            this.grpMeasures.Controls.Add(this.label4);
            this.grpMeasures.Controls.Add(this.label3);
            this.grpMeasures.Controls.Add(this.label2);
            this.grpMeasures.Controls.Add(this.label1);
            this.grpMeasures.Location = new System.Drawing.Point(195, 12);
            this.grpMeasures.Name = "grpMeasures";
            this.grpMeasures.Size = new System.Drawing.Size(230, 224);
            this.grpMeasures.TabIndex = 6;
            this.grpMeasures.TabStop = false;
            this.grpMeasures.Text = "Measures";
            // 
            // numCounter
            // 
            this.numCounter.Location = new System.Drawing.Point(83, 183);
            this.numCounter.Name = "numCounter";
            this.numCounter.Size = new System.Drawing.Size(122, 20);
            this.numCounter.TabIndex = 9;
            this.numCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Counter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(83, 143);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(122, 20);
            this.txtWidth.TabIndex = 7;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(83, 104);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(122, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(83, 69);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(122, 20);
            this.txtLeft.TabIndex = 5;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(83, 32);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(122, 20);
            this.txtTop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(6, 28);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(347, 20);
            this.txtFolder.TabIndex = 7;
            // 
            // grpFolderDiag
            // 
            this.grpFolderDiag.Controls.Add(this.btnSearch);
            this.grpFolderDiag.Controls.Add(this.txtFolder);
            this.grpFolderDiag.Location = new System.Drawing.Point(12, 242);
            this.grpFolderDiag.Name = "grpFolderDiag";
            this.grpFolderDiag.Size = new System.Drawing.Size(413, 67);
            this.grpFolderDiag.TabIndex = 8;
            this.grpFolderDiag.TabStop = false;
            this.grpFolderDiag.Text = "Selecciona carpeta";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(359, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 21);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 324);
            this.ControlBox = false;
            this.Controls.Add(this.grpFolderDiag);
            this.Controls.Add(this.grpMeasures);
            this.Controls.Add(this.grpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.Text = "Screen Catcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpButtons.ResumeLayout(false);
            this.grpMeasures.ResumeLayout(false);
            this.grpMeasures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
            this.grpFolderDiag.ResumeLayout(false);
            this.grpFolderDiag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnShowCatcher;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetPosition;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpMeasures;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog foldMain;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.GroupBox grpFolderDiag;
        private System.Windows.Forms.Button btnSearch;
    }
}