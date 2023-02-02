using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Email_Classifier
{
    [TestClass]
    public class EmailClassifierTests
    {
        [TestMethod]
        public void TestClassifyEmail()
        {
            EmailClassifier classifier = new EmailClassifier();

            string email1 = "I shared your email";
            string email2 = "Can I share your email address";
            string email3 = "This email is not related to sharing";

            string result1 = classifier.ClassifyEmail(email1);
            string result2 = classifier.ClassifyEmail(email2);
            string result3 = classifier.ClassifyEmail(email3);

            Assert.AreEqual("Student has shared", result1);
            Assert.AreEqual("Student wants to know if can share", result2);
            Assert.AreEqual("Unclassified", result3);
        }
    }
}
