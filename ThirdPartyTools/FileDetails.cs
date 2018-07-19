using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public class FileDetails
    {
        IFileSpecification fileSpec;
        Random version = new Random();
        Random size = new Random();

        public FileDetails(IFileSpecification spec)
        {
            this.fileSpec = spec;
        }

        public FileInfo GetFileInfo()
        {
            FileInfo fileInfo = new FileInfo();
            if (fileSpec.IsSizeRequired) {
                fileInfo.Size = FileSize();
            }
            if (fileSpec.IsVersionRequired) {
                fileInfo.Version = FileVersion();
            }
            return fileInfo;
        }

        private int FileSize()
        {
            return size.Next();
        }

        private int FileVersion()
        {
            return version.Next();
        }
    }
}
