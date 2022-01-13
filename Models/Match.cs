using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EnfcGlog.Models
{
    public class Match
    {
        [Required]
        public int Id{get;set;}

        public int PouleId{get;set;}

        [Display(Name ="Equipe 1"),Required]
        public string equipe1 {get;set;}

        [Display(Name ="Equipe 2"),Required]
        public string equipe2 {get;set;}

        public int scoreEquipe1 {get;set;} 
        public int scoreEquipe2 {get;set;} 

        public double coteVictoireE1 {get;set;} 
        public double coteVictoireE2 {get;set;} 
        public double coteMNul {get;set;} 

        [Display(Name ="Date du match"),DataType(DataType.Date)]
        public DateTime dateDuMatch {get;set;}

    }
}