using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMM.Data;
using DMM.Models.Entities;
using DMM.Services.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DMM.Services
{
    public class IconService : Service<Icon>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public IconService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        public async Task<List<Icon>> GetAllIcons()
        {
            await using var context = dbContextFactory.CreateDbContext();
            var AllMonsters = await context.Icons.ToListAsync();

            return AllMonsters.ToList();
        }
        
        public async Task<Icon> GetIconByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Icon>();

            return await dbSet.FindAsync(Id);
        }
    }
}
