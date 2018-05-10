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
        public void register(string fname, string lname, string reg, string password, string q, string ans)
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
                if (u.Fname == fname && u.Lname == lname && u.Reg == reg && u.Password == password)
                {
                    isfound = true;
                    myutil.loginuser = u;
                }

            }
            return isfound;
        }
        public bool forget_password(string q, string ans, string newp)
        {
            bool isfound = false;
            foreach (User u in Data.user)
            {
                if (u.Question == q && u.Answer == ans)
                {
                    u.Password = newp;
                    isfound = true;
                }
            }
            return isfound;

        }
        public void Addfood(string n, int p, string day, string date, string t)
        {
            Food f = new Food();
            f.Name = n;
            f.Price = p;
           
            f.Day = day;
            f.Date = date;
            f.Type = t;
            FoodDL.myFood.Add(f);
        }
        public void Update_food(string n, int p, string day, string date)
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
            if (UserName1 == Admin.UserName1 && Password1 == Admin.Password1)
            {
                isfound = true;
            }


            return isfound;
        }
        public List<Food> ViewMenu()
        {
            return FoodDL.myFood;

        }
        public void UpdateStatus(string reg)
        {
            foreach (User u in Data.user)
            {
                if (u.Reg == reg)
                {
                    u.Status = "clear";
                }
            }

        }
        public void submit()
        {

           
                foreach (Food d in FoodDL.myFood)
            {
                if (d.On_Mess1)
                {
                    myutil.loginuser.Bill += d.Price;
                    myutil.loginuser.eaten.Add(d);
                    d.Attendence += 1;

                }
                
            }
        }
       public int checkbillbydate(string date) {
          int  bill=0;
            foreach(Food s in myutil.loginuser.eaten)
            {
                if (s.Date == date)
                {
                  
                        bill += s.Price;
                    
                    

        }
            }
            return bill;
        }

       public int claculate_bill()
       {

           int b = 0;
           foreach (Food f in myutil.loginuser.eaten)
           {
               b = b + f.Price;

           }
           return b;
       }
       public int check(string reg) {
          int s = 0;
       foreach (User u in Data.user)
       {
           if (u.Reg == reg)
           {
               if (u.Status == "clear")
               {
                   s = 1;
               }
               
           }
       }
       return s;
       }
       public string check_status(string reg)
       {
           string l = "bill is not paid";
           return l;
       
     
       }
       public void Addfine()
       {
           foreach (User u in Data.user)
           {
               if (u.Status != "clear")
               {
                   u.Bill += 100;
               }
    
           }

       }
       public void  block()
       {
           string pass = "dshdusgysgd";
           foreach (User u in Data.user)
           {
               if (u.Status != "clear")
               {
                   u.Password = pass;
               
               }
           }
          
       }

       public void rate(int r, string d, string t)
       {


           foreach (Food f in FoodDL.myFood)
           {
               if (f.Date == d && f.Type == t)
               {
                   f.People += 1;
                   f.allratings.Add(r);
                   int sum = 0;
                   foreach (int i in f.allratings)
                   {
                       sum += i;
                   }

                   f.Rating = sum / f.People;

               }
           }
       }
       public int checkrating(string d, string t)
       {

           int x = 0;
           foreach (Food f in FoodDL.myFood)
           {
               if (f.Date == d && f.Type == t)
               {
                   x = f.Rating;
               }
           }
           return x;
       }

       public bool ValidRegistration(string reg)
       {
           bool valid = true;
           foreach (User u in Data.user)
           {
               if (u.Reg == reg)
               {
                   valid = false;
               }
           }
           return valid;
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
        public int getattendence(string date,string type)
        {
            int k = 0;
            foreach (Food f in FoodDL.myFood)
            {
                if (f.Date == date && f.Type == type)
                {
                   k=  f.Attendence;
                }
            
            
            }
            return k;
        
        
        
        }
      
       
    }
}

