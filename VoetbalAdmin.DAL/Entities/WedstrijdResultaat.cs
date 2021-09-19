using System;
using System.Collections.Generic;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class WedstrijdResultaat
    {
        public int WedstrijdResultaatId { get; set; }
        public int WedstrijdId { get; set; }
        public Wedstrijd Wedstrijd { get; set; }
        public int ScoreThuis { get; set; }
        public int ScoreUit { get; set; }
    }
}
