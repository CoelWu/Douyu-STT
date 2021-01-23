using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Douyu.STT
{
    public class STT
    {
        List<KeyValuePair<string, string>> data;

        public STT()
        {
            data = new List<KeyValuePair<string, string>>();
        }

        public STT(string value) : this()
        {
            Deserialize(value);
        }

        public STT(byte[] value) : this()
        {
            Deserialize(Encoding.UTF8.GetString(value));
        }

        public string Get(string key)
        {
            return data.FirstOrDefault(p => p.Key == key).Value;
        }

        public void Set(string key, string value)
        {
            int index = data.FindIndex(p => p.Key == key);
            if (index != -1)
            {
                KeyValuePair<string, string> newValue = new KeyValuePair<string, string>(key, value);
                data[index] = newValue;
            }
        }

        public void Add(string key, string value)
        {
            data.Add(new KeyValuePair<string, string>(key, value));
        }

        public string Serialize()
        {
            string result = "";
            foreach (var item in data)
            {
                result += item.Key.ConvertTo() + "@=" + item.Value.ConvertTo() + "/";
            }
            return result;
        }

        public List<KeyValuePair<string, string>> Deserialize(string rawMsg)
        {

            var list = rawMsg.Split('/');
            foreach (var msg in list)
            {
                var temp = msg;
                if (string.IsNullOrWhiteSpace(msg))
                {
                    continue;
                }
                var pair = temp.Split("@=".ToCharArray());
                if (pair.Length == 2)
                {
                    Add(pair[0].ConvertBy(), pair[1].ConvertBy());
                }
            }
            return data;
        }

        public override string ToString()
        {
            return Serialize();
        }
    }
}
