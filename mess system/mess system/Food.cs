using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace mess_system
{
    [DataContract]
    public class Food
    {
        private string name;
       
        private string date;

        [DataMember]
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
     
       
        
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string price;
        [DataMember]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string type;
        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string day;
        [DataMember]
        public string Day
        {
            get { return day; }
            set { day = value; }
        }

    }
}