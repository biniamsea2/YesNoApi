using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YesNoApp.Models.Interfaces;

namespace YesNoApp.Models.Services
{
    public class YesNoManager : IYesNo
    {
        public Task<YesNo> GetSinlgeYesNoRandom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<YesNo> GetYesNoByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
