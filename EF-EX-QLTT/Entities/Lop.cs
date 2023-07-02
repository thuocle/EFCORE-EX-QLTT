using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_QLTT.Entities
{
    public class Lop
    {
        public int LopID { get; set; }
        public string TenLop { get; set; }
        IEnumerable<Lop> LopList { get; set; }
    }
}
