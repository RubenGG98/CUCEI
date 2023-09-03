/*
 * Created by SharpDevelop.
 * User: gutie
 * Date: 02/09/2023
 * Time: 05:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Programa_Recuperable
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button_registrar = new System.Windows.Forms.Button();
			this.textBox_nombre = new System.Windows.Forms.TextBox();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.textBox_carrera = new System.Windows.Forms.TextBox();
			this.textBox_contraseña = new System.Windows.Forms.TextBox();
			this.textBox_universidad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_registrar
			// 
			this.button_registrar.Location = new System.Drawing.Point(226, 240);
			this.button_registrar.Name = "button_registrar";
			this.button_registrar.Size = new System.Drawing.Size(103, 39);
			this.button_registrar.TabIndex = 0;
			this.button_registrar.Text = "REGISTRAR";
			this.button_registrar.UseVisualStyleBackColor = true;
			this.button_registrar.Click += new System.EventHandler(this.Button_registrarClick);
			// 
			// textBox_nombre
			// 
			this.textBox_nombre.Location = new System.Drawing.Point(166, 78);
			this.textBox_nombre.Name = "textBox_nombre";
			this.textBox_nombre.Size = new System.Drawing.Size(243, 20);
			this.textBox_nombre.TabIndex = 1;
			// 
			// textBox_codigo
			// 
			this.textBox_codigo.Location = new System.Drawing.Point(166, 116);
			this.textBox_codigo.Name = "textBox_codigo";
			this.textBox_codigo.Size = new System.Drawing.Size(243, 20);
			this.textBox_codigo.TabIndex = 2;
			// 
			// textBox_carrera
			// 
			this.textBox_carrera.Location = new System.Drawing.Point(166, 143);
			this.textBox_carrera.Name = "textBox_carrera";
			this.textBox_carrera.Size = new System.Drawing.Size(243, 20);
			this.textBox_carrera.TabIndex = 3;
			// 
			// textBox_contraseña
			// 
			this.textBox_contraseña.Location = new System.Drawing.Point(166, 172);
			this.textBox_contraseña.Name = "textBox_contraseña";
			this.textBox_contraseña.Size = new System.Drawing.Size(243, 20);
			this.textBox_contraseña.TabIndex = 4;
			this.textBox_contraseña.UseSystemPasswordChar = true;
			// 
			// textBox_universidad
			// 
			this.textBox_universidad.Location = new System.Drawing.Point(166, 198);
			this.textBox_universidad.Name = "textBox_universidad";
			this.textBox_universidad.Size = new System.Drawing.Size(243, 20);
			this.textBox_universidad.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "NOMBRE";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "CODIGO";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(56, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "CARRERA";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(56, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "CONTRASEÑA";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(56, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "UNIVERSIDAD";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.OrangeRed;
			this.label6.Location = new System.Drawing.Point(205, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "NUEVO USUARIO";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 309);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_universidad);
			this.Controls.Add(this.textBox_contraseña);
			this.Controls.Add(this.textBox_carrera);
			this.Controls.Add(this.textBox_codigo);
			this.Controls.Add(this.textBox_nombre);
			this.Controls.Add(this.button_registrar);
			this.Name = "MainForm";
			this.Text = "Programa_Recuperable";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_universidad;
		private System.Windows.Forms.TextBox textBox_contraseña;
		private System.Windows.Forms.TextBox textBox_carrera;
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.TextBox textBox_nombre;
		private System.Windows.Forms.Button button_registrar;
	}
}
