using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EnfcGlog.Models
{
    public class Equipe
    {
        [Required]
        public int Id{get;set;}

        public int PouleId{get;set;}

        [Display(Name ="Nom"),Required]
        public string nom {get;set;}

        [Display(Name ="Les joueurs")]
        public Joueur[] lesJoueurs {get;set;}

        [Display(Name ="Ecole"),Required]
        public string ecole {get;set;}

        [Display(Name ="Nombre de points")]
        public int nbPoints {get;set;}

    }
}