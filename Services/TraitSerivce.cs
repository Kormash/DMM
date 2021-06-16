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
    public class TraitService : Service<Trait>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public TraitService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        
        public async Task<List<Trait>> GetTraitsByMonsterId(int MonsterId)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var Traits = await context.Traits.Where(x => x.MonsterID == MonsterId).ToListAsync();

            return Traits.ToList();
        }

        public async Task DeleteTrait(Trait t)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Traits.SingleOrDefault(x => x.Id == t.Id);
            context.Remove(q1);
            context.SaveChanges();
        }

    }
}
