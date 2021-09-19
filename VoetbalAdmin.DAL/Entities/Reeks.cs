using System;
using System.Collections.Generic;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class Reeks
    {
        public int ReeksId { get; set; }
        public string Naam { get; set; }
        public int SeizoenId { get; set; }
        public Seizoen Seizoen { get; set; }

    }
}
