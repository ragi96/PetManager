using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }

        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - this.Birthday.Year;
                if (this.Birthday.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
