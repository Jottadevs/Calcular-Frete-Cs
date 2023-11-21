namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            checkBAreo = new CheckBox();
            checkBTerrestre = new CheckBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            btnCalcular = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            textBoxRES = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(213, 33);
            label1.TabIndex = 0;
            label1.Text = "Calculo de frete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 1;
            label2.Text = "Meio de transporte?";
            // 
            // checkBAreo
            // 
            checkBAreo.AutoSize = true;
            checkBAreo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBAreo.Location = new Point(23, 105);
            checkBAreo.Name = "checkBAreo";
            checkBAreo.Size = new Size(83, 32);
            checkBAreo.TabIndex = 2;
            checkBAreo.Text = "Aéreo";
            checkBAreo.UseVisualStyleBackColor = true;
            // 
            // checkBTerrestre
            // 
            checkBTerrestre.AutoSize = true;
            checkBTerrestre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBTerrestre.Location = new Point(23, 132);
            checkBTerrestre.Name = "checkBTerrestre";
            checkBTerrestre.Size = new Size(105, 32);
            checkBTerrestre.TabIndex = 3;
            checkBTerrestre.Text = "Terrestre";
            checkBTerrestre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 4;
            label3.Text = "Infos - Produtos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 267);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 243);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 7;
            label4.Text = "Nome do produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 293);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 9;
            label5.Text = "Peso do produto:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 439);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 14;
            label6.Text = "Telefone:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 413);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 389);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 12;
            label7.Text = "Nome:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 463);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 23);
            textBox4.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 353);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 10;
            label8.Text = "Infos - Destinatario:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 489);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 16;
            label9.Text = "Endereço:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 513);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 15;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(23, 560);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(168, 54);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(35, 174);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(43, 23);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Sp";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(79, 174);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 23);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Mg";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(134, 174);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(42, 23);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Rs";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBoxRES
            // 
            textBoxRES.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRES.Location = new Point(232, 77);
            textBoxRES.Multiline = true;
            textBoxRES.Name = "textBoxRES";
            textBoxRES.ReadOnly = true;
            textBoxRES.Size = new Size(486, 171);
            textBoxRES.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 656);
            Controls.Add(textBoxRES);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnCalcular);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(checkBTerrestre);
            Controls.Add(checkBAreo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBAreo;
        private CheckBox checkBTerrestre;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Button btnCalcular;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox textBoxRES;
    }
}