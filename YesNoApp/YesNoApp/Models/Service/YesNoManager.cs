using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YesNoApp.Data;
using YesNoApp.Models.Interfaces;

namespace YesNoApp.Models.Services
{
    public class YesNoManager : IYesNo
    {
        //DP:
        private YesNoDbContext _context;
        public YesNoManager(YesNoDbContext context)
        {
            _context = context;
        }
        public async Task<YesNo> GetSinlgeYesNoRandom(int id) => await _context.YesNoTable.FirstOrDefaultAsync(x => x.ID == id);
        public async Task<YesNo> GetYesNoByID(int id) => await _context.YesNoTable.FirstOrDefaultAsync(x => x.ID == id);

    }
}
