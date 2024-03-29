﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Studenthouse
    {
        public Studenthouse()
        {
            AccountActivaty = new HashSet<AccountActivaty>();
            Activaty = new HashSet<Activaty>();
            Credits = new HashSet<Credits>();
            Question = new HashSet<Question>();
        }

        public int StudenthouseId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountActivaty> AccountActivaty { get; set; }
        public virtual ICollection<Activaty> Activaty { get; set; }
        public virtual ICollection<Credits> Credits { get; set; }
        public virtual ICollection<Question> Question { get; set; }
    }
}
