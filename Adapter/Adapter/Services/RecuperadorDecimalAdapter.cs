using Adapter.Services.Interface;
using System;

namespace Adapter.Services
{
    public class RecuperadorDecimalAdapter : IRecuperadorTotalDecimal
    {
        private IRecuperadorEnteroCadena RecuperadorEntero;
        public RecuperadorDecimalAdapter(IRecuperadorEnteroCadena _recuperadorEntero)
        {
            RecuperadorEntero = _recuperadorEntero ?? throw new ArgumentNullException(nameof(_recuperadorEntero));
        }

        public decimal ObtenerDecimal()
        {
            string cEntero = RecuperadorEntero.RecuperarEntero();
            decimal dValor = 0;
            if (!decimal.TryParse(cEntero, out dValor))
                throw new Exception("No es posible convertir el número en decimal");
            return dValor;
        }
    }
}
