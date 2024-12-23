using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text;
using System;
using Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
       base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().HasData(
            new Categorie { Id = 1, Nom = "Mobile", OrderAffichage = 1 },
            new Categorie { Id = 2, Nom = "Ordinateur", OrderAffichage = 2 },
            new Categorie { Id = 3, Nom = "Périphériques", OrderAffichage = 3 }
            );

            modelBuilder.Entity<Produit>().HasData(
                           new Produit
                           {
                               Id = 1,
                               Nom = "Iphone 14",
                               Description = "iPhone 14 Pro. Avec un appareil photo principal de 48 MP pour capturer des détails époustouflants. " +
                                             "Dynamic Island et l'écran toujours activé, qui offrent une toute nouvelle expérience sur iPhone.",
                               PrixProduit = 10000,
                               Code = 123456789
                           },
                           new Produit
                           {
                               Id = 2,
                               Nom = "Imprimante HP Deskjet 2710",
                               Description = "Toutes les fonctions de base, désormais faciles à utiliser. " +
                                             "Imprimez, numérisez et copiez les documents quotidiens, et profitez d’une connexion simple et sans fil.",
                               PrixProduit = 5000,
                               Code = 546456789
                           }
                       );

        }
       
       
       
    }
}
