using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrientSoftWare.Base.My.Entities
{
        [Table("UserInRole")]
        public class UserInRole : BaseEntity
        {
            public UserInRole() : base()
            {   

            }

            public Guid UserId { get; set; }
            public User User { get; set; }
            public Guid RoleId { get; set; }
            public Role Role { get; set; }
        }
  
}
