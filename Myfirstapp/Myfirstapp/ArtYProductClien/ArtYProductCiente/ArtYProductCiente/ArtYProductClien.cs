namespace ArtYProductCiente
{
    public class ArtYProductClien
    {
        //Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
       //Mostrar lo que debe abonar el comprador.
        public void ArtYProClien()
        {
            decimal precioArticulo = 0;
            int cantidadOrdenada = 0;
            decimal abonoFacturas = 0;

            try
            {
                Console.WriteLine("Digite el precio del articulo: ");
                precioArticulo = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Cuantos productos desea ordernar?");
                cantidadOrdenada = Convert.ToInt32(Console.ReadLine());

                abonoFacturas = precioArticulo * cantidadOrdenada;

                Console.WriteLine($"Debe de abonar {abonoFacturas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error {ex.Message}");
            }
        }
    }
}


