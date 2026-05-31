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
            this.FIO_TB = new System.Windows.Forms.TextBox();
            this.Product_TB = new System.Windows.Forms.TextBox();
            this.Sum_TB = new System.Windows.Forms.TextBox();
            this.CreateDoc = new System.Windows.Forms.Button();
            this.Name_manager_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FIO_TB
            // 
            this.FIO_TB.Location = new System.Drawing.Point(55, 72);
            this.FIO_TB.Name = "FIO_TB";
            this.FIO_TB.Size = new System.Drawing.Size(100, 20);
            this.FIO_TB.TabIndex = 0;
            // 
            // Product_TB
            // 
            this.Product_TB.Location = new System.Drawing.Point(161, 72);
            this.Product_TB.Name = "Product_TB";
            this.Product_TB.Size = new System.Drawing.Size(100, 20);
            this.Product_TB.TabIndex = 1;
            // 
            // Sum_TB
            // 
            this.Sum_TB.Location = new System.Drawing.Point(267, 72);
            this.Sum_TB.Name = "Sum_TB";
            this.Sum_TB.Size = new System.Drawing.Size(100, 20);
            this.Sum_TB.TabIndex = 2;
            // 
            // CreateDoc
            // 
            this.CreateDoc.Location = new System.Drawing.Point(55, 132);
            this.CreateDoc.Name = "CreateDoc";
            this.CreateDoc.Size = new System.Drawing.Size(111, 23);
            this.CreateDoc.TabIndex = 3;
            this.CreateDoc.Text = "Создать документ";
            this.CreateDoc.UseVisualStyleBackColor = true;
            this.CreateDoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_manager_TB
            // 
            this.Name_manager_TB.Location = new System.Drawing.Point(373, 72);
            this.Name_manager_TB.Name = "Name_manager_TB";
            this.Name_manager_TB.Size = new System.Drawing.Size(100, 20);
            this.Name_manager_TB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ФИО менеджера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_manager_TB);
            this.Controls.Add(this.CreateDoc);
            this.Controls.Add(this.Sum_TB);
            this.Controls.Add(this.Product_TB);
            this.Controls.Add(this.FIO_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIO_TB;
        private System.Windows.Forms.TextBox Product_TB;
        private System.Windows.Forms.TextBox Sum_TB;
        private System.Windows.Forms.Button CreateDoc;
        private System.Windows.Forms.TextBox Name_manager_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

