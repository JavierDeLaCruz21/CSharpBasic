namespace Myfirstapp.Operaciones
{
    public class CalcularSumayProducto
    {

        //Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.

        public void SumarNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;

            Console.WriteLine("Digite el num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);

            Console.WriteLine($"El resultado es: {suma}");

            Console.ReadLine();
        }

        public void MultiplicarNumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int multiplicar = 0;

            Console.WriteLine("Digite el num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            multiplicar = (num1 * num2);

            Console.WriteLine($"El resultado es: {multiplicar}");

            Console.ReadLine();
        }

    }
}