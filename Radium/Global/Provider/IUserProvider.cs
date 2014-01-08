using Radium.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium.Global.Provider
{
    public interface IUserProvider
    {
        User User { get; set; }
    }
}
