using System;
using System.Collections.Generic;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class Lid
    {
        public int LidId { get; set; }
        public string BondsNr { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public int GeslachtId { get; set; }
        public Geslacht Geslacht { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Postcode { get; set; }
        public string Stad { get; set; }
        public string Adres { get; set; }
        public string TelefoonNr { get; set; }
        public bool IsGearchiveerd { get; set; }
    }
}
