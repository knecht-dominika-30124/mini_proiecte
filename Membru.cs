using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym
{
    
        internal class Membru
        {
            public int Id { get; set; }
            public string Nume { get; set; }
            public string Telefon { get; set; }
            public string TipAbonament { get; set; }
            public DateTime DataInceput { get; set; }
            public DateTime DataExpirare { get; set; }
            public bool Activ { get; set; }
            public string Status { get; set; }
        }
}


