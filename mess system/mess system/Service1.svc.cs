using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace mess_system
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void register(string fname, string lname, string reg, string password,string q,string ans)
        {
            User u = new User();
            u.Fname = fname;
            u.Lname = lname;
            u.Reg = reg;
            u.Password = password;
            u.Question = q;
            u.Answer = ans;
            Data.user.Add(u);
        }
        public bool isvalid(string fname, string lname, string reg, string password)
        {
            bool isfound = false;
            foreach (User u in Data.user)
            {
                if (u.Fname == fname && u.Lname==lname && u.Reg==reg && u.Password == password)
                {
                    isfound = true;
                }

            }
            return isfound;
        }
        public bool forget_password(string q, string ans, string newp)
        {
            bool isfound = false;
            foreach(User u in Data.user){
                if(u.Question==q && u.Answer==ans){
                    u.Password = newp;
                    isfound = true;
                }
            }
            return isfound;

        }
        public void Addfood(string n,string p,string day,string date,string t)
        {
            Food f = new Food();
            f.Name = n;
            f.Price = p;
            f.Day = day;
            f.Date = date;
            f.Type = t;
            FoodDL.myFood.Add(f);
        }
        public void Update_food(string n, string p, string day, string date)
        {
            foreach (Food u in FoodDL.myFood)
            {
                if (u.Day == day)
                {
                    u.Name = n;
                    u.Price = p;
                    u.Date = date;
                }
            }
         }
     
        public bool Adminisvalid(string UserName1, string Password1)
        {
            bool isfound = false;
                if ( UserName1==Admin.UserName1 && Password1==Admin.Password1 )
                {
                    isfound = true;
                }

            
            return isfound;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
