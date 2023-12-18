﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Julekortbanken
{
    internal class XmasCard
    {
        public string ToName {  get; set; }
        public string FromName { get; set; }
        public string Greeting { get; set; }

        public XmasCard(string toName, string fromName, string greeting)
        {
            ToName = toName;
            FromName = fromName;
            Greeting = greeting;
        }
    }
}