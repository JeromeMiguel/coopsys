using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calypso;
using calypso.DataAccess;

namespace coopsys
{
    internal class clsDefaults
    {
        private static int _year;
        private static int _totalMember;
        private static int _certificateTotal;
        public int year 
        { 
            get { return _year; }
            set { _year = value; } 
        }

        public int totalMember
        {
            get { return _totalMember; }
            set { _totalMember = value; }
        }

        public int certificateTotal
        {
            get { return _certificateTotal; }
            set { _certificateTotal = value; }
        }
    }
}
