using System;

namespace VoetbalAdmin.DataContracts.DTO
{
    public class LidRolDTO
    {
        public int LidRolId { get; set; }
        public int LidId { get; set; }
        public int RolId { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime Einddatum { get; set; }
    }
}
