﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Sage.Domain.Entities
{
    public class FamilleResponse
    {
        public string CodeFamille { get; set; }
        public string Intitule { get; set; }
        public string Central { get; set; }
        public string Unite { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
    }
}
