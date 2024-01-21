using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Message :BaseModel
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
    }
}
