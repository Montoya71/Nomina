namespace Proyecto_2
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblSueldo_Inicial = new System.Windows.Forms.Label();
            this.txtTotal_Inicial = new System.Windows.Forms.TextBox();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSueldo_Final = new System.Windows.Forms.Label();
            this.txtSueldo_Final = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del trabajador:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(251, 94);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(111, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Numero de empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(368, 91);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(26, 136);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(83, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias trabajados:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(108, 132);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(215, 136);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(94, 13);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Sueldo por hora: $";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(305, 132);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Impuestos";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(495, 114);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblSueldo_Inicial
            // 
            this.lblSueldo_Inicial.AutoSize = true;
            this.lblSueldo_Inicial.Location = new System.Drawing.Point(418, 184);
            this.lblSueldo_Inicial.Name = "lblSueldo_Inicial";
            this.lblSueldo_Inicial.Size = new System.Drawing.Size(81, 13);
            this.lblSueldo_Inicial.TabIndex = 10;
            this.lblSueldo_Inicial.Text = "Sueldo inicial: $";
            // 
            // txtTotal_Inicial
            // 
            this.txtTotal_Inicial.Location = new System.Drawing.Point(495, 180);
            this.txtTotal_Inicial.Name = "txtTotal_Inicial";
            this.txtTotal_Inicial.Size = new System.Drawing.Size(100, 20);
            this.txtTotal_Inicial.TabIndex = 11;
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Location = new System.Drawing.Point(319, 315);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(37, 13);
            this.lblISR.TabIndex = 12;
            this.lblISR.Text = "ISR: $";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(46, 314);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(99, 13);
            this.lblSocial.TabIndex = 13;
            this.lblSocial.Text = "Seguridad Social: $";
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Location = new System.Drawing.Point(303, 275);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(111, 13);
            this.lblRetiro.TabIndex = 14;
            this.lblRetiro.Text = "Ahorro para el retiro: $";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(48, 275);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(63, 13);
            this.lblPrestamo.TabIndex = 15;
            this.lblPrestamo.Text = "Prestamo: $";
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(353, 311);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(100, 20);
            this.txtISR.TabIndex = 16;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(142, 311);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 17;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(411, 271);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtRetiro.TabIndex = 18;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(108, 272);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtPrestamo.TabIndex = 19;
            this.txtPrestamo.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sin Impuestos*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(212, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nomina de Trabajo";
            // 
            // lblSueldo_Final
            // 
            this.lblSueldo_Final.AutoSize = true;
            this.lblSueldo_Final.Location = new System.Drawing.Point(420, 373);
            this.lblSueldo_Final.Name = "lblSueldo_Final";
            this.lblSueldo_Final.Size = new System.Drawing.Size(77, 13);
            this.lblSueldo_Final.TabIndex = 22;
            this.lblSueldo_Final.Text = "Sueldo Final: $";
            // 
            // txtSueldo_Final
            // 
            this.txtSueldo_Final.Location = new System.Drawing.Point(494, 370);
            this.txtSueldo_Final.Name = "txtSueldo_Final";
            this.txtSueldo_Final.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo_Final.TabIndex = 23;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(239, 351);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 24;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "%23";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "%10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "%5";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(607, 10);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtSueldo_Final);
            this.Controls.Add(this.lblSueldo_Final);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.txtRetiro);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.txtTotal_Inicial);
            this.Controls.Add(this.lblSueldo_Inicial);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblSueldo_Inicial;
        private System.Windows.Forms.TextBox txtTotal_Inicial;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSueldo_Final;
        private System.Windows.Forms.TextBox txtSueldo_Final;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

