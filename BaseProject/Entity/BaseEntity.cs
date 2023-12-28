using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Entity
{
    public class BaseEntity
    {
        #region Constructor
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
        #endregion

        #region Properties
        public Guid Id { get; set; }
        public string? UserIn { get; set; }
        public string? UserUpd { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        #endregion
    }
}
