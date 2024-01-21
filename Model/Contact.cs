using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact :BaseModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Icon { get; set; }
    }
}
