using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Class1
    {
    }

    public class customerentities
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public string cpassword { get; set; }
        public int age { get; set; }

        public string gender { get; set; }
        public string mail { get; set; }
        public string caddress { get; set; }

        public string phone { get; set; }
        public string aadhar { get; set; }
    }
    public class roomentities
    {
        public int roomno { get; set; }
        public string roomtype { get; set; }
        public string roomavailability { get; set; }
        public string ac { get; set; }


    }
    public class typeentities
    {
        public string rtype { get; set; }
        public double roomcost { get; set; }

    }

}
