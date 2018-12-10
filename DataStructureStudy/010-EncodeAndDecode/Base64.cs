using System;
using System.Text;

namespace EncodeAndDecode
{
    public class Base64
    {
        // Encodes to base64.
        public string EncodeToBase64(string unencoded)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(unencoded));
        }

        //Decode from base64
        public string DecodeFromBase64(string encoded)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encoded));
        }
    }
}
