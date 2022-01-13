using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EnfcGlog.Models
{
    public class Joueur
    {
        [Required]
        public int Id{get;set;}
        public int EquipeId{get;set;}

        [Display(Name ="Nom"),Required]
        public string nom {get;set;}

        [Display(Name ="Nom"),Required]
        public string prenom {get;set;}

        public string numlicence {get;set;}

    }
}