﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Gladiator.UpdateViewModel
{
    public class UpdatePurchaseViewModel
    {
        public int plan_id { get; set; }
        public int detail_id { get; set; }
        public DateTime DOP { get; set; }
        public DateTime end_date { get; set; }
        public int status { get; set; }
    }
}
