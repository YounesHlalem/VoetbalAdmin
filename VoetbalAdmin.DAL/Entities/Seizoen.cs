using System;
using System.Collections.Generic;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class Seizoen
    {
        public int SeizoenId { get; set; }
        public string Naam { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime Einddatum { get; set; }
        public bool IsActief { get; set; }
    }
}
