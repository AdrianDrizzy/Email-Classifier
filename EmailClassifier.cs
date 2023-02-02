using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Classifier
{
    public class EmailClassifier
    {
        public string ClassifyEmail(string email)
        {
            string[] sharedKeywords = new string[] { "shared", "sent", "given", "distributed" };
            string[] permissionKeywords = new string[] { "can", "may", "might", "could" };
            foreach (var keyword in sharedKeywords)
            {
                if (email.Contains(keyword))
                {
                    return "Student has shared";
                }
            }
            foreach (var keyword in permissionKeywords)
            {
                if (email.Contains(keyword))
                {
                    return "Student wants to know if can share";
                }
            }
            return "Unclassified";
        }
    }
}
