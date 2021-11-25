namespace CG_lab1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCreate = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(26, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 280);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(339, 216);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(127, 48);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Построить сплайн";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(339, 270);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(127, 48);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Место для рисования";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Построение сплайна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label1;
    }
}

