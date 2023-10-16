namespace EDD
{
    internal class Pila
    {
        /*
         * Esta clase tiene como objetivo simular una estructura de datos conocida como Pila, 
         * que opera bajo el principio "Último en Entrar, Primero en Salir" (LIFO). 
         * Esta característica implica que los elementos se almacenan y recuperan en un orden específico, 
         * donde el último elemento agregado es el primero en ser retirado. 
         * La dimensión de esta pila es estática, lo que significa que su longitud no varía durante su uso. 
         * Además, es importante destacar que la Pila solo acepta datos de tipo "char" como elementos a ser empujados.
         */

        //Propiedad que contiene los elementos de la pila.
        public char[] Array { get; set; }

        //Constructor que establece la longitud de la pila.
        public Pila(int length) { Array = new char[length]; }

        /*
         * Metodo que inserta un nuevo elemento en la parte superior de la pila.
         * Para ello, desplaza cada elemento actual a una posición superior,
         * permitiendo que el valor pasado como argumento se almacene en la posición 0.
         * Ejemplo de codigo
         * MyPila.Array -> {'4','3','2','1','\0'}
         * MyPila.Push('5') -> {'5','4','3','2','1'} 
         */
        public void Push(char character)
        {
            if (EstaFull())
                Console.WriteLine($"No se pueden empujar el elemento {character} a la pila, utilice el miembro Pop() para liberar espacio");
            else
            {
                for (int i = Array.Length - 1; i >= 1; i--)
                    Array[i] = Array[i - 1];
                Array[0] = character;
            }
        }

        /*
         * Metodo que devuelve el ultimo elemento en entrar y en este mismo proceso
         * es removido de la pila.
         * Ejemplo de codigo
         * MyPila.Array -> {'5','4','3','2','1'} 
         * var ultimoElemento = MyPila.Pop() -> {'4','3','2','1','\0'} 
         */
        public char Pop()
        {
            if (EstaVacia())
                return '\0';
            else
            {
                var top = Array[0];
                for (int i = 0; i < Array.Length - 1; i++)
                    Array[i] = Array[i + 1];
                Array[Array.Length - 1] = '\0';
                return top;
            }
        }

        //Metodo que indica si la pila está vacía
        public bool EstaVacia() => Array[0] == '\0';

        //Metodo que indica si la pila está llena
        public bool EstaFull() => !Array[Array.Length - 1].Equals('\0');

        //Metodo que imprime en consola cada uno de los elementos de la pila
        public void ImprimirPila()
        {
            if (EstaVacia())
                Console.WriteLine("No es posible imprimir los elementos (Pila vacía)");
            else
            {
                Console.WriteLine("Imprimiendo los elementos de la pila");
                foreach (var character in Array)
                    Console.WriteLine(character);
            }

        }

        //Destructor que indica al final del tiempo de ejecución el autor de dicha clase.
        ~Pila()
        {
            Console.WriteLine("Autor de la clase Pila -> Fernando José Canto Cetina ISIC G1");
        }
    }
}
