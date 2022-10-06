using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsolaPila
{
    internal class Pila
    {
        private int tope,maxpila;
        private int[] contenedorpila;
        public Pila(int maxpila)
        {
            this.tope = -1;
            this.maxpila = maxpila;
            this.contenedorpila = new int[maxpila];
        }
        public bool Pilavacia()
        {
            if (this.tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Pilallena()
        {
            if (this.tope == maxpila - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ApilarPila(int dato)
        {
            if (this.Pilallena() == false)
            {
                this.tope++;
                this.contenedorpila[tope] = dato;
                Console.WriteLine("\tSE APILO EL ELEMENTO "+this.contenedorpila[tope] + "EN LA PILA");
            }
            else
            {
                Console.WriteLine("\tLA PILA ESTA LLENA");
            }
        }
        public void DesapilarPila()
        {
            if (this.Pilavacia() == false)
            {
                Console.WriteLine("\tSE DASAPILO EL ELEMENTO " + this.contenedorpila[tope]+" DE LA PILA ");
                this.contenedorpila[tope] = 0;
                this.tope--;
            }
            else
            {
                Console.WriteLine("\tLA PILA ESTA VACIA");
            }
        }
        public void ListarPila()
        {
            if(this.Pilavacia() == false)
            {
                for (int i = tope; i >=0; i--)
                {
                    Console.WriteLine("[" + i + "] => " + this.contenedorpila[i]);
                }
            }
            else
            {
                Console.WriteLine("\tLA PILA ESTA VACIA");
            }
        }


    }
}
