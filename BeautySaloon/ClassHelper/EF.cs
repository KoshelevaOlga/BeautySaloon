using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon.ClassHelper
{
    internal class EF
    {
        public static BD.Entities Context { get; set; } = new BD.Entities();
    }
}
