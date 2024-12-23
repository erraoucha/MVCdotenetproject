using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commerce.Models
{
    public class Categorie
    {

        [Key]
       
        
        public int Id { get; set; }
        [DisplayName("nom de la categorie")]
        [Required(ErrorMessage = "Veuillez saisir un nom")]
        public string Nom { get; set; }
        [DisplayName("ordre d'affichage de categorei")]
        [Range(1, 10, ErrorMessage = "La valeur doit etre comprise entre 1 et 10")]
        public int OrderAffichage { get; set; }

        

    }
}
