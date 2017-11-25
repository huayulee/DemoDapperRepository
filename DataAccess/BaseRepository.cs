using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class BaseRepository
    {
        protected PaymentAsiaPayDBContext DB = new PaymentAsiaPayDBContext("Server=DESKTOP-QT1HILT\\SQLEXPRESS;Database=School;Trusted_Connection=True;");

    }
}
