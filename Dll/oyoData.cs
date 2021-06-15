using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.SqlClient;
using Dll.Models;

namespace Dll
{

    public class oyoData
    {
        oyoEntities1 dc = new oyoEntities1();
        public bool login(customerentities le)
        {
            var res = (from t in dc.customers
                       where t.cname == le.cname && t.cpassword == le.cpassword
                       select t).Count();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool contact(Contact contact)
        {
            SqlConnection conn = new SqlConnection("Server=localhost;Database=oyo;Trusted_Connection=True");
            conn.Open();
            var q = $"insert into contact(name, email, message) values('{contact.Name}','{ contact.Email}','{ contact.Message}')";
            SqlCommand cmd = new SqlCommand(q, conn);
            var res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//public class cusdal
//{
//    oyoEntities1 dc = new oyoEntities1();
//    public bool register(customerentities le)
//    {
//        string q = string.Format("insert into customer(cname,cpassword,age,gender,mail,caddress,phone,aadhar) values ( '" + le.cname + "' , '" + le.cpassword + "','" + le.age + "','" + le.gender + "', '" + le.mail + "', '" + le.caddress + "', '" + le.phone + "', '" + le.aadhar + "')");

//        int res = dc.Database.ExecuteSqlCommand(q);
//        if (res > 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}
//public class cusdal
//{
//    oyoEntities1 dc = new oyoEntities1();
//    public bool register(customerentities le)
//    {
//        customer e = new customer()
//        {
//            cname = le.cname,
//            cpassword = le.cpassword,
//            age = le.age,
//            gender = le.gender,
//            mail = le.mail,
//            caddress = le.caddress,
//            phone = le.phone,
//            aadhar = le.aadhar
//        };
//        dc.customers.Add(e);
//        int i = dc.SaveChanges();

//        if (i > 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//public class roomdal
//{
//    oyoEntities1 dc = new oyoEntities1();
//    public bool roomreg(roomentities re)
//    {
//        SqlConnection con = new SqlConnection("Integrated security=sspi;database=oyo;server=LAPTOP-OT3IGM4F\\SQLEXPRESS");
//        con.Open();
//        string q = string.Format("select roomcost from type rt  join room r on rt.rtype = r.roomtype where roomtype=(" + re.roomtype + "))", con);
//        int res = dc.Database.ExecuteSqlCommand(q);
//        if (res > 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//        con.Close();
//    }
//}

//public class GetroomDal
//{
//    oyoEntities1 dc = new oyoEntities1();
//public List<roomentities> dataDal()
//{
//    List<roomentities> el = new List<roomentities>();

//    var res = from t in dc.rooms select t;
//    foreach (var item in res)
//    {
//        el.Add(new roomentities()
//        {
//            roomno = item.roomno,
//            roomtype = item.roomtype,
//            roomavailability = item.roomavailability.ToString(),
//            ac = item.ac.ToString()


//        });
//    }
//    return el;
//}
//}
