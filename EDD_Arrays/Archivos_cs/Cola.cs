namespace EDD
{
    internal class Cola
    {

        /*
         * Esta clase tiene como objetivo simular una estructura de datos conocida como cola, 
         * que opera bajo el principio "Primero en Entrar, Primero en Salir" (FIFO). 
         * Esta característica implica que los elementos se almacenan y recuperan en un orden específico, 
         * donde el primer elemento agregado es el primero en ser retirado. 
         * La dimensión de esta cola es estática, lo que significa que su longitud no varía durante su uso. 
         * Además, es importante destacar que la cola solo acepta datos de tipo "char" como elementos a ser encolados.
         */

        //Propiedad que contiene los elementos de la cola.
        public char[] Array { get; set; }

        //Constructor que establece la longitud de la cola.
        public Cola(int length) { Array = new char[length]; }

        /*
         * Metodo que encola un nuevo elemento en la primera aparición del índice que contenga '\0'.
         * Ejemplo de codigo
         * MyCola.Array -> {'\0','\0','\0','\0','\0'}
         * MyCola.Encolar('1') -> {'1','\0','\0','\0','\0'} 
         */
        public void Encolar(char character)
        {

            if (EstaLlena())
                Console.WriteLine($"No se pueden encolar el elemento {character}, utilice el miembro Desencolar() para liberar espacio");
            else
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Equals('\0'))
                    {
                        Array[i] = character;
                        break;
                    }
                }

            }

        }

        /*
         * Metodo que devuelve el primer elemento en entrar y en este mismo proceso
         * es removido de la cola.
         * Ejemplo de codigo
         * MyCola.Array -> {'1','2','3','4','5'}
         * var primerElemento = MyCola.Desencolar() -> {'2','3','4','5','\0'} 
         */
        public char Desencolar()
        {
            if (EstaVacia())
                return '\0';
            else
            {
                var top = Array[0];
                Array[0] = '\0';
                for (int i = 0; i < Array.Length - 1; i++)
                    Array[i] = Array[i + 1];
                Array[Array.Length - 1] = '\0';
                return top;
            }
        }

        //Metodo que indica si la cola está vacía.
        public bool EstaVacia() => Array[0] == '\0';

        //Metodo que indica si la cola está llena.
        public bool EstaLlena() => !Array[Array.Length - 1].Equals('\0');

        //Metodo que imprime cada uno de los elementos de la cola.
        public void ImprimirStatus()
        {
            if (EstaVacia())
                Console.WriteLine("No es posible imprimir los elementos (cola vacía)");
            else
            {
                Console.WriteLine("Imprimiendo todos los elementos de la cola");
                foreach (var character in Array)
                    Console.WriteLine(character);
            }
        }

        //Destructor que indica al final del tiempo de ejecución el autor de dicha clase.
        ~Cola()
        {
            Console.WriteLine("Autor de la clase Cola -> Fernando José Canto Cetina ISIC G1");
        }

    }
}
