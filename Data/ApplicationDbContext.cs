using DMM.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMM.Data
{
    public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActionTemplate> ActionTemplates { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AttatchedFile> AttatchedFiles { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemFeatureTrait> ItemFeatureTraits { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Loot> Loots { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<MonsterAction> MonsterActions { get; set; }
        public DbSet<MonsterTemplate> MonsterTemplates { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<TraitTemplate> TraitTemplates { get; set; }
        public DbSet<ImgClass> SaveImg { get; set; }

    }
}
