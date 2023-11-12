namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Help = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.inputColor = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Panel();
            this.left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(75, 175);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(125, 44);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(75, 240);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 51);
            this.close.TabIndex = 2;
            this.close.Text = "Exit";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(75, 102);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(125, 52);
            this.Change.TabIndex = 1;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // inputColor
            // 
            this.inputColor.Location = new System.Drawing.Point(75, 30);
            this.inputColor.Name = "inputColor";
            this.inputColor.Size = new System.Drawing.Size(125, 54);
            this.inputColor.TabIndex = 0;
            this.inputColor.Text = "Input color";
            this.inputColor.UseVisualStyleBackColor = true;
            this.inputColor.Click += new System.EventHandler(this.inputColor_Click);
            // 
            // left
            // 
            this.left.Controls.Add(this.inputColor);
            this.left.Controls.Add(this.Change);
            this.left.Controls.Add(this.Help);
            this.left.Controls.Add(this.close);
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(231, 393);
            this.left.TabIndex = 5;
            // 
            // right
            // 
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(230, 0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(239, 393);
            this.right.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 393);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Name = "Form1";
            this.Text = "Худяков Н.А. В-8 ПИЗ-221";
            this.left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button inputColor;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel left;
        private System.Windows.Forms.Panel right;
    }
}

