namespace HomeworkManager.Forms
{
    partial class OutputDialog
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
            this.textBox_OutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_OutPut
            // 
            this.textBox_OutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_OutPut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OutPut.Location = new System.Drawing.Point(0, 0);
            this.textBox_OutPut.Multiline = true;
            this.textBox_OutPut.Name = "textBox_OutPut";
            this.textBox_OutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OutPut.Size = new System.Drawing.Size(474, 270);
            this.textBox_OutPut.TabIndex = 0;
            // 
            // OutputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 270);
            this.Controls.Add(this.textBox_OutPut);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutputDialog";
            this.Text = "Homework Manager - 初始化 - 输出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OutPut;
    }
}