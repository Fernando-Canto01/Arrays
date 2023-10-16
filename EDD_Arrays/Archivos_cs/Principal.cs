namespace EDD
{
    internal class Principal
    {
        public static void Main(string[] args)
        {
            Cola queue = new Cola(2);
            queue.Encolar('a'); //Agrega el elemento 'a' a la Pila
            queue.Encolar('b'); //Agrega el elemento 'b' a la Pila
            Console.WriteLine($"Elemento retirado de la Cola {queue.Desencolar()}");
            queue.ImprimirStatus(); //Imprime los elementos de la Pila
        }
    }
}
