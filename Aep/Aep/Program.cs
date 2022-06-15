using Aep.Metodos;
using Aep.Profiles;
using System;

class Program
{
    static List<Usuario> Usuarios = new List<Usuario>();
    static List<Lavanderia> lavanderias = new List<Lavanderia>();
    static List<Pedido> pedidos = new List<Pedido>();
    static Funcoes funcoes = new Funcoes();

    static void Main()
    {
        Usuarios.Add(new Usuario("123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123"));
        lavanderias.Add(new Lavanderia("12345678910112", "lavaderia da toca", "999123329",
            "maringa", "PR", "marechal floriano", "zona 7", "1473", "apt 34"));
        lavanderias.Add(new Lavanderia("52385738910112", "lavaderia da cesu", "998754329",
            "maringa", "PR", "colombo", "jardim ipiranga", "1853", "casa"));
        lavanderias[0].SetPrecos(5, 6, 4, 3, 10);
        lavanderias[1].SetPrecos(5, 6, 3, 2, 10);
        bool run = true;
        funcoes.Login(Usuarios);
        while(run)
        {
            Console.Clear();
            int count = 0;
            foreach(Lavanderia lavanderia in lavanderias)
            {
                count++;
                Console.Write(count + " - ");
                funcoes.MostrarLavanderia(lavanderia);
            }
            Console.WriteLine(count + 1 + " - Ver pedidos"); 
            Console.WriteLine(count + 2 + " - Sair");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    funcoes.FazerPedido(pedidos, "12345678910112", "123");
                    break;
                case '2':
                    funcoes.FazerPedido(pedidos, "52385738910112", "123");
                    break;
                case '3':
                    if(pedidos.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Ainda não tem pedidos cadastrados");
                        Console.ReadKey();
                    }
                    else
                    {
                        funcoes.VerPedidos(pedidos);
                        Console.ReadKey();
                    }
                    break;
                case '4':
                    run = false;
                    break;
            }



        }

    }
}

