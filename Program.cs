using Email_Classifier;
using System;

namespace EmailClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailClassifier classifier = new EmailClassifier();
            Console.WriteLine(classifier.ClassifyEmail("I shared your email"));
            Console.WriteLine(classifier.ClassifyEmail("Can I share your email address"));
            Console.WriteLine(classifier.ClassifyEmail("This email is not related to sharing"));
            Console.ReadLine();
        }
    }
}
