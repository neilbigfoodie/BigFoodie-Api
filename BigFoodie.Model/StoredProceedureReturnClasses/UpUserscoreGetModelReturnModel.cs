﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class UpUserscoreGetModelReturnModel
    {
        public System.Int32 sid { get; set; }
        public System.Int32? uid { get; set; }
        public System.DateTime? scoretime { get; set; }
        public System.String operateuser { get; set; }
        public System.Int32? score { get; set; }
        public System.String operation { get; set; }
        public System.String scoretype { get; set; }
        public System.String description { get; set; }
    }
}
