using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    class HttpRequestDatagram : HttpDatagram
    {

        public HttpMethods Method { get; private set; }
        public string Uri { get; private set; }

        public HttpRequestDatagram(HttpMethods method, string uri, HttpVersion version) : base(version)
        {
            this.Method = method;
            this.Uri = uri;
        }

        public override bool isRequest()
        {
            return true;
        }

        public override bool isValidStart()
        {
            throw new NotImplementedException();
        }

        public override byte[] GetBytes(Encoding encoder)
        {
            throw new NotImplementedException();
        }

        public override string GetString()
        {
            throw new NotImplementedException();
        }
    }
}
