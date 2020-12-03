using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YesNoApp.Models.Interfaces
{
    public interface IYesNo
    {
        //will get a random yes no and one by ID from the database, needs an id because we will use that to grab a random record
        Task<YesNo> GetSinlgeYesNoRandom(int id);
        Task<YesNo> GetYesNoByID(int id);

    }
}
