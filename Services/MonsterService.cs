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
    public class MonsterService : Service<Monster>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public MonsterService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        public async Task<List<Monster>> GetAllMonsters()
        {
            await using var context = dbContextFactory.CreateDbContext();
            var AllMonsters = await context.Monsters.ToListAsync();

            return AllMonsters.ToList();
        }
        public async Task<List<Monster>> GetMonstersByLocationId(int LocationId)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var MyMonsters = await context.Monsters.Where(x => x.LocationID == LocationId).ToListAsync();

            return MyMonsters.ToList();
        }

        public async Task DeleteMonster(Monster m)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Monsters.SingleOrDefault(x => x.Id == m.Id);
            context.Remove(q1);
            context.SaveChanges();
        }

    }
}
