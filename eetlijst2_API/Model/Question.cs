﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public int StudenthouseId { get; set; }
        public string Question1 { get; set; }
        public string Answer { get; set; }

        public virtual Studenthouse Studenthouse { get; set; }
    }
}
