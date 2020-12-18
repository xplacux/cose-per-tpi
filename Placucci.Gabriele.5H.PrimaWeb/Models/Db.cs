using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace Placucci.Gabriele._5H.PrimaWeb.Models
{
    public class PrenotazioneContext : DbContext
    {
        public DbSet<Prenotazione> Prenotazioni { get; set; } //tabbella del db
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");
    }

   
}