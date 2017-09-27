using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain
{
   public enum ConnectionTypes : byte
    {
        MSSQL = 0,
        MySQL = 1,
        Oracle = 2,
    }

    public enum AuthTypes : byte
    {
        WindowsAuthentication = 0,
        SQLServerAuthentication = 1,
    }
}