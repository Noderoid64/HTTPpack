using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    public class AcceptValue : IParseable
    {
        public AcceptParam param { get; set; }
        public MediaRange range { get; set; }

        public AcceptValue(AcceptParam param)
        {
            this.param = param;
        }
        public byte[] GetBytes(Encoding encoder)
        {
            return param.GetBytes(encoder).Concat(range.GetBytes(encoder)).ToArray();
        }

        public string GetString()
        {
            return param.GetString() + range.GetString();
        }
    }
}
