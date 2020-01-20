using Adapter.Services;
using Adapter.Services.Interface;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DefinirColor();
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void InicializarAplicacion()
        {            
            IRecuperadorEnteroCadena RecuperadorEntero = new RecuperadorEnteroCadena();
            IRecuperadorTotalDecimal RecuperadorDecimal = new RecuperadorDecimalAdapter(RecuperadorEntero);
            string valor = RecuperadorDecimal.ObtenerDecimal().ToString();            
            Console.WriteLine(valor);            
        }

        static void DefinirColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
