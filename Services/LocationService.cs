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
    public class LocationService : Service<Location>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public LocationService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<Location>> GetLocationByAreaID(int AreaId)
        {
            using var context = dbContextFactory.CreateDbContext();

            var LocationList = await context.Locations.Where(x => x.AreaID == AreaId).ToListAsync();

            return LocationList.ToList();
        }


        public async Task<Location> GetLocationByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Location>();

            return await dbSet.FindAsync(Id);
        }
        
        public async Task UpdateLocation(Location p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Locations.SingleOrDefault(x => x.Id == p.Id);
            q1.Name = p.Name;
            q1.Description = p.Description;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteLocation(Location p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Locations.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertLocation(Location p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}
