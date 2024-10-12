/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 10/10/2024
 * Hora: 00:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_Grafos
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Creo el grafo
			Grafo<string> bosque = new Grafo<string>();
			//Creo los vertices
			Vertice<string> caperucita = new Vertice<string>("Casa de Caperucita");
			Vertice<string> claro1 = new Vertice<string>("Claro 1");
			Vertice<string> claro2 = new Vertice<string>("Claro 2");
			Vertice<string> claro3 = new Vertice<string>("Claro 3");
			Vertice<string> claro4 = new Vertice<string>("Claro 4");
			Vertice<string> claro5 = new Vertice<string>("Claro 5");
			Vertice<string> claro6 = new Vertice<string>("Claro 6");
			Vertice<string> abuelita = new Vertice<string>("Casa de la Abuelita");
			//Agrego los vértices al grafo
			bosque.agregarVertice(caperucita);
			bosque.agregarVertice(claro1);
			bosque.agregarVertice(claro2);
			bosque.agregarVertice(claro3);
			bosque.agregarVertice(claro4);
			bosque.agregarVertice(claro5);
			bosque.agregarVertice(claro6);
			bosque.agregarVertice(abuelita);
			//Conecto los vértices con la cantidad de frutales por arista
			bosque.conectar(caperucita, claro1, 10);
			bosque.conectar(caperucita, claro2, 15);
			bosque.conectar(caperucita, claro3, 20);
			bosque.conectar(caperucita, claro4, 8);
			bosque.conectar(claro1, claro3, 5);
			bosque.conectar(claro2, claro4, 38);
			bosque.conectar(claro2, claro6, 30);
			bosque.conectar(claro3, claro5, 3);
			bosque.conectar(claro4, claro6, 45);
			bosque.conectar(claro5, claro6, 7);
			bosque.conectar(claro5, abuelita, 35);
			bosque.conectar(claro6, abuelita, 15);
			//Creo la instancia y ejecuto el método
			EjerciciosGrafos ejercicio = new EjerciciosGrafos();
			List<string> mejorCamino = ejercicio.recorridoSeguroMaxFrutales(bosque, "Casa de Caperucita", "Casa de la Abuelita", 30);
			Console.WriteLine("El mejor camino es:");
			foreach(string lugar in mejorCamino){
				Console.WriteLine(lugar);
			}
			Console.ReadKey(true);
		}
	}
}