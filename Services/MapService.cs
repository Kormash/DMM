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
    public class MapService : Service<Map>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public MapService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<Map>> GetMapsByLocationID(int LocationId)
        {
            using var context = dbContextFactory.CreateDbContext();

            var MapList = await context.Maps.Where(x => x.LocationID == LocationId).ToListAsync();

            return MapList.ToList();
        }

        public async Task<Map> GetMapByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Map>();

            return await dbSet.FindAsync(Id);
        }

        public async Task UpdateMap(Map p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Maps.SingleOrDefault(x => x.Id == p.Id);
            q1.Title = p.Title;
            q1.Image = p.Image;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteMap(Map p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Maps.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertMap(Map p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}