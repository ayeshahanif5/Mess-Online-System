﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace mess_system
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void register(string fname, string lname, string reg, string password,string q, string ans);
        [OperationContract]
        bool isvalid(string fname, string lname, string reg, string password);
        [OperationContract]
        bool forget_password(string q, string ans,string newp);
        [OperationContract]
        bool Adminisvalid(string u, string p);
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        void Addfood(string n, int p, string day, string date, string t);
       
        [OperationContract]
        void Update_food(string n, int p, string day, string date);
       
        [OperationContract]
        List<Food> ViewMenu();
        [OperationContract]
        void UpdateStatus(string r);
        [OperationContract]
        void submit();
        [OperationContract]
        int checkbillbydate(string date);
        [OperationContract]
        int claculate_bill();
        [OperationContract]
        int check(string reg);
        [OperationContract]
        string check_status(string reg);
        [OperationContract]
        void Addfine();
        [OperationContract]
        void block();
        [OperationContract]
        void rate(int r, string d, string t);
        [OperationContract]
        int checkrating(string d, string t);
        [OperationContract]
        bool ValidRegistration(string reg);
        [OperationContract]
        int getattendence(string date,string type);



        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
