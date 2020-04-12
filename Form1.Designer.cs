namespace WindowsFormsApp2
    {
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valormedido = new System.Windows.Forms.TextBox();
            this.valorbom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoMedido = new System.Windows.Forms.ComboBox();
            this.TipoBom = new System.Windows.Forms.ComboBox();
            this.tolerancia = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.Testar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Minimo = new System.Windows.Forms.Label();
            this.Maximo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacitores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Medido";
            // 
            // valormedido
            // 
            this.valormedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valormedido.Location = new System.Drawing.Point(16, 46);
            this.valormedido.Name = "valormedido";
            this.valormedido.Size = new System.Drawing.Size(79, 20);
            this.valormedido.TabIndex = 2;
            this.valormedido.Text = "0";
            this.valormedido.TextChanged += new System.EventHandler(this.valormedido_TextChanged);
            // 
            // valorbom
            // 
            this.valorbom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorbom.Location = new System.Drawing.Point(16, 85);
            this.valorbom.Name = "valorbom";
            this.valorbom.Size = new System.Drawing.Size(79, 20);
            this.valorbom.TabIndex = 4;
            this.valorbom.Text = "0";
            this.valorbom.TextChanged += new System.EventHandler(this.valorbom_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor Bom";
            // 
            // TipoMedido
            // 
            this.TipoMedido.DisplayMember = "uF";
            this.TipoMedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoMedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMedido.FormattingEnabled = true;
            this.TipoMedido.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.TipoMedido.Location = new System.Drawing.Point(111, 45);
            this.TipoMedido.Name = "TipoMedido";
            this.TipoMedido.Size = new System.Drawing.Size(61, 21);
            this.TipoMedido.TabIndex = 5;
            // 
            // TipoBom
            // 
            this.TipoBom.DisplayMember = "uF";
            this.TipoBom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoBom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoBom.FormattingEnabled = true;
            this.TipoBom.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.TipoBom.Location = new System.Drawing.Point(111, 84);
            this.TipoBom.Name = "TipoBom";
            this.TipoBom.Size = new System.Drawing.Size(61, 21);
            this.TipoBom.TabIndex = 6;
            // 
            // tolerancia
            // 
            this.tolerancia.DisplayMember = "20";
            this.tolerancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolerancia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tolerancia.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.tolerancia.Location = new System.Drawing.Point(196, 57);
            this.tolerancia.Name = "tolerancia";
            this.tolerancia.Size = new System.Drawing.Size(76, 21);
            this.tolerancia.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(109, 9);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(144, 17);
            this.Status.TabIndex = 8;
            this.Status.Text = "Esperando valores";
            // 
            // Testar
            // 
            this.Testar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testar.Location = new System.Drawing.Point(21, 221);
            this.Testar.Name = "Testar";
            this.Testar.Size = new System.Drawing.Size(75, 23);
            this.Testar.TabIndex = 9;
            this.Testar.Text = "Testar";
            this.Testar.UseVisualStyleBackColor = true;
            this.Testar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor Minimo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor Maximo";
            // 
            // Minimo
            // 
            this.Minimo.AutoSize = true;
            this.Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimo.Location = new System.Drawing.Point(13, 155);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(13, 13);
            this.Minimo.TabIndex = 12;
            this.Minimo.Text = "0";
            // 
            // Maximo
            // 
            this.Maximo.AutoSize = true;
            this.Maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximo.Location = new System.Drawing.Point(108, 155);
            this.Maximo.Name = "Maximo";
            this.Maximo.Size = new System.Drawing.Size(13, 13);
            this.Maximo.TabIndex = 13;
            this.Maximo.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(172, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(172, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tolerancia";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Maximo);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Testar);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.tolerancia);
            this.Controls.Add(this.TipoBom);
            this.Controls.Add(this.TipoMedido);
            this.Controls.Add(this.valorbom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valormedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testar Componentes";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valormedido;
        private System.Windows.Forms.TextBox valorbom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoMedido;
        private System.Windows.Forms.ComboBox TipoBom;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Testar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Minimo;
        private System.Windows.Forms.Label Maximo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox tolerancia;
        private System.Windows.Forms.Label label1;
        }
    }

