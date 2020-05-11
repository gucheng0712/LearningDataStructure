using System;
using System.Collections.Generic;
using System.Text;

namespace EncodeAndDecode
{
    /// <summary>
    /// Question: Design the encode and decode methods. 
    /// There is no restriction on how your encode/decode algorithm should work. 
    /// You just need to ensure that a string can be encoded to a a code 
    /// and the code can be decoded to the original URL.
    /// </summary>
    class MainClass
    {
        public static Dictionary<string, string> dict = new Dictionary<string, string>();

        public static void Main(string[] args)
        {
            #region BASE 64
            Base64 base64 = new Base64();
            string eCode_Base64 = base64.EncodeToBase64("1000");
            Console.WriteLine("(BASE 64)Encode 1000 to: " + eCode_Base64);
            string dCode_Base64 = base64.DecodeFromBase64(eCode_Base64);
            Console.WriteLine("(BASE 64)Decode " + eCode_Base64 + " to: " + dCode_Base64);
            #endregion

            #region GUID
            GUID guid = new GUID();
            string eCode_Guid = guid.EncodeToGuid("1000");
            Console.WriteLine("(GUID)Encode 1000 to: " + eCode_Guid);
            string dCode_Guid = guid.DecodeFromGuid(eCode_Guid);
            Console.WriteLine("(GUID)Decode " + eCode_Guid + " to: " + dCode_Guid);
            #endregion 
        }




    }
}
