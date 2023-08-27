/*
 * Created by SharpDevelop.
 * User: gutie
 * Date: 26/08/2023
 * Time: 06:26 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace Programa_con_manejo_de_errores
{
	
	//clase para la excepcion
	public class MiExcepcionPersonalizada : Exception
	{
	    public MiExcepcionPersonalizada(string mensaje) : base(mensaje)
	    {
	        // Constructor para tu excepción personalizada
	    }
	}

	
	
	
	class Program
	{
			
		public static void Main(string[] args)
		{
			int num=0;
			int divisor=0;
			int result=0;
			
			Console.WriteLine("Ingresa un numero: ");
			num=Convert.ToInt32(Console.ReadLine());//leer teclado
			Console.WriteLine("Ingresa el numero por el cual se dividira: ");
			divisor=Convert.ToInt32(Console.ReadLine());//leer divisor
			
			try{
				
				result=num/divisor;//hacemos una division (en caso de ingresar 0 dara error)
				Console.WriteLine("El resultado es: "+result.ToString());
			}
			catch{
				Console.WriteLine("Error al momento de realizar la operacion");
			}
			
			Thread.Sleep(2000);
			Console.Clear();
			
			//uso de throw
			if(divisor==0){
				throw new MiExcepcionPersonalizada("Error al momento de realizar la operacion");//llamamos a la excepcion
			}
			else{
				result=num/divisor;
				Console.WriteLine("El rsultado es: "+result.ToString());
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}