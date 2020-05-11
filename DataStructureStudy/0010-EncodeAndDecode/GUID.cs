using System;
using System.Collections.Generic;

namespace EncodeAndDecode
{
    public class GUID
    {
        public Dictionary<string, string> dict = new Dictionary<string, string>();

        public string EncodeToGuid(string unencoded)
        {
            string guid = Guid.NewGuid().ToString();
            dict.Add(guid, unencoded);
            return guid;
        }

        public string DecodeFromGuid(string encoded)
        {
            string str = string.Empty;

            // if Get the value then, pass the value to str
            // else return null
            return dict.TryGetValue(encoded, out str) ? str : null;
        }
    }
}
