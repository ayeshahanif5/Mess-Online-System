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
        private int price;
          [DataMember]
        public int Price
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
        private bool On_Mess;
          [DataMember]
        public bool On_Mess1
        {
            get { return On_Mess; }
            set { On_Mess = value; }
        }
        private int attendence=0;
          [DataMember]
        public int Attendence
        {
            get { return attendence; }
            set { attendence = value; }
        }
        private int rating;
          [DataMember]
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private int people = 0;
          [DataMember]
        public int People
        {
            get { return people; }
            set { people = value; }
        }
        public List<int> allratings;
    }
    
}