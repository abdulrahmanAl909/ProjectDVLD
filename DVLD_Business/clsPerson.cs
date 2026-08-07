using DVLD_DataAccess;
using System;
using System.Data;
using System.Security.Policy;


namespace DVLD_Business
{
    public class clsPerson
    {

        enum enMode { Add=0, Update=1}

        enMode Mode = enMode.Add;

        public int PersonID { set; get; }

        public string NationalNo { set; get; }

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string ThirdName { set; get; }

        public string LastName { set; get; }

        public string FullName
        {
            get { return (FirstName + " " + SecondName + " " + ThirdName + " " + LastName); }
        }

        public DateTime DateOfBirth { set; get; }

        public enGendor Gendor { set; get; }

        public string Address { set; get; }

        public string Phone { set; get; }

        public string Email { set; get; }

        public int CountryID { set; get; }

        public string ImagePath { set; get; }

        public clsPerson()
        {
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = enGendor.Male;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.Add;
        }

        private clsPerson(int PersonID,string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth,enGendor Gendor ,string Address, string Phone, string Email, int CountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
         string LastName, DateTime DateOfBirth, enGendor Gendor, string Address, string Phone, string Email, int CountryID, string ImagePath)
        {

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName
                , this.ThirdName, this.LastName,this.DateOfBirth,(byte)this.Gendor, this.Address, this.Phone
                , this.Email, this.CountryID,this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID,this.NationalNo, this.FirstName, this.SecondName
                , this.ThirdName, this.LastName, this.DateOfBirth,(byte) this.Gendor, this.Address, this.Phone
                , this.Email, this.CountryID, this.ImagePath);
        }

        public static clsPerson GetPersonInfoByID(int PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int CountryID = -1;

            if (clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName
               , ref LastName, ref DateOfBirth,ref Gendor, ref Address, ref Phone, ref Email
               , ref CountryID, ref ImagePath))
            {
                return new clsPerson(PersonID,NationalNo, FirstName, SecondName, ThirdName
               , LastName, DateOfBirth,(enGendor)Gendor, Address, Phone, Email
               , CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson GetPersonInfoByNationalNo(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            int CountryID = -1 , PersonID=-1;

            if (clsPersonData.GetPersonInfoByNationalNo(ref PersonID,NationalNo, ref FirstName, ref SecondName, ref ThirdName
               , ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email
               , ref CountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName
               , LastName, DateOfBirth,(enGendor)Gendor, Address, Phone, Email
               , CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public bool SavePerson()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if(_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();

            }
            return false;
        }


    }
}
