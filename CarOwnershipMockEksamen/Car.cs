using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen
{
    public enum Color { Black, White, Gray, Red, Green, Blue }
    public class Car
    {
        public Owner owner { get; set; }

        private int doors;

        public int Doors
        {
            get { return doors; }
            set
            {
                if (doors <= 2 && doors >= 5)
                {
                    throw new ArgumentException("Door number not valid");
                }

                doors = value;
            }
        }


        private string model;

        public string Model
        {
            get { return model; }
            set
            {

                if (string.IsNullOrWhiteSpace(model))
                {
                    throw new ArgumentException("Model not valid");
                }

                model = value;
            }
        }

        private string registrationNr;

        public string RegistrationNr
        {
            get { return registrationNr; }
            set {

                if (RegistrationNr.Length != 7)
                {
                    throw new ArgumentException("RegistrationNo not valid");
                }

                registrationNr = value; }
        }



        public Car(int Doors, string Model, string RegistrationNr)
        {
            this.Doors = Doors;
            this.Model = Model;
            this.RegistrationNr = RegistrationNr;
        }
    }


}
