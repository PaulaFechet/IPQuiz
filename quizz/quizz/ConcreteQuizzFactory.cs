
using System;


namespace quizz
{
    class ConcreteQuizzFactory : QuizzFactory
    {
        public override Domain getDomain(string domain)
        {
            switch (domain)
            {
                case "it":
                    return new IT();
                case "chimie":
                    return new Chemistry();
                default:
                    throw new ApplicationException(string.Format("Domain '{0}' could not be created", domain));
            }
        }
    }
}
