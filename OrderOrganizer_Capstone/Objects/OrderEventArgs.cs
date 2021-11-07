using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib;

namespace OrderOrganizer_Capstone.Objects
{
    public class OrderEventArgs : EventArgs
    {
        public order Order { get; set; }
    }
}
