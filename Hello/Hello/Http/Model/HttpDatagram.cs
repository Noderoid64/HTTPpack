﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    public abstract class HttpDatagram : IParseable
    {
        public HttpVersion Version { get; protected set; }
        public HttpHeader header { get; set; }
        public HttpBody body { get; set; }

        public HttpDatagram(HttpVersion version)
        {
            Version = version;
        }

        public abstract bool isValidStart();
        public abstract bool isRequest();

        public abstract byte[] GetBytes(Encoding encoder);

        public abstract string GetString();
    }
}
