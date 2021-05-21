using DMM.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace DMM.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Campaign> Campaigns { get; set; }
    }
}
