/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 28/8/2024
 * Hora: 21:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_practico_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Números del ejercicio
			ArbolBinario<int> arbol = new ArbolBinario<int>(1);
			arbol.agregarHijoIzquierdo(new ArbolBinario<int>(2));
			arbol.agregarHijoDerecho(new ArbolBinario<int>(3));
			arbol.HijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(4));
			arbol.HijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(5));
			arbol.HijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(6));
			arbol.HijoDerecho.HijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(7));
			
			Console.WriteLine("Árbol Original (Preorden):");
			arbol.ImprimirPreorden();
			
			ArbolBinario<int> nuevoArbol = arbol.NuevoArbol(arbol);
			
			Console.WriteLine("Nuevo Árbol (Preorden):");
			nuevoArbol.ImprimirPreorden();
			
			Console.ReadKey(true);
		}
	}
}