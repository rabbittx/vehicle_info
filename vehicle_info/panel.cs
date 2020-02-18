using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_info
{
    class panel
    {
        private int choose;
        public panel()
        {
        }

        public void Panel()
        {   // main panel is here 
            Console.WriteLine("choose what you need ");
            Console.WriteLine("1 for add new car ");
            Console.WriteLine("2 for search ");
            Console.WriteLine("3 for edit");
            Console.WriteLine("4 for delete");
            choose = Convert.ToInt16(Console.ReadLine());

            switch (choose)
            {
                case 1: Add_new_vehicle(); ; break;
                case 2: Console.WriteLine("search for! "); break;
                case 3: Console.WriteLine("do you need to edit"); break;
                case 4: Console.WriteLine("you want to  delete"); break;
                default: Console.WriteLine("worng chooser retry !"); Panel(); break;

            }
        }

        public void Add_new_vehicle()
        {
            // add new vehicle here ! 
            Console.WriteLine("choose your vehicle type ");
            Console.WriteLine("1 for Car ");
            Console.WriteLine("2 for Bus ");
            Console.WriteLine("3 for Truck");
            Console.WriteLine("4 for van");
            Console.WriteLine("5 for motorcycle");
            choose = Convert.ToInt16(Console.ReadLine());
            switch (choose)
            {
                case 1: Car car = new Car();car.Main() ; break;
                case 2: bus bus = new bus();bus.Main(); break;
                case 3: Console.WriteLine("you for new truck"); break;
                case 4: van van = new van();van.Main(); break;
                case 5: motorcycle motorcycle = new motorcycle();motorcycle.Main() ; break;
                default: Console.WriteLine("worng chooser retry !"); Add_new_vehicle(); break;

            }
            

        }
    }
}
