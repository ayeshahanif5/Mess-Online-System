using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace mess_system
{
    [DataContract]
    public class User
    {
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        private string reg;

        public string Reg
        {
            get { return reg; }
            set { reg = value; }
        }

            
           
        private string password;

            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            private string question;

            public string Question
            {
                get { return question; }
                set { question = value; }
            }
            private string answer;

            public string Answer
            {
                get { return answer; }
                set { answer = value; }
            }
            private string status;

            public string Status
            {
                get { return status; }
                set { status = value; }
            }
   
    
        [DataMember]
            public static List<Food> eaten=new List<Food>();
        private int bill;

        public int Bill
        {
            get { return bill; }
            set { bill = value; }
        } 
        }
    }