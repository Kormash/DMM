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
    public class MonsterActionService : Service<MonsterAction>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public MonsterActionService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        
        public async Task<List<MonsterAction>> GetMonsterActionsByMonsterId(int MonsterId)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var MonsterActions = await context.MonsterActions.Where(x => x.MonsterID == MonsterId).ToListAsync();

            return MonsterActions.ToList();
        }

        public async Task DeleteMonsterAction(MonsterAction t)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.MonsterActions.SingleOrDefault(x => x.Id == t.Id);
            context.Remove(q1);
            context.SaveChanges();
        }

    }
}
