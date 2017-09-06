using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen
{
    public class Owner
    {
        //propfull address
        //private string address;
        //private string Address
        //{
        //    get
        //    {
        //        return address;
        //    }
        //    set
        //    {
        //        if ((value.Length < 6))
        //        {
        //            address = value;
        //        }
        //    }
        //}

        private string Address { get; set; }
        private string Name { get; set; }
        private string Phone { get; set; }

        public Owner(string address, string name, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public string CheckAddressLength()
        {
            if (Address.Length < 6)
            {
                throw new ArgumentException("Address not valid");
            }
            return Address;
        }

        public string CheckNameLenght()
        {
            if (Name.Length < 4)
            {
                throw new ArgumentException("Name not valid");
            }
            return Name;
        }

        public string CheckPhoneLenght()
        {
            if (Phone.Length == 8)
            {
                return Phone;
            }
            throw new ArgumentException("Phone Number not valid");
        }


    }
}
