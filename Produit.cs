using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commerce.Models
{
    public class Produit
    {
        [Key]

         
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Description { get; set; }
            public decimal PrixProduit { get; set; }
            public long Code { get; set; }
        public int categorieId { get; set; }

        [ForeignKey("categorieId")]
        public Categorie categorie { get; set; }



    }
}
