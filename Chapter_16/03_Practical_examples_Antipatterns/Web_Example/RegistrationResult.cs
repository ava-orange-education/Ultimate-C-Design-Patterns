using System;

namespace Chapter_16._03_Practical_examples_Antipatterns.Web_Example
{
    public class RegistrationResult
    {
        public object ErrorMessage { get; internal set; }

        internal static RegistrationResult Failure(string v)
        {
            throw new NotImplementedException();
        }

        public static RegistrationResult Success()
        {
            throw new NotImplementedException();
        }
    }
}