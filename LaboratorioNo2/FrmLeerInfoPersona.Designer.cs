namespace LaboratorioNo2
{
    partial class FrmLeerInfoPersona
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeerInfoPersona));
            this.lbCalculadoraSalarioNeto = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbSalarioBrutoMensual = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbSalarioBrutoMensual = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.pEncabezado = new System.Windows.Forms.Panel();
            this.lbLaboratorio2 = new System.Windows.Forms.Label();
            this.pEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCalculadoraSalarioNeto
            // 
            this.lbCalculadoraSalarioNeto.AutoSize = true;
            this.lbCalculadoraSalarioNeto.BackColor = System.Drawing.Color.Transparent;
            this.lbCalculadoraSalarioNeto.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculadoraSalarioNeto.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCalculadoraSalarioNeto.Location = new System.Drawing.Point(27, 45);
            this.lbCalculadoraSalarioNeto.Name = "lbCalculadoraSalarioNeto";
            this.lbCalculadoraSalarioNeto.Size = new System.Drawing.Size(628, 37);
            this.lbCalculadoraSalarioNeto.TabIndex = 0;
            this.lbCalculadoraSalarioNeto.Text = "CALCULADORA DE IMPUESTO SOBRE LA RENTA";
            this.lbCalculadoraSalarioNeto.Click += new System.EventHandler(this.lbCalculadoraSalarioNeto_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombre.Location = new System.Drawing.Point(90, 164);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(79, 24);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lbApellido.Location = new System.Drawing.Point(377, 164);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(80, 24);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido";
            this.lbApellido.Click += new System.EventHandler(this.lbApellido_Click);
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.BackColor = System.Drawing.Color.Transparent;
            this.lbCedula.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCedula.Location = new System.Drawing.Point(90, 273);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(68, 24);
            this.lbCedula.TabIndex = 3;
            this.lbCedula.Text = "Cédula";
            this.lbCedula.Click += new System.EventHandler(this.lbCedula_Click);
            // 
            // lbSalarioBrutoMensual
            // 
            this.lbSalarioBrutoMensual.AutoSize = true;
            this.lbSalarioBrutoMensual.BackColor = System.Drawing.Color.Transparent;
            this.lbSalarioBrutoMensual.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioBrutoMensual.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSalarioBrutoMensual.Location = new System.Drawing.Point(377, 273);
            this.lbSalarioBrutoMensual.Name = "lbSalarioBrutoMensual";
            this.lbSalarioBrutoMensual.Size = new System.Drawing.Size(196, 24);
            this.lbSalarioBrutoMensual.TabIndex = 4;
            this.lbSalarioBrutoMensual.Text = "Salario Bruto Mensual";
            this.lbSalarioBrutoMensual.Click += new System.EventHandler(this.lbSalarioBrutoMensual_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(94, 191);
            this.tbNombre.MaxLength = 20;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(192, 32);
            this.tbNombre.TabIndex = 5;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(381, 191);
            this.tbApellido.MaxLength = 20;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(192, 32);
            this.tbApellido.TabIndex = 6;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.ForeColor = System.Drawing.Color.Gray;
            this.tbCedula.Location = new System.Drawing.Point(94, 300);
            this.tbCedula.MaxLength = 12;
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(192, 32);
            this.tbCedula.TabIndex = 7;
            this.tbCedula.Text = "00-0000-0000";
            this.tbCedula.TextChanged += new System.EventHandler(this.tbCedula_TextChanged);
            this.tbCedula.Enter += new System.EventHandler(this.tbCedula_Enter);
            this.tbCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCedula_KeyPress);
            this.tbCedula.Leave += new System.EventHandler(this.tbCedula_Leave);
            // 
            // tbSalarioBrutoMensual
            // 
            this.tbSalarioBrutoMensual.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarioBrutoMensual.ForeColor = System.Drawing.Color.Gray;
            this.tbSalarioBrutoMensual.Location = new System.Drawing.Point(381, 300);
            this.tbSalarioBrutoMensual.MaxLength = 10;
            this.tbSalarioBrutoMensual.Name = "tbSalarioBrutoMensual";
            this.tbSalarioBrutoMensual.Size = new System.Drawing.Size(192, 32);
            this.tbSalarioBrutoMensual.TabIndex = 8;
            this.tbSalarioBrutoMensual.Text = "999.999,99";
            this.tbSalarioBrutoMensual.TextChanged += new System.EventHandler(this.tbSalarioBrutoMensual_TextChanged);
            this.tbSalarioBrutoMensual.Enter += new System.EventHandler(this.tbSalarioBrutoMensual_Enter);
            this.tbSalarioBrutoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalarioBrutoMensual_KeyPress);
            this.tbSalarioBrutoMensual.Leave += new System.EventHandler(this.tbSalarioBrutoMensual_Leave);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Green;
            this.btCalcular.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.White;
            this.btCalcular.Location = new System.Drawing.Point(94, 411);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(479, 51);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // pEncabezado
            // 
            this.pEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.pEncabezado.Controls.Add(this.lbLaboratorio2);
            this.pEncabezado.Controls.Add(this.lbCalculadoraSalarioNeto);
            this.pEncabezado.Location = new System.Drawing.Point(-5, -4);
            this.pEncabezado.Name = "pEncabezado";
            this.pEncabezado.Size = new System.Drawing.Size(679, 115);
            this.pEncabezado.TabIndex = 10;
            // 
            // lbLaboratorio2
            // 
            this.lbLaboratorio2.AutoSize = true;
            this.lbLaboratorio2.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLaboratorio2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLaboratorio2.Location = new System.Drawing.Point(17, 13);
            this.lbLaboratorio2.Name = "lbLaboratorio2";
            this.lbLaboratorio2.Size = new System.Drawing.Size(95, 17);
            this.lbLaboratorio2.TabIndex = 1;
            this.lbLaboratorio2.Text = "LABORATORIO 2";
            // 
            // FrmLeerInfoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(104)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(674, 499);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbSalarioBrutoMensual);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbSalarioBrutoMensual);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pEncabezado);
            this.Name = "FrmLeerInfoPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LABORATORIO 2";
            this.Load += new System.EventHandler(this.FrmIeerInfoEmpleado_Load);
            this.pEncabezado.ResumeLayout(false);
            this.pEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCalculadoraSalarioNeto;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbSalarioBrutoMensual;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbSalarioBrutoMensual;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Panel pEncabezado;
        private System.Windows.Forms.Label lbLaboratorio2;
    }
}

