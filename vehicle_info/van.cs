using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_info
{
    class van : vehicle 
    {
        public van()
        {
            this.brand = null;
            this.model = null;
            this.car_tag = null;
            this.fuel_type = "Petrol";
            this.color = null;
            // how to make null int 
            this.wheel_number = 4;
            this.Axis_number = 1;
            this.Cylinders_number = 4;
            this.Passenger_number = 9;
            this.Base = 1;

        }
    }
}
