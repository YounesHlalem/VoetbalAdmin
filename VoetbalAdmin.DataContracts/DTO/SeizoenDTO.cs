using System;

namespace VoetbalAdmin.DataContracts.DTO
{
    public class SeizoenDTO
    {
        public int SeizoenId { get; set; }
        public string Naam { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime Einddatum { get; set; }
        public bool IsActief { get; set; }
    }
}
