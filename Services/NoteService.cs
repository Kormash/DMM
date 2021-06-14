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
    public class NoteService : Service<Note>
    {
        private IDbContextFactory<ApplicationDbContext> dbContextFactory;
        private readonly ILogger<CampaignService> logger;
        public NoteService(IDbContextFactory<ApplicationDbContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<Note> GetNoteByID(int Id)
        {
            using var context = dbContextFactory.CreateDbContext();
            var dbSet = context.Set<Note>();

            return await dbSet.FindAsync(Id);
        }

        public async Task<List<Note>> GetNotesByLocationID(int locationId)
        {
            using var context = dbContextFactory.CreateDbContext();

            var noteList = await context.Notes.Where(x => x.LocationID == locationId).ToListAsync();

            return noteList.ToList();
        }

        public async Task UpdateNote(Note p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Notes.SingleOrDefault(x => x.Id == p.Id);
            q1.Text = p.Text;
            q1.Title = p.Title;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteNote(Note p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Notes.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertNote(Note p)
        {
            await using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

    }
}