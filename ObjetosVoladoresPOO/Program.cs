using System;

namespace BancoApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("POO");
            //instanciamos cliente
            Cliente cliente = new Cliente(
                "JOSE ALONSO",
                "LOPEZ ROMO",
                new DateTime(1979, 03, 10) ,
                BancoEnum.SANTANDER);

            Console.WriteLine("Cliente creado "+cliente); //cliente.ToString()

     

            ////nombre , apellido, fecha_Nacimiento, cuenta

            if(cliente.rfc == "LORA")
                Console.WriteLine($"Si es correcto {cliente.rfc}");
            else
                Console.WriteLine($"NO ESTA CORRECTO {cliente.rfc}");


            if (cliente.edad >= 18 && cliente.cuenta == BancoEnum.BANAMEX)
            {
                //bloque verdadero
                r.Next(2, 9);
            }
            else if (cliente.edad >= 65 && cliente.cuenta == BancoEnum.BINANCE)
            {
                //bloque alternativo (2da condicion)
            }
            else
            {
                //bloque false
            }
           

            Console.WriteLine("Presione un a tecla para finalizar");
            Console.ReadKey();
        }
    }
}