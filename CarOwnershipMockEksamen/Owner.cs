using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen
{
    public class Owner
    {

        private string address;

        public string Address
        {
            get { return address; }
            set {

                if (Address.Length < 6)
                {
                    throw new ArgumentException("Address not valid");
                }

                address = value; }
        }



        private string name;

        public string Name
        {
            get { return name; }
            set {

                if (Name.Length < 4)
                {
                    throw new ArgumentException("Name not valid");
                }

                name = value; }
        }


        private string phone;

        public string Phone
        {
            get { return phone; }
            set {

                if (Phone.Length != 8)
                {
                    throw new ArgumentException("PhoneNo not valid");
                }

                phone = value; }
        }



        public Owner(string Address, string Name, string Phone)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
        }
    }
}
