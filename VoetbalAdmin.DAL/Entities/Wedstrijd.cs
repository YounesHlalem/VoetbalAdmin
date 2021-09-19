using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class Wedstrijd
    {
        public int WedstrijdId { get; set; }
        public int TeamThuisId { get; set; }
        public Team TeamThuis { get; set; }
        public int TeamUitId { get; set; }
        public Team TeamUit { get; set; }
        public int ReeksId { get; set; }
        public Reeks Reeks { get; set; }
        public DateTime Wedstrijddatum { get; set; }
    }
}
