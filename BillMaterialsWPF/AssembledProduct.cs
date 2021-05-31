﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillMaterialsWPF
{
    public class AssembledProduct
    {
        public int productAssemblyID { get; set; }
        public int componentID { get; set; }
        public int bomLevel { get; set; }
        public string Name { get; set; }
        public List<AssembledProduct> Components { get; set; }

    }
}
