﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz
{
    abstract class QuizzFactory
    {
        public abstract Domain getDomain(string domain);

    }
}
