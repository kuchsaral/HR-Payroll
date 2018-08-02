using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICorePayroll.Data_Repository
{
    public interface ICloneEntity
    {
        ICloneEntity MemberwiseClone();
    }
}
