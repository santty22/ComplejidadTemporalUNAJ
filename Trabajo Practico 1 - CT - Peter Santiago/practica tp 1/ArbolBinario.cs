/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 30/8/2024
 * Hora: 00:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_practico_1
{
	public class ArbolBinario<T>
	{
		private int dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
		
		public int Dato {
			get { return dato;}
			set { dato = value;}
		}
		public ArbolBinario<T> HijoIzquierdo {
			get { return hijoIzquierdo;}
			set { hijoIzquierdo = value;}
		}
		public ArbolBinario<T> HijoDerecho {
			get { return hijoDerecho;}
			set { hijoDerecho = value;}
		}
		
		public ArbolBinario(int dato) {
			Dato = dato;
			HijoIzquierdo = null;
			HijoDerecho = null;
		}
		
		// Métodos para agregar/eliminar hijos
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			hijoIzquierdo = hijo;
		}
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			hijoDerecho = hijo;
		}
		public void eliminarHijoIzquierdo(ArbolBinario<T> hijo) {
			hijoIzquierdo = null;
		}
		public void eliminarHijoDerecho(ArbolBinario<T> hijo) {
			hijoDerecho = null;
		}
		
		// Verificar si el nodo es hoja
		public bool esHoja() {
			return hijoIzquierdo == null && hijoDerecho == null;
		}
		
		// Método para imprimir el árbol en preorden
		public void ImprimirPreorden()
		{
			Console.WriteLine(Dato);
			if (HijoIzquierdo!=null) {
				HijoIzquierdo.ImprimirPreorden();
			}
			if (HijoDerecho!=null) {
				HijoDerecho.ImprimirPreorden();
			}
		}
		
		public ArbolBinario<int> NuevoArbol(ArbolBinario<int> arbol)
		{
			// Si hay un hijo izquierdo, sumo el valor del padre con el hijo izquierdo
			if (arbol.HijoIzquierdo != null) {
				int nuevoDatoIzquierdo = arbol.Dato + arbol.HijoIzquierdo.Dato;
				NuevoArbol(arbol.HijoIzquierdo);
				arbol.HijoIzquierdo.Dato = nuevoDatoIzquierdo;
			}
			
			// El hijo derecho del nuevo árbol es igual al del árbol original
			if (arbol.HijoDerecho != null) {
				NuevoArbol(arbol.HijoDerecho);
			}
			return arbol;
		}
	}
}
