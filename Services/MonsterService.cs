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
        public async Task<Campaign> GetCampaignByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Campaign>();

            return await dbSet.FindAsync(Id);
        }
        
        public async Task UpdateMyCampaign(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Campaigns.SingleOrDefault(x => x.Id == p.Id);
            q1.Name = p.Name;
            q1.Description = p.Description;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteMyCampaign(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Campaigns.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertMyCampaign(Campaign p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}
