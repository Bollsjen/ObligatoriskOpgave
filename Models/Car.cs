using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatoriskOpgave.Exeptions;

namespace ObligatoriskOpgave.Models
{
    public class Car
    {
        private static int _nextID = 1;
        private int _id;
        private string _model;
        private double _price;
        private string _plate;
        public int ID { get => _id; set => _id = value; }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 4)
                    throw new ModelNotLongEnough("Model has to be minimum of 4 characters long", value);

                _model = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                    throw new PriceHasToBeMoreThanZero("Price has to be more than zero", value);

                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _plate;
            set
            {
                if (value.Length < 2 || value.Length > 7)
                    throw new LicensePlateHasToBeInRange("License plate has to be between 2 and 7 characters long", value);

                _plate = value;
            }
        }

        public Car(){}

        public Car(int id, string model, double price, string plate)
        {
            if (model.Length < 4)
                throw new ModelNotLongEnough("Model has to be minimum of 4 characters long", model);
            if (plate.Length < 2 || plate.Length > 7)
                throw new LicensePlateHasToBeInRange("License plate has to be between 2 and 7 characters long", plate);
            ID = id;
            Model = model;
            Price = price;
            LicensePlate = plate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Model: {Model}, Price: {Price}, License Plate: {LicensePlate}";
        }
    }
}