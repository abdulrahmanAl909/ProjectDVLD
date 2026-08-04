using DVLD_DataAccess;
using System;
using System.Data;
using System.Net;
using System.Security.Policy;


namespace DVLD_Business
{
    public class clsPerson
    {

        enum enMode { Add=0, Update=1}
        public enum enGendor { Male = 0, Femail = 1 }

        enMode Mode = enMode.Add;
        enGendor Gendor = enGendor.Male;

        private bool _AddNewPerson()
        {
            return true;
        }

        private bool _UpdatePerson()
        {
            return true;
        }

        public int PersonID { set; get; }

        public string NationalNo { set; get; }

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string ThirdName { set; get; }

        public string LastName { set; get; }

        public DateTime DateOfBirth { set; get; }


        public string Address { set; get; }

        public string Phone { set; get; }

        public string Email { set; get; }

        public int CountryID { set; get; }

        public string ImagePath { set; get; }

        //public clsPerson()
        //{
        //    this.NationalNo = "";
        //    this.FirstName = "";
        //    this.SecondName = "";
        //    this.ThirdName = "";
        //    this.LastName = "";
        //    this.DateOfBirth = DateOfBirth;
        //    this.Address = "";
        //    this.Phone = "";
        //    this.Email = "";
        //    this.CountryID = -1;
        //    this.ImagePath = "";

        //    Mode = enMode.Add;
        //}

        //public clsPerson(string NationalNo , string FirstName, string SecondName, string ThirdName,
        //    string LastName, DateTime DateOfBirth,string Address,string Phone, string Email, int CountryID,string ImagePath)
        //{
        //    this.NationalNo = NationalNo;
        //    this.FirstName = FirstName;
        //    this.SecondName = SecondName;
        //    this.ThirdName = ThirdName;
        //    this.LastName = LastName;
        //    this.DateOfBirth = DateOfBirth;
        //    this.Address = Address;
        //    this.Phone = Phone;
        //    this.Email = Email;
        //    this.CountryID = CountryID;
        //    this.ImagePath = ImagePath;

        //    Mode = enMode.Update;
        //}

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }



        //public bool SavePerson()
        //{
        //    switch (Mode)
        //    {
        //        case enMode.Add:

        //            Mode = enMode.Update;
        //            return _AddNewPerson();
        //            break;
        //        case enMode.Update:
        //            return _UpdatePerson();
        //            break;
            
        //    }

        //}

        //return new clsPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Address, Phone, Email, CountryID, ImagePath);






    }
}
