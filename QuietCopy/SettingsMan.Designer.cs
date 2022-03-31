namespace QuietCopy
{
    partial class SettingsMan
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
            this.destDirTbox = new System.Windows.Forms.TextBox();
            this.destDirBut = new System.Windows.Forms.Button();
            this.specYes = new System.Windows.Forms.RadioButton();
            this.specNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specDirPthTxtBx = new System.Windows.Forms.TextBox();
            this.saveBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Folder";
            // 
            // destDirTbox
            // 
            this.destDirTbox.Location = new System.Drawing.Point(178, 73);
            this.destDirTbox.Name = "destDirTbox";
            this.destDirTbox.Size = new System.Drawing.Size(100, 20);
            this.destDirTbox.TabIndex = 1;
            // 
            // destDirBut
            // 
            this.destDirBut.Location = new System.Drawing.Point(285, 73);
            this.destDirBut.Name = "destDirBut";
            this.destDirBut.Size = new System.Drawing.Size(75, 23);
            this.destDirBut.TabIndex = 2;
            this.destDirBut.Text = "....";
            this.destDirBut.UseVisualStyleBackColor = true;
            // 
            // specYes
            // 
            this.specYes.AutoSize = true;
            this.specYes.Location = new System.Drawing.Point(178, 154);
            this.specYes.Name = "specYes";
            this.specYes.Size = new System.Drawing.Size(43, 17);
            this.specYes.TabIndex = 3;
            this.specYes.TabStop = true;
            this.specYes.Text = "Yes";
            this.specYes.UseVisualStyleBackColor = true;
            this.specYes.CheckedChanged += new System.EventHandler(this.specYes_CheckedChanged);
            // 
            // specNo
            // 
            this.specNo.AutoSize = true;
            this.specNo.Location = new System.Drawing.Point(178, 178);
            this.specNo.Name = "specNo";
            this.specNo.Size = new System.Drawing.Size(39, 17);
            this.specNo.TabIndex = 4;
            this.specNo.TabStop = true;
            this.specNo.Text = "No";
            this.specNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copy from a specific folder on drive:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "copy-from folder location";
            // 
            // specDirPthTxtBx
            // 
            this.specDirPthTxtBx.Enabled = false;
            this.specDirPthTxtBx.Location = new System.Drawing.Point(178, 217);
            this.specDirPthTxtBx.Name = "specDirPthTxtBx";
            this.specDirPthTxtBx.Size = new System.Drawing.Size(100, 20);
            this.specDirPthTxtBx.TabIndex = 7;
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(259, 306);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 8;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(140, 306);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 9;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SettingsMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.specDirPthTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specNo);
            this.Controls.Add(this.specYes);
            this.Controls.Add(this.destDirBut);
            this.Controls.Add(this.destDirTbox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsMan";
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destDirTbox;
        private System.Windows.Forms.Button destDirBut;
        private System.Windows.Forms.RadioButton specYes;
        private System.Windows.Forms.RadioButton specNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specDirPthTxtBx;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button button1;
    }
}