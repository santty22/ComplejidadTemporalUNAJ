/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 10/10/2024
 * Hora: 00:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Ejercicio_Grafos
{
	public class Vertice<T>
	{
		public Vertice()
		{
		}
		
		private List<Arista<T>> adyacentes; 
    
		private T dato;
    
		private int posicion;
	
	    public Vertice(T d){
			dato = d;
			adyacentes = new List<Arista<T>>();
			
		}
    
		public T getDato() {
			return dato;
		}

		public void setDato(T unDato) {
			dato = unDato;
		}

		
		public int getPosicion() {
			return posicion;
		}
	
		public List<Arista<T>> getAdyacentes(){
			return adyacentes;
		}
	
		
		public void setPosicion(int pos){
			posicion = pos; 
		}
		
		
	}
}
