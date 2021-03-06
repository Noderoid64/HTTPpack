﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    public class HttpVersion : IParseable
    {
        public uint Major { get; private set; }
        public uint Minor { get; private set; }

        public HttpVersion(uint major, uint minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public byte[] GetBytes(Encoding encoder)
        {
            return encoder.GetBytes(GetString());
        }

        public string GetString()
        {
            return "HTTP/" + Major.ToString() + "." + Minor.ToString();
        }
    }
}
