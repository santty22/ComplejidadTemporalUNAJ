/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 10/10/2024
 * Hora: 00:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_Grafos
{
	public class EjerciciosGrafos
	{
		
		public List <string> recorridoSeguroMaxFrutales (Grafo<string> bosque, string caperucita, string abuelita, int maxFrutales)
		{
			List<string> mejorCamino = new List<string>();
			int maxFrutalesEncontrados = 0;
			List<string> caminoActual = new List<string>();
			
			//HashSet para marcar los vértices visitados
			HashSet<Vertice<string>> visitados = new HashSet<Vertice<string>>();
			//Inicio el recorrido DFS desde la casa de Caperucita
			Vertice<string> origen = bosque.getVertices().Find(v => v.getDato().Equals(caperucita));
			//Llamada inicial al método DFS
			dfs(bosque, origen, abuelita, maxFrutales, 0, ref maxFrutalesEncontrados, caminoActual, mejorCamino, visitados);
			Console.WriteLine("La cantidad máxima de frutas encontradas es de {0}",maxFrutalesEncontrados);
			return mejorCamino;
		}
		private void dfs(Grafo<string> bosque, Vertice<string> actual, string abuelita, int maxFrutales, int frutalesAcumulados, ref int maxFrutalesEncontrados, List<string> caminoActual, List<string> mejorCamino, HashSet<Vertice<string>> visitados)
		{
			visitados.Add(actual);
			caminoActual.Add(actual.getDato());
			
			//Compruebo si llegué a la casa de la abuelita y si es el mejor camino
			if (actual.getDato().Equals(abuelita)) {
				if(frutalesAcumulados > maxFrutalesEncontrados) {
					maxFrutalesEncontrados = frutalesAcumulados;
					mejorCamino.Clear();
					mejorCamino.AddRange(caminoActual); //Copio el camino actual al mejor camino
				}
			}
			else {
				//Explorar las aristas adyacentes
				foreach (Arista<string> arista in actual.getAdyacentes()) {
					Vertice<string> destino = arista.getDestino();
					int frutalesEnCamino = arista.getPeso();
					
					//Continúo si el destino no fue visitado y si es seguro
					if (!visitados.Contains(destino) && frutalesEnCamino <= maxFrutales) {
						//Llamo recursivamente para continuar el camino
						dfs(bosque, destino, abuelita, maxFrutales, frutalesAcumulados + frutalesEnCamino, ref maxFrutalesEncontrados, caminoActual, mejorCamino, visitados);
					}
				}
			}
			//Deshago el último movimiento si no puedo seguir adelante (backtracking)
			visitados.Remove(actual);
			caminoActual.RemoveAt(caminoActual.Count - 1);
		}
	}
}
