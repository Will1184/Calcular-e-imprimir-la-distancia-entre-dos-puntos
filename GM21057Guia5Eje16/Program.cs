/*
 * Creado por SharpDevelop.
 * Usuario: BRANDON
 * Fecha: 20/3/2022
 * Hora: 18:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
// Guía:5
// Ejercicio:16
// Fecha: 21/3/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GM21057Guia5Eje16
{
	//Descripcion del programa:
	/*Dados 2 puntos en el plano cartesiano, calcular e imprimir la distancia entre ambos puntos, 
    la pendiente de la recta dada por ambos puntos, el área del rectángulo imaginario dentro del cual está la recta
    y cuál es el área del triángulo imaginario, dado que la recta es la hipotenusa.*/

	class Program
	{
		public static void Main(string[] args)
		{
	    //Identificacion del programa en pantalla
		Console.Title=("Dados 2 puntos en el plano cartesiano, calcular e imprimir la distancia entre ambos puntos, la pendiente de la recta, el area del rectangulo y el area del triangulo ");
		Console.WriteLine("Dados 2 puntos en el plano cartesiano, calcular e imprimir la distancia entre ambos puntos, la pendiente de la recta,el area del rectangulo y el area del triangulo  ");
		Console.WriteLine("Autor:Brandon Gomez");
	    
	    
		//DECLARACION DE VARIABLES
	    double x1,x2,y1,y2,calculaDistancia,calculaPendiente,areaTriangulo,areaRectangulo;
	    
		//ENTRADA DE DATOS
		Console.Write("Ingrese punto x1: ");x1= double.Parse(Console.ReadLine());
		Console.Write("Ingrese punto y1: "); y1= double.Parse(Console.ReadLine());
		Console.Write("Ingrese punto x2: "); x2= double.Parse(Console.ReadLine());
		Console.Write("Ingrese punto y2: "); y2= double.Parse(Console.ReadLine());
		
		calculaDistancia=leeCalculaDistancia(x1,x2,y1,y2);
		calculaPendiente=leeCalculaPendiente(x1,x2,y1,y2);
		areaTriangulo=leeAreaDeTriangulo(x1,x2,y1,y2);
		areaRectangulo=leeAreaDeRectangulo(x1,x2,y1,y2);
		
		
		//SALIDA DE DATOS
		
		Console.WriteLine("La distancia entre los puntos {0},{1} y {2},{3} es: {4: ##.##} ",x1,y1,x2,y2,calculaDistancia);
		Console.WriteLine("La pendiente es:{0}",calculaPendiente);
		Console.WriteLine("El area del Triangulo es: {0}u²",areaTriangulo);
		Console.WriteLine("El area del Rectangulo es: {0}u²",areaRectangulo);
		Console.ReadKey(true);
		
		}
		
		/// <summary>
		/// Calcular la distancia entre dos puntos
		/// </summary>
		/// <param name="x1"></param>
		/// <param name="x2"></param>
		/// <param name="y1"></param>
		/// <param name="y2"></param>
		/// <returns></returns>
		static double leeCalculaDistancia(double x1,double x2,double y1, double y2)
		{
	    //PROCESO DE DATOS
	    //Formula de la distancia entre dos puntos de un plano: d=√((x_2-x_1)²+(y_2-y_1)²)
		double distancia;
		distancia= Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
		return distancia;	
		}

		/// <summary>
		/// Calcular la pendiente entre dos puntos
		/// </summary>
		/// <param name="x1"></param>
		/// <param name="x2"></param>
		/// <param name="y1"></param>
		/// <param name="y2"></param>
		/// <returns></returns>
	    static double leeCalculaPendiente(double x1,double x2,double y1, double y2)
	    {
	    //Formula de la pendiente entre dos puntos de un plano: m=y2-y1/x2-x1
	    //m= Pendiente
	    double m;
	    m=(y2-y1)/(x2-x1);
	    return m;    
	    }	  
	    
	    /// <summary>
	    /// Hallar el area de un triangulo
	    /// </summary>
	    /// <param name="x1"></param>
	    /// <param name="x2"></param>
	    /// <param name="y1"></param>
	    /// <param name="y2"></param>
	    /// <returns></returns>
	    static double leeAreaDeTriangulo(double x1, double x2,double y1, double y2)
	    {
	    //PROCESO DE DATOS
	    //Formula para hallar el area de un triangulo es: a=b*h/2
	    double areaTriangulo,bas,altura;
	    bas=x1-x2;
	    altura=y2-y1;
	    areaTriangulo=(bas*altura)/2;
	    return areaTriangulo;
	    }
	    
	    /// <summary>
	    /// Hallar el area de un rectangulo
	    /// </summary>
	    /// <param name="x1"></param>
	    /// <param name="x2"></param>
	    /// <param name="y1"></param>
	    /// <param name="y2"></param>
	    /// <returns></returns>
	    static double leeAreaDeRectangulo(double x1, double x2, double y1, double y2)
	    {
	    //PROCESO DE DATOS
	    //Formula para hallar el area de un rectangulo es:a=b*h
     	double areaRectangulo,x3,y3,x4,y4,bas,altura;
     	x3=x1; y4=y1;
        x4=x2; y3=y2;
     	bas= x1-x2;
     	altura= y2-y1;
     	areaRectangulo= bas*altura;
     	
     	Console.WriteLine("--------------------------------------------------------------------------");
     	Console.WriteLine("El primer punto del recta es: {0},{1}; El segundo punto de la recta es : {2},{3} ",x1,y1,x2,y2);
     	Console.WriteLine("el tercer punto del recta es: {0},{1}; El cuarto punto de la recta: {2},{3} ",x3,y3,x4,y4);
     	return areaRectangulo;
	    }
	
	}
}