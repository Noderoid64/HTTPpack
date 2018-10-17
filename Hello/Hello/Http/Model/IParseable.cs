using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    interface IParseable
    {
        byte[] GetBytes(Encoding encoder);
        string GetString();
    }
}
