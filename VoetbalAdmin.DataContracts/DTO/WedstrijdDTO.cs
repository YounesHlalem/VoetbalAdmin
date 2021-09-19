using System;

namespace VoetbalAdmin.DataContracts.DTO
{
    public class WedstrijdDTO
    {
        public int WedstrijdId { get; set; }
        public int TeamThuisId { get; set; }
        public int TeamUitId { get; set; }
        public int ReeksId { get; set; }
        public DateTime Wedstrijddatum { get; set; }
    }
}
