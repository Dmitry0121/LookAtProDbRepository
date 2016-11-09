namespace demo.database_4
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
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.radioButtonAddNewCategorie = new System.Windows.Forms.RadioButton();
            this.radioButtonAddNewProduct = new System.Windows.Forms.RadioButton();
            this.textBoxAddNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(26, 61);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "ok";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // radioButtonAddNewCategorie
            // 
            this.radioButtonAddNewCategorie.AutoSize = true;
            this.radioButtonAddNewCategorie.Location = new System.Drawing.Point(137, 12);
            this.radioButtonAddNewCategorie.Name = "radioButtonAddNewCategorie";
            this.radioButtonAddNewCategorie.Size = new System.Drawing.Size(113, 17);
            this.radioButtonAddNewCategorie.TabIndex = 1;
            this.radioButtonAddNewCategorie.TabStop = true;
            this.radioButtonAddNewCategorie.Text = "add new categorie";
            this.radioButtonAddNewCategorie.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddNewProduct
            // 
            this.radioButtonAddNewProduct.AutoSize = true;
            this.radioButtonAddNewProduct.Location = new System.Drawing.Point(26, 12);
            this.radioButtonAddNewProduct.Name = "radioButtonAddNewProduct";
            this.radioButtonAddNewProduct.Size = new System.Drawing.Size(105, 17);
            this.radioButtonAddNewProduct.TabIndex = 2;
            this.radioButtonAddNewProduct.TabStop = true;
            this.radioButtonAddNewProduct.Text = "add new product";
            this.radioButtonAddNewProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxAddNew
            // 
            this.textBoxAddNew.Location = new System.Drawing.Point(26, 35);
            this.textBoxAddNew.Name = "textBoxAddNew";
            this.textBoxAddNew.Size = new System.Drawing.Size(224, 20);
            this.textBoxAddNew.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.textBoxAddNew);
            this.Controls.Add(this.radioButtonAddNewProduct);
            this.Controls.Add(this.radioButtonAddNewCategorie);
            this.Controls.Add(this.buttonAddNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.RadioButton radioButtonAddNewCategorie;
        private System.Windows.Forms.RadioButton radioButtonAddNewProduct;
        private System.Windows.Forms.TextBox textBoxAddNew;
    }
}

