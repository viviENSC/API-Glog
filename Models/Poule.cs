using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EnfcGlog.Models
{
    public class Poule
    {
        [Display(Name ="Nom"),Required]
        public int Id{get;set;}
        public Equipe[] classement {get;set;} //(Tableau triée par score décroissant)
        public Match[] lesMatchs {get;set;}
        
    }
}