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
    public class AreaService : Service<Area>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public AreaService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<Area>> GetAreasByCampaignID(int CampaignId)
        {
            using var context = dbContextFactory.CreateDbContext();

            var areaList = await context.Areas.Where(x => x.CampaignID == CampaignId).ToListAsync();

            return areaList.ToList();
        }


        public async Task<Area> GetAreaByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Area>();

            return await dbSet.FindAsync(Id);
        }
        
        public async Task UpdateArea(Area p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Areas.SingleOrDefault(x => x.Id == p.Id);
            q1.Name = p.Name;
            q1.Description = p.Description;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteArea(Area p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Areas.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertArea(Area p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}
