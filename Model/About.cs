using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;

//internal->erişim belirleyici
public class About : BaseModel
{
    public string Description2 { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public string Mail { get; set; }
    public string Job { get; set; }
}
