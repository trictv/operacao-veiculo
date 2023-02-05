
namespace ciclo2ou3
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
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtConsumomedio = new System.Windows.Forms.TextBox();
            this.lblConsumomedio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRodar = new System.Windows.Forms.Button();
            this.txtQuilometros = new System.Windows.Forms.TextBox();
            this.lblQuilometros = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOdometro = new System.Windows.Forms.TextBox();
            this.lblOdometro = new System.Windows.Forms.Label();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlaca.Location = new System.Drawing.Point(22, 41);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(70, 23);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.txtConsumomedio);
            this.groupBox1.Controls.Add(this.lblConsumomedio);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição do Veículo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(383, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 23);
            this.textBox2.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(425, 41);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(205, 23);
            this.txtModelo.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(383, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(425, 20);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo";
            // 
            // txtConsumomedio
            // 
            this.txtConsumomedio.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsumomedio.Enabled = false;
            this.txtConsumomedio.Location = new System.Drawing.Point(214, 100);
            this.txtConsumomedio.Name = "txtConsumomedio";
            this.txtConsumomedio.Size = new System.Drawing.Size(205, 23);
            this.txtConsumomedio.TabIndex = 6;
            // 
            // lblConsumomedio
            // 
            this.lblConsumomedio.AutoSize = true;
            this.lblConsumomedio.Location = new System.Drawing.Point(214, 82);
            this.lblConsumomedio.Name = "lblConsumomedio";
            this.lblConsumomedio.Size = new System.Drawing.Size(96, 15);
            this.lblConsumomedio.TabIndex = 5;
            this.lblConsumomedio.Text = "Consumo Médio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(214, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(214, 41);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(205, 23);
            this.txtMarca.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(109, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(22, 23);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbastecer);
            this.groupBox2.Controls.Add(this.txtLitros);
            this.groupBox2.Controls.Add(this.lblLitros);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abastecimento";
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Enabled = false;
            this.btnAbastecer.Location = new System.Drawing.Point(214, 40);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(75, 23);
            this.btnAbastecer.TabIndex = 2;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = true;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.SystemColors.Window;
            this.txtLitros.Enabled = false;
            this.txtLitros.Location = new System.Drawing.Point(101, 40);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 23);
            this.txtLitros.TabIndex = 1;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(22, 43);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Litros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRodar);
            this.groupBox3.Controls.Add(this.txtQuilometros);
            this.groupBox3.Controls.Add(this.lblQuilometros);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rodagem";
            // 
            // btnRodar
            // 
            this.btnRodar.Enabled = false;
            this.btnRodar.Location = new System.Drawing.Point(208, 32);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(81, 23);
            this.btnRodar.TabIndex = 2;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // txtQuilometros
            // 
            this.txtQuilometros.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuilometros.Enabled = false;
            this.txtQuilometros.Location = new System.Drawing.Point(101, 32);
            this.txtQuilometros.Name = "txtQuilometros";
            this.txtQuilometros.Size = new System.Drawing.Size(100, 23);
            this.txtQuilometros.TabIndex = 1;
            // 
            // lblQuilometros
            // 
            this.lblQuilometros.AutoSize = true;
            this.lblQuilometros.Location = new System.Drawing.Point(22, 32);
            this.lblQuilometros.Name = "lblQuilometros";
            this.lblQuilometros.Size = new System.Drawing.Size(73, 15);
            this.lblQuilometros.TabIndex = 0;
            this.lblQuilometros.Text = "Quilômetros";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOdometro);
            this.groupBox4.Controls.Add(this.lblOdometro);
            this.groupBox4.Controls.Add(this.txtCombustivel);
            this.groupBox4.Controls.Add(this.lblCombustivel);
            this.groupBox4.Location = new System.Drawing.Point(375, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 202);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Marcadores";
            // 
            // txtOdometro
            // 
            this.txtOdometro.BackColor = System.Drawing.SystemColors.Control;
            this.txtOdometro.Enabled = false;
            this.txtOdometro.Location = new System.Drawing.Point(20, 139);
            this.txtOdometro.Name = "txtOdometro";
            this.txtOdometro.Size = new System.Drawing.Size(129, 23);
            this.txtOdometro.TabIndex = 3;
            // 
            // lblOdometro
            // 
            this.lblOdometro.AutoSize = true;
            this.lblOdometro.Location = new System.Drawing.Point(20, 106);
            this.lblOdometro.Name = "lblOdometro";
            this.lblOdometro.Size = new System.Drawing.Size(62, 15);
            this.lblOdometro.TabIndex = 2;
            this.lblOdometro.Text = "Odômetro";
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.BackColor = System.Drawing.SystemColors.Control;
            this.txtCombustivel.Enabled = false;
            this.txtCombustivel.Location = new System.Drawing.Point(20, 59);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(129, 23);
            this.txtCombustivel.TabIndex = 1;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(20, 40);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(74, 15);
            this.lblCombustivel.TabIndex = 0;
            this.lblCombustivel.Text = "Combustível";
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(579, 323);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 63);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 399);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Operacão do veiculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtConsumomedio;
        private System.Windows.Forms.Label lblConsumomedio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.TextBox txtQuilometros;
        private System.Windows.Forms.Label lblQuilometros;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOdometro;
        private System.Windows.Forms.Label lblOdometro;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

