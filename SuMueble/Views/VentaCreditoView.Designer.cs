﻿
namespace SuMueble.Views
{
    partial class VentaCreditoView
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_referencias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregarReferencia = new System.Windows.Forms.Button();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_dniColaborador = new System.Windows.Forms.TextBox();
            this.dniColaboradorLabelError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_monto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelClienteNuevo = new System.Windows.Forms.Label();
            this.l_NombreCliente = new System.Windows.Forms.Label();
            this.l_TelefonoCliente = new System.Windows.Forms.Label();
            this.l_RTNCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefonoCliente.Location = new System.Drawing.Point(536, 143);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoCliente.MaxLength = 8;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.PlaceholderText = "Escriba Aqui...";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(196, 29);
            this.txtTelefonoCliente.TabIndex = 34;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(536, 58);
            this.txt_nombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreCliente.MaxLength = 255;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(285, 29);
            this.txt_nombreCliente.TabIndex = 33;
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(307, 58);
            this.txt_dniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(196, 29);
            this.txt_dniCliente.TabIndex = 32;
            this.txt_dniCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniCliente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(536, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Telefono Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(534, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(302, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "DNI Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(307, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "RTN Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(307, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Registro Tributario Nacional...";
            this.textBox1.Size = new System.Drawing.Size(196, 29);
            this.textBox1.TabIndex = 32;
            // 
            // lb_referencias
            // 
            this.lb_referencias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_referencias.FormattingEnabled = true;
            this.lb_referencias.ItemHeight = 21;
            this.lb_referencias.Location = new System.Drawing.Point(308, 221);
            this.lb_referencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_referencias.Name = "lb_referencias";
            this.lb_referencias.Size = new System.Drawing.Size(449, 256);
            this.lb_referencias.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(304, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Referencias del Cliente";
            // 
            // btn_agregarReferencia
            // 
            this.btn_agregarReferencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarReferencia.FlatAppearance.BorderSize = 0;
            this.btn_agregarReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarReferencia.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarReferencia.ForeColor = System.Drawing.Color.White;
            this.btn_agregarReferencia.Location = new System.Drawing.Point(307, 489);
            this.btn_agregarReferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregarReferencia.Name = "btn_agregarReferencia";
            this.btn_agregarReferencia.Size = new System.Drawing.Size(167, 28);
            this.btn_agregarReferencia.TabIndex = 36;
            this.btn_agregarReferencia.Text = "Agregar Referencia";
            this.btn_agregarReferencia.UseVisualStyleBackColor = false;
            this.btn_agregarReferencia.Click += new System.EventHandler(this.btn_agregarReferencia_Click);
            // 
            // lb_productosVenta
            // 
            this.lb_productosVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_productosVenta.FormattingEnabled = true;
            this.lb_productosVenta.ItemHeight = 21;
            this.lb_productosVenta.Location = new System.Drawing.Point(1029, 218);
            this.lb_productosVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_productosVenta.Name = "lb_productosVenta";
            this.lb_productosVenta.Size = new System.Drawing.Size(449, 256);
            this.lb_productosVenta.TabIndex = 37;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(1029, 489);
            this.btn_agregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(167, 28);
            this.btn_agregarProducto.TabIndex = 36;
            this.btn_agregarProducto.Text = "Agregar Productos";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // txt_dniColaborador
            // 
            this.txt_dniColaborador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniColaborador.Location = new System.Drawing.Point(1283, 58);
            this.txt_dniColaborador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dniColaborador.MaxLength = 13;
            this.txt_dniColaborador.Name = "txt_dniColaborador";
            this.txt_dniColaborador.PlaceholderText = "Numero de Identidad...";
            this.txt_dniColaborador.Size = new System.Drawing.Size(196, 29);
            this.txt_dniColaborador.TabIndex = 40;
            // 
            // dniColaboradorLabelError
            // 
            this.dniColaboradorLabelError.AutoSize = true;
            this.dniColaboradorLabelError.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniColaboradorLabelError.ForeColor = System.Drawing.Color.Crimson;
            this.dniColaboradorLabelError.Location = new System.Drawing.Point(1283, 86);
            this.dniColaboradorLabelError.Name = "dniColaboradorLabelError";
            this.dniColaboradorLabelError.Size = new System.Drawing.Size(103, 15);
            this.dniColaboradorLabelError.TabIndex = 39;
            this.dniColaboradorLabelError.Text = "Escribio mal su DNI";
            this.dniColaboradorLabelError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1276, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "DNI Colaborador";
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1334, 182);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(136, 25);
            this.l_monto.TabIndex = 42;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1029, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Resumen Venta";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(208)))), ((int)(((byte)(88)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1311, 489);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Terminar Venta";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelClienteNuevo
            // 
            this.labelClienteNuevo.AutoSize = true;
            this.labelClienteNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClienteNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelClienteNuevo.Location = new System.Drawing.Point(307, 89);
            this.labelClienteNuevo.Name = "labelClienteNuevo";
            this.labelClienteNuevo.Size = new System.Drawing.Size(76, 15);
            this.labelClienteNuevo.TabIndex = 43;
            this.labelClienteNuevo.Text = "Cliente Nuevo";
            this.labelClienteNuevo.Visible = false;
            // 
            // l_NombreCliente
            // 
            this.l_NombreCliente.AutoSize = true;
            this.l_NombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_NombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_NombreCliente.Location = new System.Drawing.Point(536, 89);
            this.l_NombreCliente.Name = "l_NombreCliente";
            this.l_NombreCliente.Size = new System.Drawing.Size(55, 15);
            this.l_NombreCliente.TabIndex = 44;
            this.l_NombreCliente.Text = "Ingresar...";
            this.l_NombreCliente.Visible = false;
            // 
            // l_TelefonoCliente
            // 
            this.l_TelefonoCliente.AutoSize = true;
            this.l_TelefonoCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_TelefonoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_TelefonoCliente.Location = new System.Drawing.Point(536, 174);
            this.l_TelefonoCliente.Name = "l_TelefonoCliente";
            this.l_TelefonoCliente.Size = new System.Drawing.Size(55, 15);
            this.l_TelefonoCliente.TabIndex = 45;
            this.l_TelefonoCliente.Text = "Ingresar...";
            this.l_TelefonoCliente.Visible = false;
            // 
            // l_RTNCliente
            // 
            this.l_RTNCliente.AutoSize = true;
            this.l_RTNCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_RTNCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.l_RTNCliente.Location = new System.Drawing.Point(307, 174);
            this.l_RTNCliente.Name = "l_RTNCliente";
            this.l_RTNCliente.Size = new System.Drawing.Size(55, 15);
            this.l_RTNCliente.TabIndex = 46;
            this.l_RTNCliente.Text = "Ingresar...";
            this.l_RTNCliente.Visible = false;
            // 
            // VentaCreditoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_RTNCliente);
            this.Controls.Add(this.l_TelefonoCliente);
            this.Controls.Add(this.l_NombreCliente);
            this.Controls.Add(this.labelClienteNuevo);
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dniColaborador);
            this.Controls.Add(this.dniColaboradorLabelError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.btn_agregarReferencia);
            this.Controls.Add(this.lb_referencias);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentaCreditoView";
            this.Size = new System.Drawing.Size(1584, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lb_referencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregarReferencia;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_dniColaborador;
        private System.Windows.Forms.Label dniColaboradorLabelError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelClienteNuevo;
        private System.Windows.Forms.Label l_NombreCliente;
        private System.Windows.Forms.Label l_TelefonoCliente;
        private System.Windows.Forms.Label l_RTNCliente;
    }
}
