using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.Http.Model
{
    public class HttpHeaderField  : IParseable
    {
        public string Name { get; private set; }
        private List<AcceptValue> Values { get; set; }

        public HttpHeaderField(string name, IEnumerable<AcceptValue> values)
        {
            Name = name;
            Values.AddRange(values);
        }
        public HttpHeaderField(string name, AcceptValue value)
        {
            Name = name;
            Values.Add(value);
        }

        public AcceptValue GetValue(int index)
        {
            if(index >= Values.Count)
            {
                throw new Exception("HttpHeaderField.Values.Count must be less than index");
            }
            else
            {
                return Values[index];
            }
        }
        public void AddValue(AcceptValue value)
        {
            Values.Add(value);
        }
        public void RemoveValue(int index)
        {
                Values.Remove(GetValue(index));
        }

        public byte[] GetBytes(Encoding encoder)
        {
            byte[] FieldBytes = encoder.GetBytes(Name = ": ").Concat(Values[0].GetBytes(encoder)).ToArray();
            for (int i = 1; i < Values.Count; i++)
            {
                FieldBytes = FieldBytes.Concat( encoder.GetBytes(", ").Concat(Values[i].GetBytes(encoder)).ToArray()).ToArray();
            }
            return FieldBytes;
        }

        public string GetString()
        {
            string FieldString = Name + ": " + Values[0].GetString();
            for (int i = 1; i < Values.Count; i++)
            {
                FieldString += ", " + Values[0].GetString();
            }
            return FieldString;
        }
    }
}
