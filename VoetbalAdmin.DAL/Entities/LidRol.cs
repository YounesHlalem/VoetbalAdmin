using System;
using System.Collections.Generic;
using System.Text;

namespace VoetbalAdmin.DAL.Entities
{
    public class LidRol
    {
        public int LidRolId { get; set; }
        public int LidId { get; set; }
        public Lid Lid { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public DateTime Begindatum { get; set; }
        public DateTime Einddatum { get; set; }
    }
}
