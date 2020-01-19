using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public interface IEmployee
    {
        Employee GetEmployee(int Id);
    }
}
