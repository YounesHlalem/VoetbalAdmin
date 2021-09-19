namespace VoetbalAdmin.DataContracts.DTO
{
    public class WedstrijdResultaatDTO
    {
        public int WedstrijdResultaatId { get; set; }
        public int WedstrijdId { get; set; }
        public int ScoreThuis { get; set; }
        public int ScoreUit { get; set; }
    }
}
