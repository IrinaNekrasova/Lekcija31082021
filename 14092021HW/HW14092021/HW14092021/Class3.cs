using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14092021
{
    public class Mashina
    {
        public string Marka { get; set; }
        public string Numurs { get; set; }
        public double Atrums { get; set; }
        public int Stop = 0;

        private bool _uzsakambraukshanu;
        public bool UzsakBraukshanu
        {
            get
            {
                return _uzsakambraukshanu;
            }
            set
            {
                _uzsakambraukshanu = Atrums > Stop;
            }


        }
        public void PalielinaAtrumu() { }
        public void PeleninaAtrumu() { }
        public void Apstajas() { }

        public string Uztaure()
        {
            return $"Beep Beep {UzsakBraukshanu}";
        }




    }
}
