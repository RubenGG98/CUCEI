/*
 * Created by SharpDevelop.
 * User: Gutierrez Galan Ruben Alejandro
 * codigo: 214798315
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading; 



namespace Programa_Recuperable
{
	public partial class MainForm : Form
	{
		private List<Alumno> listaAlumno=new List<Alumno>();//lista de alumnos creados.
		private string archivo_respaldo="respaldo.txt";//archivo de respaldo
		private System.Windows.Forms.Timer timer_respaldo;//temporizador de respaldo
		private System.Windows.Forms.Timer timer_error_cerrar;//temporizador para simular el cierre
		private System.Windows.Forms.Timer resourceMonitorTimer;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//cargar respaldo
			if(File.Exists(archivo_respaldo)){
				string[] lineas=File.ReadAllLines(archivo_respaldo);
				if(lineas.Length>=5){
					textBox_nombre.Text=lineas[0];
					textBox_codigo.Text=lineas[1];
					textBox_carrera.Text=lineas[2];
					textBox_contraseña.Text=lineas[3];
					textBox_universidad.Text=lineas[4];
				}
			}
			
			//temporizador para hacer autoguardados cada cierto tiempo (actual cada 2 segundos)
			timer_respaldo=new System.Windows.Forms.Timer();
			timer_respaldo.Interval=2000;//intervalo de 2 segundos
			timer_respaldo.Tick+= respaldo;
			timer_respaldo.Start();//iniciar el temporizador
			
			//temporizador para simular que el programa se ha cerrado
			timer_error_cerrar=new System.Windows.Forms.Timer();
			timer_error_cerrar.Interval=5000;//cierre a los 5 segundos
			timer_error_cerrar.Tick += simular_cierre;//evento de cierre
			timer_error_cerrar.Start();//iniciar temporizador
			
			resourceMonitorTimer = new System.Windows.Forms.Timer();
	        resourceMonitorTimer.Interval = 30000; // 30 segundos
	        resourceMonitorTimer.Tick += ResourceMonitorTimer_Tick;
	        resourceMonitorTimer.Start();
			
			
		}
		
		private void respaldo(object sender, EventArgs e){
			// Utilizar un hilo para realizar la escritura del archivo de respaldo
		    Thread respaldoThread = new Thread(() =>
		    {
		        File.WriteAllLines(archivo_respaldo, new string[] { textBox_nombre.Text, textBox_codigo.Text, textBox_carrera.Text, textBox_contraseña.Text, textBox_universidad.Text });
		    });
		
		    respaldoThread.Start();

		}
		
		private void simular_cierre(object sender, EventArgs e){
			// Utilizar un hilo para simular el cierre después de 5 segundos
		    Thread cierreThread = new Thread(() =>
		    {
		        Thread.Sleep(500000); // tiempo de espera para el cierre
		        this.Invoke(new Action(() => this.Close())); // Cerrar el formulario en el hilo principal
		    });
		
		    cierreThread.Start();
		}
		
		private void ResourceMonitorTimer_Tick(object sender, EventArgs e)
	    {
	        // Lógica de monitoreo de recursos
	        long memoryUsed = GC.GetTotalMemory(false); // Obtener la memoria utilizada
	        //MessageBox.Show(memoryUsed.ToString());
	        if (memoryUsed > 500000) // Si la memoria utilizada supera 1 GB
	        {
	            // Realiza acciones para liberar memoria o muestra una advertencia al usuario
	            MessageBox.Show("Uso de memoria alto. Realizando limpieza...");
	        }
	    }
		
		
		void Button_registrarClick(object sender, EventArgs e)
		{
			if(textBox_nombre.Text==""||textBox_codigo.Text==""||textBox_carrera.Text==""||textBox_contraseña.Text==""||textBox_universidad.Text==""){
				MessageBox.Show("Faltan campos por llenar");
			}
			else{
				//crear nuevo alumno
				try{
					Alumno alumn=new Alumno(textBox_nombre.Text,Convert.ToInt32(textBox_codigo.Text),textBox_carrera.Text,textBox_contraseña.Text,textBox_universidad.Text);
					listaAlumno.Add(alumn);
					
					//guardar
					File.WriteAllLines(archivo_respaldo, new string[] { textBox_nombre.Text, textBox_codigo.Text, textBox_carrera.Text, textBox_contraseña.Text, textBox_universidad.Text });
				}
				catch{
					MessageBox.Show("error al agregar al alumno!!!");
				}
				
				//limpiar campos
				textBox_nombre.Clear();
				textBox_codigo.Clear();
				textBox_carrera.Clear();
				textBox_contraseña.Clear();
				textBox_universidad.Clear();
			}
		}
	}
	
	public class Alumno{
			//atributos
			public string nombre;
			public int codigo;
			public string carrera;
			public string contraseña;
			public string universidad;
			
			//constructor
			public Alumno(string _nombre,int _codigo,string _carrera,string _contraseña,string _universidad){
				nombre=_nombre;
				codigo=_codigo;
				carrera=_carrera;
				contraseña=_contraseña;
				universidad=_universidad;
			}
			
			public override string ToString(){
				return "{nombre},{codigo},{carrera},{contraseña},{universidad}";
			}
			
		}
}
