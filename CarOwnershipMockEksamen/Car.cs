using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen
{
    public class Car
    {
        private enum Color { Black, White, Gray, Red, Green, Blue }
        private int Doors { get; set; }
        private string Model { get; set; }
        private string RegistrationNo { get; set; }

        private readonly Color c;
        
        public Car(int doors, string model, string registrationNo)
        {
            this.Doors = doors;
            this.Model = model;
            this.RegistrationNo = registrationNo;
            
            
            


        }

        

        public int CheckValidDoors()
        {
            if (Doors > 5 && Doors < 2)
            {
                throw new ArgumentException("Doors not valid");
            }
            return Doors;
        }

        public string ModelMustNotBeNull()
        {
            if (String.IsNullOrWhiteSpace(Model))
            {
                throw new ArgumentException("Model not valid");
            }
            return Model;
        }

        public string RegistrationNoCheck()
        {
            if (RegistrationNo.Length == 7)
            {
                return RegistrationNo;
            }
            throw new ArgumentException("Registration Number not valid");
        }

    }


}
