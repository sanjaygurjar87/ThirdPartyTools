using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program prog = new Program();
            prog.PrintFileInfo(prog.GetFileDetails(args));
        }

        public FileInfo GetFileDetails(string[] args)
        {
            string[] versionSpecs = new string[] { "-v", "--v", "/v", "-version" };
            string[] sizeSpecs = new string[] { "-s", "--s", "/s", "-size" };
            FileSpecification myFileSpec = new FileSpecification();

            for (int i = 0; i < args.Count(); i++)
            {
                switch (i)
                {
                    case 0:
                        foreach (string verSpec in versionSpecs)
                        {
                            if (args[0].Contains(verSpec))
                            {
                                myFileSpec.IsVersionRequired = true;
                                break;
                            }
                        }
                        break;
                    case 1:
                        foreach (string sizeSpec in sizeSpecs)
                        {
                            if (args[1].Contains(sizeSpec))
                            {
                                myFileSpec.IsSizeRequired = true;
                                break;
                            }
                        }
                        break;
                }
            }

            FileDetails fileDetails = new FileDetails(myFileSpec);
            return fileDetails.GetFileInfo();
        }

        public void PrintFileInfo(FileInfo fileInfo)
        {
            Console.WriteLine("My file details");
            Console.WriteLine("Size " + fileInfo.Size);
            Console.WriteLine("Version " + fileInfo.Version);
            Console.ReadLine();
        }
    }
}
