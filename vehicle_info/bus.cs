using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_info
{
    class bus : vehicle
    {
        public bus()
        {
            this.brand = null;
            this.model = null;
            this.car_tag = null;
            this.fuel_type = "Gasoline";
            this.color = null;
            // how to make null int 
            this.wheel_number = 6;
            this.Axis_number = 2;
            this.Cylinders_number = 8;
            this.Passenger_number = 55;
            this.Base = 1;
        }
        public override List<string> add_new_vehicle_str_info()
        {
            Console.WriteLine("what is vehicle brand :");
            brand = Console.ReadLine();
            Console.WriteLine("what is vehicle model :");
            model = Console.ReadLine();
            Console.WriteLine("what is vehicle car tag :");
            car_tag = Console.ReadLine();
            Console.WriteLine("what is vehicle color :");
            color = Console.ReadLine();

            STR_info.Add($"car brand is : {brand}");
            STR_info.Add($"car brand is : {model}");
            STR_info.Add($"car tag is : {car_tag}");
            STR_info.Add($"car fuel type is : {fuel_type}");
            STR_info.Add($"car color is : {color}");

            return STR_info;
        }

        public virtual void Save_To_dictionary()
        {   //add info to dictionary
            Int_Info.Add(ID, INT_info);
            Str_Info.Add(ID, STR_info);
            STR_info.ForEach(Console.WriteLine);
            INT_info.ForEach(Console.WriteLine);

        }
        public List<int> add_new_vehicle_int_info()
        {

            INT_info.Add(wheel_number);
            INT_info.Add(Axis_number);
            INT_info.Add(Passenger_number);
            INT_info.Add(Cylinders_number);
            INT_info.Add(Base);

            return INT_info;
        }

        public void Main()
        {
            add_new_vehicle_str_info();
            add_new_vehicle_int_info();
            Save_To_dictionary();
            Console.WriteLine($" ID is {ID}");
            Console.WriteLine("-----------aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-----");
            Console.WriteLine(Str_Info.Count);

            Save_to_File();

        }
    }
}