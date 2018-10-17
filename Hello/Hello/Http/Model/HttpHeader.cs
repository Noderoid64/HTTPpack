using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using Hello.Http.Headers;

namespace Hello.Http.Model
{
    public class HttpHeader : IParseable
    {
        public List<HttpHeaderField> Fields { get; private set; }

        public HttpHeader()
        {
            Fields = new List<HttpHeaderField>();
        }

        public void SetField(HttpHeaderField field)
        {
            
        }
        public void GetField(string name)
        {

        }

        public byte[] GetBytes(Encoding encoder)
        {
            throw new NotImplementedException();
        }

        public string GetString()
        {
            throw new NotImplementedException();
        }
    }


}
