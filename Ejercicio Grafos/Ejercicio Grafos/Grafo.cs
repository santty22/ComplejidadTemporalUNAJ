/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 10/10/2024
 * Hora: 00:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_Grafos
{
	public class Grafo<T>
	{
		public Grafo()
		{
		}
		
		private List<Vertice<T>>vertices = new List<Vertice<T>>();
	
		public void agregarVertice(Vertice<T> v) {
			v.setPosicion(vertices.Count + 1);
			vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v) {
			vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso) {
			origen.getAdyacentes().Add(new Arista<T>(destino,peso));
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}

	
		public List<Vertice<T>> getVertices() {
			return vertices;
		}

	
		public Vertice<T> vertice(int posicion) {
			return this.vertices[posicion];
		}
		
		
		public void DFS(Vertice<T> origen) {
			HashSet<Vertice<T>> visitados = new HashSet<Vertice<T>>();
			DFSRecursivo(origen, visitados);
		}
		public void DFSRecursivo(Vertice<T> actual, HashSet<Vertice<T>> visitados) {
			visitados.Add(actual);
			Console.WriteLine(actual.getDato()); //Imprimo el vertice visitado
			//Exploro los vertices adyacentes no visitados
			foreach (Arista<T> arista in actual.getAdyacentes()) {
				Vertice<T> destino = arista.getDestino();
				if (!visitados.Contains(destino)) {
					DFSRecursivo(destino, visitados);
				}
			}
		}
		
		public void BFS(Vertice<T> origen) {
			HashSet<Vertice<T>> visitados = new HashSet<Vertice<T>>();
			Queue<Vertice<T>> cola = new Queue<Vertice<T>>(); //Queue = Cola
			
			visitados.Add(origen);
			cola.Enqueue(origen); //Encolar
			
			while (cola.Count > 0) {
				Vertice<T> actual = cola.Dequeue();
				Console.WriteLine(actual.getDato()); //Imprimo el vertice actual
				
				//Exploro los vertices adyacentes no visitados
				foreach(Arista<T> arista in actual.getAdyacentes()) {
					Vertice<T> destino = arista.getDestino();
					if (!visitados.Contains(destino)) {
						visitados.Add(destino);
						cola.Enqueue(destino);
					}
				}
			}
		}
	}
}
