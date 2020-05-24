using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz
{
    public abstract class Domain
    {

        public abstract string domainName { get; }
        public abstract void Questions();
        public abstract string getQuestion(int i);
        public abstract string getAnswer(int i, int j);
        public abstract int getQuestionNumber { get; }
    }
}
