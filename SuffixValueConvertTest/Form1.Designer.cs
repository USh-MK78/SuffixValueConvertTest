
namespace SuffixValueConvertTest
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputSuffixValueTXT = new System.Windows.Forms.TextBox();
            this.OutputValueTXT = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suffix value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value :";
            // 
            // InputSuffixValueTXT
            // 
            this.InputSuffixValueTXT.Location = new System.Drawing.Point(12, 24);
            this.InputSuffixValueTXT.Name = "InputSuffixValueTXT";
            this.InputSuffixValueTXT.Size = new System.Drawing.Size(159, 19);
            this.InputSuffixValueTXT.TabIndex = 3;
            this.InputSuffixValueTXT.Text = "1.0f";
            // 
            // OutputValueTXT
            // 
            this.OutputValueTXT.Location = new System.Drawing.Point(12, 65);
            this.OutputValueTXT.Name = "OutputValueTXT";
            this.OutputValueTXT.Size = new System.Drawing.Size(159, 19);
            this.OutputValueTXT.TabIndex = 4;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(12, 95);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(159, 23);
            this.Convert.TabIndex = 1;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 94);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value -> Suffix value :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 129);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.OutputValueTXT);
            this.Controls.Add(this.InputSuffixValueTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(371, 168);
            this.MinimumSize = new System.Drawing.Size(371, 168);
            this.Name = "Form1";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputSuffixValueTXT;
        private System.Windows.Forms.TextBox OutputValueTXT;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

