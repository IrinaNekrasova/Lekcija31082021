using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14092021
{
    public class Prece
    {
        private double _garums;
        public double Garums
        {
            get
            {
                return _garums;
            }
            set
            {
                _garums = value;
            }
        }

        private double _augstums;
        public double Augstums
        {
            get
            {
                return _augstums;
            }
            set
            {
                _augstums = value;
            }
        }


        private double _svars;
        public double Svars
        {
            get
            {
                return _svars;
            }
            set
            {
                _svars = value;
            }
        }


        public string PrecesParametri()
        {
            return $"Preces parametri ir Augstums {Augstums} un Garums {Garums} ka ari Svars {Svars}";
        }






    }
}
