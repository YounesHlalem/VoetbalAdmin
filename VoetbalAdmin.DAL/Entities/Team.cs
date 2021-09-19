using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Naam { get; set; }
        public DateTime Einddatum { get; set; }
    }
}
