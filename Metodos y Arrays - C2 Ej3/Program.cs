using System;

namespace Metodos_y_Arrays___C2_Ej3
{
    class EsNumeroPrimo
    {
        public Boolean Esprimo(int numeroprimo)
        {
            Boolean primo = true;
            int i = numeroprimo;

            do
            {
                i = i-1;
                if(numeroprimo%i==0)
                {
                    primo = false;
                }
            } while ((i > 2) & (primo));
            return primo;
        }
        static void Main(string[] args)
        {
            int numero;
            EsNumeroPrimo posiblePrimo = new EsNumeroPrimo();
            Console.WriteLine("Introduce el numero para comprobar si es primo o no:");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(posiblePrimo.Esprimo(numero));

        }
    }
}
