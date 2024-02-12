namespace promedio_estidiante_ejer6
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
            btn_calcular = new Button();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_nota1 = new TextBox();
            txt_nota2 = new TextBox();
            txt_nota4 = new TextBox();
            txt_nota3 = new TextBox();
            txt_promedio = new TextBox();
            txt_situacion = new TextBox();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            btn_calcular.Location = new Point(327, 170);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(117, 41);
            btn_calcular.TabIndex = 0;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(327, 218);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(117, 44);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            btn_Salir.Location = new Point(327, 274);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(117, 44);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 43);
            label1.Name = "label1";
            label1.Size = new Size(315, 52);
            label1.TabIndex = 3;
            label1.Text = "Calcular Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 144);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 4;
            label2.Text = "Nota1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 197);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 5;
            label3.Text = "Nota2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            label4.Location = new Point(45, 251);
            label4.Name = "label4";
            label4.Size = new Size(79, 35);
            label4.TabIndex = 6;
            label4.Text = "Nota3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            label5.Location = new Point(42, 306);
            label5.Name = "label5";
            label5.Size = new Size(79, 35);
            label5.TabIndex = 7;
            label5.Text = "Nota4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 367);
            label6.Name = "label6";
            label6.Size = new Size(119, 35);
            label6.TabIndex = 8;
            label6.Text = "Promedio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 409);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 9;
            label7.Text = "Situacion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 396);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 10;
            // 
            // txt_nota1
            // 
            txt_nota1.Location = new Point(141, 146);
            txt_nota1.Name = "txt_nota1";
            txt_nota1.Size = new Size(100, 31);
            txt_nota1.TabIndex = 11;
            // 
            // txt_nota2
            // 
            txt_nota2.Location = new Point(141, 197);
            txt_nota2.Name = "txt_nota2";
            txt_nota2.Size = new Size(100, 31);
            txt_nota2.TabIndex = 12;
            // 
            // txt_nota4
            // 
            txt_nota4.Location = new Point(141, 321);
            txt_nota4.Name = "txt_nota4";
            txt_nota4.Size = new Size(100, 31);
            txt_nota4.TabIndex = 13;
            // 
            // txt_nota3
            // 
            txt_nota3.Location = new Point(141, 253);
            txt_nota3.Name = "txt_nota3";
            txt_nota3.Size = new Size(100, 31);
            txt_nota3.TabIndex = 14;
            // 
            // txt_promedio
            // 
            txt_promedio.Location = new Point(141, 375);
            txt_promedio.Name = "txt_promedio";
            txt_promedio.Size = new Size(100, 31);
            txt_promedio.TabIndex = 16;
            // 
            // txt_situacion
            // 
            txt_situacion.Location = new Point(359, 411);
            txt_situacion.Name = "txt_situacion";
            txt_situacion.Size = new Size(160, 31);
            txt_situacion.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(550, 460);
            Controls.Add(txt_situacion);
            Controls.Add(txt_promedio);
            Controls.Add(txt_nota3);
            Controls.Add(txt_nota4);
            Controls.Add(txt_nota2);
            Controls.Add(txt_nota1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_calcular);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_nota1;
        private TextBox txt_nota2;
        private TextBox txt_nota4;
        private TextBox txt_nota3;
        private TextBox txt_promedio;
        private TextBox txt_situacion;
    }
}
