using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEF2022.Context;

namespace AutoEF2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AutoDbContext())
            {
                var lista = context.Autos.ToList();
                foreach (var auto in lista)
                {
                    Console.WriteLine($"{auto.TipoDeAuto}{auto.Modelo}");
                }
            }

            Console.ReadLine();
        }
    }
}
