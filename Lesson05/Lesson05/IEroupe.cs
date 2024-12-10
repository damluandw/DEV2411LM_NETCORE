using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal interface IEroupe
    {
        void BuildAncient();

    }
    interface IAsian
    {
        void BuildMordem();
    }

    interface IVietNam: IAsian, IEroupe
    {
        void BuildMix();
    }

    class BuildVietNam : IVietNam
    {
        public void BuildAncient()
        {
            Console.WriteLine("Build Eroupe");
        }

        public void BuildMix()
        {
            Console.WriteLine("Build VietNam");
        }

        public void BuildMordem()
        {
            Console.WriteLine("Build Asian");
        }
    }
}
