using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrientSoftWare.Base.My.Entities
{
    [Table("Role")]
    public class Role :BaseEntity
    {
        public Role () : base()
        {

        }
        public string Name { get; set; }
        public List<UserInRole> UserInRoles { get; set; }
    }
}
