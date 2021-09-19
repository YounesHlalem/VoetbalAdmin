using System;

namespace VoetbalAdmin.DataContracts.DTO
{
    public class TeamDTO
    {
        public int TeamId { get; set; }
        public string Naam { get; set; }
        public DateTime Einddatum { get; set; }
    }
}
