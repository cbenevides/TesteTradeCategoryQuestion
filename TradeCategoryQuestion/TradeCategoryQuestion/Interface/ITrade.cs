using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategoryQuestion.Interface
{
    public interface ITrade
    {
        double Value { get; set; }
        string ClientSector { get; set; }
        DateTime NextPaymentDate { get; set; }
    }
}
