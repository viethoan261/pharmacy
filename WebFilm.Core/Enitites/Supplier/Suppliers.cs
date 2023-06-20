﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFilm.Core.Enitites.Supplier
{
    public class Suppliers : BaseEntity
    {
        public string name { get; set; }

        public string? address { get; set; }

        public string phone { get; set; }

        public string status { get; set; } = "ACTIVE";
    }
}
