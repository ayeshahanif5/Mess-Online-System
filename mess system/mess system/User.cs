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
        [DataMember]
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        [DataMember]
        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        [DataMember]
        private string reg;

        public string Reg
        {
            get { return reg; }
            set { reg = value; }
        }


           [DataMember]
        private string password;

            public string Password
            {
                get { return password; }
                set { password = value; }
            }
        [DataMember]
            private string question;

            public string Question
            {
                get { return question; }
                set { question = value; }
            }
        [DataMember]
            private string answer;

            public string Answer
            {
                get { return answer; }
                set { answer = value; }
            }
        [DataMember]
            private string status;

            public string Status
            {
                get { return status; }
                set { status = value; }
            }
   
    
        [DataMember]
            public List<Food> eaten=new List<Food>();
        [DataMember]
        private int bill=0;

        public int Bill
        {
            get { return bill; }
            set { bill = value; }
        } 
        }
    }