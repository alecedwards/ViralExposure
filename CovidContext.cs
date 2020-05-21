using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ViralExposure
{
    public class CovidContext : DbContext
    {
        public DbSet<TownCovidInfo> TownCovidInformation {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=alecedwards;Host=localhost;Port=5432;Database=CovidTracker;Pooling=true;");
            options.EnableSensitiveDataLogging(true);
        }
    }

    public class TownCovidInfo
    {
        [Key]
        public string town_no { get; set; }
        public string town { get; set; }
        public DateTime lastupdateddate { get; set; }
        public string confirmedcases { get; set; }
        public string caserate { get; set; }
        public string deaths { get; set; }
        public string peopletested { get; set; }
    }
}