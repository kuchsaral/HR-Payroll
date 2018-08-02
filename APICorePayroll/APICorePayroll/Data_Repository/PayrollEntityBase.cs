using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICorePayroll.Data_Repository
{
    public class PayrollEntityBase : ICloneEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }
        public bool InActive { get; set; }
        ICloneEntity ICloneEntity.MemberwiseClone()
        {
            return this.MemberwiseClone() as ICloneEntity;
        }
    }
}
