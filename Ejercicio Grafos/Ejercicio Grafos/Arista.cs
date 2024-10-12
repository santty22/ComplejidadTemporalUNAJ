/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 10/10/2024
 * Hora: 00:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_Grafos
{
	public class Arista<T>
	{
		private Vertice<T> destino;
		private int peso;
	
		public Arista(Vertice<T> dest, int p){
				destino = dest;
				peso = p;
		}
		
		public Vertice<T> getDestino() {
			return destino;
		}
		
		public int getPeso() {
			return peso;
		}
		
		public void setDestino(Vertice<T> destino) {
			this.destino= destino;
		}
		
		public void setPeso(int peso) {
			this.peso = peso;
		}
	
	}
}
