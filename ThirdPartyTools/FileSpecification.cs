using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public class FileSpecification : IFileSpecification
    {
        public bool IsVersionRequired { get; set; }
        public bool IsSizeRequired { get; set; }
    }
}
