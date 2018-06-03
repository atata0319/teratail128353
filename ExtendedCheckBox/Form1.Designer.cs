namespace ExtendedCheckBox
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.extendedCheckBox11 = new ExtendedCheckBox.ExtendedCheckBox1();
            this.extendedCheckBox21 = new ExtendedCheckBox.ExtendedCheckBox2();
            this.extendedCheckBox31 = new ExtendedCheckBox.ExtendedCheckBox3();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // extendedCheckBox11
            // 
            this.extendedCheckBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.extendedCheckBox11.AutoSize = true;
            this.extendedCheckBox11.Location = new System.Drawing.Point(93, 45);
            this.extendedCheckBox11.Name = "extendedCheckBox11";
            this.extendedCheckBox11.Size = new System.Drawing.Size(157, 25);
            this.extendedCheckBox11.TabIndex = 0;
            this.extendedCheckBox11.Text = "extendedCheckBox11";
            this.extendedCheckBox11.UseVisualStyleBackColor = true;
            // 
            // extendedCheckBox21
            // 
            this.extendedCheckBox21.Appearance = System.Windows.Forms.Appearance.Button;
            this.extendedCheckBox21.AutoSize = true;
            this.extendedCheckBox21.Enabled2 = true;
            this.extendedCheckBox21.ForeColor = System.Drawing.Color.Black;
            this.extendedCheckBox21.Location = new System.Drawing.Point(93, 114);
            this.extendedCheckBox21.Name = "extendedCheckBox21";
            this.extendedCheckBox21.Size = new System.Drawing.Size(157, 25);
            this.extendedCheckBox21.TabIndex = 1;
            this.extendedCheckBox21.Text = "extendedCheckBox21";
            this.extendedCheckBox21.UseVisualStyleBackColor = true;
            // 
            // extendedCheckBox31
            // 
            this.extendedCheckBox31.Appearance = System.Windows.Forms.Appearance.Button;
            this.extendedCheckBox31.AutoSize = true;
            this.extendedCheckBox31.Location = new System.Drawing.Point(93, 188);
            this.extendedCheckBox31.Name = "extendedCheckBox31";
            this.extendedCheckBox31.Size = new System.Drawing.Size(157, 25);
            this.extendedCheckBox31.TabIndex = 2;
            this.extendedCheckBox31.Text = "extendedCheckBox31";
            this.extendedCheckBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(432, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "有効／無効切り替え";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.extendedCheckBox31);
            this.Controls.Add(this.extendedCheckBox21);
            this.Controls.Add(this.extendedCheckBox11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExtendedCheckBox1 extendedCheckBox11;
        private ExtendedCheckBox2 extendedCheckBox21;
        private ExtendedCheckBox3 extendedCheckBox31;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

