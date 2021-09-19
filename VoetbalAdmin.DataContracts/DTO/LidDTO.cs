using System;

namespace VoetbalAdmin.DataContracts.DTO
{
    public class LidDTO
    {
        public int LidId { get; set; }
        public string BondsNr { get; set; }
        public int TeamId { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public int GeslachtId { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Postcode { get; set; }
        public string Stad { get; set; }
        public string Adres { get; set; }
        public string TelefoonNr { get; set; }
        public bool IsGearchiveerd { get; set; }
    }
}
