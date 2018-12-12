using System;
using System.Collections.Generic;
using System.Text;

namespace UniqueEmailAddresses
{
    public class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> emailSet = new HashSet<string>();

            foreach (var email in emails)
            {
                emailSet.Add(GetEmail(email));
            }

            // Because HashSet will not add the duplicate element into the list so the count is the count of different emails
            return emailSet.Count;

        }

        string GetEmail(string email)
        {
            StringBuilder sb = new StringBuilder();
            int index = email.IndexOf('@'); // because only need to compare the string before "@"
            for (int i = 0; i < index; i++)
            {
                if (email.Substring(i, 1) == ".") continue; // when the element is ".", Ignore it 
                if (email.Substring(i, 1) == "+") break; // when the element is "+", Ignore the rest element
                sb.Append(email.Substring(i, 1)); // if is not in above situation, add the element into the string
            }

            sb.Append(email.Substring(index)); // append the elements after '@' (include '@')
            return sb.ToString();
        }
    }
}