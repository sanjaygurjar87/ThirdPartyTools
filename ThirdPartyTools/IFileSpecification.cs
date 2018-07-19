using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public interface IFileSpecification
    {
        bool IsVersionRequired { get; set; }
        bool IsSizeRequired { get; set; }
    }
}
