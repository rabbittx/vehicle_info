using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Vehicle_info
{
    public class vehicle
    {
        //boolean type need to add 
        private protected string brand;
        private protected string model;
        private protected string car_tag;
        private protected string color;
        private protected string fuel_type;

        private protected int wheel_number;
        private protected int Axis_number;
        private protected int Cylinders_number;
        private protected int Passenger_number;
        private protected int Base;
        protected int ID = 0;

        private protected string path = @"D:\C sharp archive\code !\Vehicle_info2\Vehicle_info\Vehicle_info\DBfile.txt";


        private protected List<string> STR_info = new List<string> { };
        private protected List<int> INT_info = new List<int> { };
        private protected Dictionary<int, List<string>> Str_Info = new Dictionary<int, List<string>>();
        private protected Dictionary<int, List<int>> Int_Info = new Dictionary<int, List<int>>();


        public vehicle()
        {   //constructors  need to fix 
            this.brand = null;
            this.model = null;
            this.car_tag = null;
            this.fuel_type = null;
            this.color = null;
            // how to make null int 
            this.wheel_number = wheel_number;
            this.Axis_number = Axis_number;
            this.Cylinders_number = Cylinders_number;
            this.Passenger_number = Passenger_number;
            this.Base = Base;
            this.ID++;
        }

        public virtual List<string> add_new_vehicle_str_info()
        {
            //TODO add regix to get correct info from user
            Console.WriteLine("what is vehicle brand :");
            brand = Console.ReadLine();
            Console.WriteLine("what is vehicle model :");
            model = Console.ReadLine();
            Console.WriteLine("what is vehicle car tag :");
            car_tag = Console.ReadLine();
            Console.WriteLine("what is vehicle fuel type :");
            fuel_type = Console.ReadLine();
            Console.WriteLine("what is vehicle color :");
            color = Console.ReadLine();

            STR_info.Add(brand);
            STR_info.Add(model);
            STR_info.Add(car_tag);
            STR_info.Add(fuel_type);
            STR_info.Add(color);
            return STR_info;
        }

        public List<int> add_new_vehicle_int_info()
        {
            //TODO add regix to get correct info from user
            // check out variables size ! 
            Console.WriteLine("what is vehicle wheel number :");
            wheel_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is vehicle Axis number :");
            Axis_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is vehicle Passenger number :");
            Passenger_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is vehicle Cylinders number :");
            Cylinders_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what is vehicle Base :");
            Base = Convert.ToInt32(Console.ReadLine());

            INT_info.Add(wheel_number);
            INT_info.Add(Axis_number);
            INT_info.Add(Passenger_number);
            INT_info.Add(Cylinders_number);
            INT_info.Add(Base);

            return INT_info;
        }

        public virtual void Save_To_dictionary()
        {   //add info to dictionary
            Int_Info.Add(ID, INT_info);
            Str_Info.Add(ID, STR_info);
            STR_info.ForEach(Console.WriteLine);
            INT_info.ForEach(Console.WriteLine);
            Console.WriteLine("-----------aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa-----");
            Console.WriteLine(Int_Info);
            Console.WriteLine(Str_Info);



        }

        public void main()
        {
            //start app here ! 
            add_new_vehicle_str_info();
            add_new_vehicle_int_info();
            Save_To_dictionary();
            Console.WriteLine("-----------------------");
            INT_info.ForEach(Console.WriteLine);
            Console.WriteLine("-----------------------");
            STR_info.ForEach(Console.WriteLine);
            Console.WriteLine("-----------------------");

        }

        public void Save_to_File()
        {
            try
            {
                if (File.Exists(path))
                {
                    // use try and catch here ! 
                    // Create a file to write to.
                    // need to fix -->(how to show list value !!!)
                    using (StreamWriter file = File.CreateText(path))
                    {
                        Console.WriteLine("ready to save ");
                        file.WriteLine("---------------------------------");
                        foreach (KeyValuePair<int, List<int>> kvp in Int_Info)
                          {
                              Console.WriteLine($"key is {kvp.Key}");
                              Console.WriteLine($"key is {kvp.Value}");
                          }
                         
                        file.WriteLine(Str_Info);
                        file.WriteLine(Int_Info);
                        file.WriteLine("---------------------------------");
                        Console.WriteLine("info are  saved ");


                    }

                }
            }
            catch (InvalidCastException e)
            {
                 Console.WriteLine("error");
            }


        }
    
    }
}
