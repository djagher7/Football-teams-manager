namespace Football_teams_manager
{
    partial class Form2
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
            this.txtIDNP1 = new System.Windows.Forms.TextBox();
            this.txtPozitie1 = new System.Windows.Forms.TextBox();
            this.txtNume1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDNP1
            // 
            this.txtIDNP1.Location = new System.Drawing.Point(192, 186);
            this.txtIDNP1.Name = "txtIDNP1";
            this.txtIDNP1.Size = new System.Drawing.Size(209, 22);
            this.txtIDNP1.TabIndex = 13;
            // 
            // txtPozitie1
            // 
            this.txtPozitie1.Location = new System.Drawing.Point(192, 149);
            this.txtPozitie1.Name = "txtPozitie1";
            this.txtPozitie1.Size = new System.Drawing.Size(209, 22);
            this.txtPozitie1.TabIndex = 12;
            // 
            // txtNume1
            // 
            this.txtNume1.Location = new System.Drawing.Point(192, 111);
            this.txtNume1.Name = "txtNume1";
            this.txtNume1.Size = new System.Drawing.Size(209, 22);
            this.txtNume1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data naștere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "IDNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Poziție";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.Location = new System.Drawing.Point(192, 225);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.ShowCheckBox = true;
            this.dateTimePicker11.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker11.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(116, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adăugare Jucător";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(146, 267);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 28);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 319);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDNP1);
            this.Controls.Add(this.txtPozitie1);
            this.Controls.Add(this.txtNume1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDNP1;
        private System.Windows.Forms.TextBox txtPozitie1;
        private System.Windows.Forms.TextBox txtNume1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
    }
}