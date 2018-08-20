using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    public class EncodeDecode
    {

        /// <summary>
        /// Encodes and Decodes to base64.
        /// </summary>
        /// <returns>The to base64.</returns>
        public string EncodeToBase64(string unencoded)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(unencoded));
        }

        public string DecodeFromBase64(string encoded)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encoded));
        }

        //-------------------------------------------------------------//

        /// <summary>
        /// Encodes and Decodes to GUID.
        /// </summary>
        /// <returns>The to GUID.</returns>
        public static Dictionary<string, string> dict = new Dictionary<string, string>();

        public string EncodeToGuid(string unencoded)
        {
            string guid = Guid.NewGuid().ToString();
            dict.Add(guid, unencoded);
            return guid;
        }

        public string DecodeToGuid(string encoded)
        {
            string str = string.Empty;

            // if Get the value then, pass the value to str
            // else return null
            return dict.TryGetValue(encoded, out str) ? str : null;
        }
    }
}
