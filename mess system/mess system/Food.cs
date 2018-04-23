using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mess_system
{
    public class Food
    {
        private string name;
        private int attendenceL;
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int AttendenceL
        {
            get { return attendenceL; }
            set { attendenceL = value; }
        }
        private int attendenceD;

        public int AttendenceD
        {
            get { return attendenceD; }
            set { attendenceD = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string day;

        public string Day
        {
            get { return day; }
            set { day = value; }
        }

    }
}