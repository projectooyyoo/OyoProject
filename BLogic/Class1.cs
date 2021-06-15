//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Dll;
//using BusinessEntity;

//namespace BLogic
//{
//    public class Class1
//    {
//    }
//    public class logincus
//    {
//        cusdal lc = new cusdal();
//        public bool cuslogic(customerentities le)
//        {
//            if (le.phone.Length == 10 && le.aadhar.Length == 12)
//            {
//                bool m = lc.register(le);
//                return m;
//            }
//            else
//            {
//                return false;
//            }
//        }

//    }

//    public class loginblogic
//    {
//        logindal ld = new logindal();
//        public bool loginb(customerentities le)
//        {
//            bool r = ld.login(le);
//            return r;
//        }
//    }
//    //public class roomblogic
//    //{
//    //    roomdal rd = new roomdal();
//    //    public bool roomb(roomentities re)
//    //    {

//    //        return rd.roomreg(re);


//    //    }
//    //}
//    public class GetroomBlogic
//    {
//        GetroomDal ged = new GetroomDal();//dal
//        public List<roomentities> dataBlogic()
//        {
//            return ged.dataDal();
//        }
//    }
//}
