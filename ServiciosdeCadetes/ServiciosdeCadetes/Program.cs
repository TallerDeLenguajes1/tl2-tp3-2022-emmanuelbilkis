using ServiciosdeCadetes;

namespace principal
{
    class program
    {
        static void Main(string[] args)
        {
            Cliente Nicolas = new Cliente(1, "Nicolas", "Saavedra Lamas 952", "4535345", "Casi Pte Peron");

            Pedido pedido1 = new Pedido(1, "fsdfds", "en proceso", Nicolas, 2500);
            Pedido pedido2 = new Pedido(2, "fsdfds", "en proceso", Nicolas, 1500);
            Pedido pedido3 = new Pedido(3, "fsdfds", "en proceso", Nicolas, 800);
            Pedido pedido4 = new Pedido(4, "fsdfds", "en proceso", Nicolas, 1200);



            List<Pedido> listaPedidos = new List<Pedido>();
            listaPedidos.Add(pedido1);
            listaPedidos.Add(pedido2);
            listaPedidos.Add(pedido3);
            listaPedidos.Add(pedido4);

            Cadete Lautaro = new Cadete(1, "Lautaro", "Saavedra Lamas 952", "4535345", listaPedidos);

            pedido1.asignarCadete(Lautaro);
            pedido2.asignarCadete(Lautaro);
            pedido3.asignarCadete(Lautaro);
            pedido4.asignarCadete(Lautaro);

            foreach (var item in listaPedidos)
            {
                item.mostrarCadete();
            }

            Console.WriteLine($"El jornal a cobrar es: {Lautaro.jornalACobrar()}");

        }


    }
}

