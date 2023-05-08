namespace Generator_Password
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GENERATOR = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GENERATOR
            // 
            this.GENERATOR.Location = new System.Drawing.Point(107, 79);
            this.GENERATOR.Name = "GENERATOR";
            this.GENERATOR.Size = new System.Drawing.Size(85, 23);
            this.GENERATOR.TabIndex = 0;
            this.GENERATOR.Text = "GENERATE";
            this.GENERATOR.UseVisualStyleBackColor = true;
            this.GENERATOR.Click += new System.EventHandler(this.GENERATOR_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(113, 117);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(0, 16);
            this.Password.TabIndex = 1;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(47, 42);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(208, 22);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "How Long Password do you need";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Copy Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.GENERATOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GENERATOR;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

