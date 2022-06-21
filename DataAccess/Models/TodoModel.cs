using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class TodoModel
{
    public int Id { get; set; }
    public string TodoTitle { get; set; }
    public string TodoDescription { get; set; }

}
