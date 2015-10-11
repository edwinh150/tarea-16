namespace Tarea11y12
{
    partial class Cap11e5Form
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.NuevoNombretextBox = new System.Windows.Forms.TextBox();
            this.Copiarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(64, 66);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(236, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(64, 124);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(236, 20);
            this.RutatextBox.TabIndex = 0;
            // 
            // NuevoNombretextBox
            // 
            this.NuevoNombretextBox.Location = new System.Drawing.Point(64, 186);
            this.NuevoNombretextBox.Name = "NuevoNombretextBox";
            this.NuevoNombretextBox.Size = new System.Drawing.Size(236, 20);
            this.NuevoNombretextBox.TabIndex = 0;
            // 
            // Copiarbutton
            // 
            this.Copiarbutton.Location = new System.Drawing.Point(141, 253);
            this.Copiarbutton.Name = "Copiarbutton";
            this.Copiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Copiarbutton.TabIndex = 1;
            this.Copiarbutton.Text = "Copiar";
            this.Copiarbutton.UseVisualStyleBackColor = true;
            this.Copiarbutton.Click += new System.EventHandler(this.Copiarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nuevo Nombre";
            // 
            // Cap11e5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copiarbutton);
            this.Controls.Add(this.NuevoNombretextBox);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cap11e5Form";
            this.Text = "Cap11e5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.TextBox NuevoNombretextBox;
        private System.Windows.Forms.Button Copiarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}