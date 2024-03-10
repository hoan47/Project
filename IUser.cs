using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface IUser
    {
        User User { get; set; }
        AccountDAO AccountDAO { get; set; }
        InfoDAO InfoDAO { get; set; }
    }
}
