namespace Winforms
{
    partial class Cadastro
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bttRegister = new Button();
            label4 = new Label();
            dgvPeople = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(31, 149);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(40, 23);
            txtAge.TabIndex = 2;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 131);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 78);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // bttRegister
            // 
            bttRegister.Location = new Point(31, 178);
            bttRegister.Name = "bttRegister";
            bttRegister.Size = new Size(75, 23);
            bttRegister.TabIndex = 6;
            bttRegister.Text = "Cadastrar";
            bttRegister.UseVisualStyleBackColor = true;
            bttRegister.Click += bttRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(512, 12);
            label4.Name = "label4";
            label4.Size = new Size(85, 30);
            label4.TabIndex = 8;
            label4.Text = "Pessoas";
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Location = new Point(346, 45);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.Size = new Size(407, 201);
            dgvPeople.TabIndex = 9;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPeople);
            Controls.Add(label4);
            Controls.Add(bttRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "Cadastro";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bttRegister;
        private Label label4;
        private DataGridView dgvPeople;
    }
}