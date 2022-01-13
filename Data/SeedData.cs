using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EnfcGlog.Models;

namespace EnfcGlog.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EnfcGlogContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EnfcGlogContext>>()))
            {
                // Look for any students
                if (context.Equipe.Any())
                {
                    return;   // DB has been seeded
                }

                var joueur = new Joueur[]
                {
                    new Joueur{Id=1,EquipeId=1,nom="Robin",prenom="Le Carour"},
                    new Joueur{Id=2,EquipeId=1,nom="Lucas",prenom="Corentin"},
                    new Joueur{Id=3,EquipeId=1,nom="Renaud",prenom="Thomas"},
                    new Joueur{Id=4,EquipeId=1,nom="Balatti",prenom="Enzo"},
                    new Joueur{Id=5,EquipeId=1,nom="Domecq",prenom="François"},
                    new Joueur{Id=6,EquipeId=1,nom="Sofiane",prenom="Wissam"},
                    new Joueur{Id=7,EquipeId=1,nom="Yilmaz",prenom="Saban"},
                    new Joueur{Id=8,EquipeId=1,nom="Lebreton",prenom="Matis"},
                    new Joueur{Id=9,EquipeId=1,nom="Gautier",prenom="Noe"},
                    new Joueur{Id=10,EquipeId=1,nom="Mallard",prenom="Tudual"},
                    new Joueur{Id=11,EquipeId=1,nom="Bossis",prenom="Victor"},
                    new Joueur{Id=12,EquipeId=1,nom="Pimpaud",prenom="Maxime"},
                    new Joueur{Id=13,EquipeId=1,nom="Sanad",prenom="Akram"},
                    new Joueur{Id=14,EquipeId=1,nom="Guedon",prenom="Titouan"},
                    new Joueur{Id=15,EquipeId=1,nom="Saracco",prenom="Arthur"}
                };
                context.Joueur.AddRange(joueur);

                var equipes = new Equipe[]
                {
                    new Equipe{Id=1,PouleId=1,nom="ENFC",ecole="ENSC",nbPoints=17},
                    new Equipe{Id=2,PouleId=1,nom="Sciences Tech 4",ecole="Sciences et Technologies",nbPoints=6},
                    new Equipe{Id=3,PouleId=1,nom="Torpedo 1917",ecole="Science Politique",nbPoints=11},
                    new Equipe{Id=4,PouleId=1,nom="Les Pieuvres",ecole="DUT Commerce",nbPoints=5},
                    new Equipe{Id=5,PouleId=1,nom="Montaigne 3",ecole="Université de Bordeaux Montaigne",nbPoints=8},
                    new Equipe{Id=6,PouleId=1,nom="Bordeaux INP 2",ecole="Bordeaux INP",nbPoints=20}
                   
                };
                context.Equipe.AddRange(equipes);


                var matchs = new Match[]
                {
                    new Match{Id=1,PouleId=1,equipe1="ENSC",equipe2="Sciences Tech 4",scoreEquipe1=3,scoreEquipe2=2,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-10-28")},
                    new Match{Id=2,PouleId=1,equipe1="Bordeaux INP 2",equipe2="Montaigne 3",scoreEquipe1=6,scoreEquipe2=0,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-10-28")},
                    new Match{Id=3,PouleId=1,equipe1="Torpedo 1917",equipe2="Les Pieuvres",scoreEquipe1=7,scoreEquipe2=1,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-10-28")},
                    new Match{Id=4,PouleId=1,equipe1="Les Pieuvres",equipe2="Montaigne 3",scoreEquipe1=2,scoreEquipe2=2,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-08")},
                    new Match{Id=5,PouleId=1,equipe1="Torpedo 1917",equipe2="ENSC",scoreEquipe1=1,scoreEquipe2=4,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-15")},
                    new Match{Id=6,PouleId=1,equipe1="Bordeaux INP 2",equipe2="Sciences Tech 4",scoreEquipe1=11,scoreEquipe2=2,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-18")},
                    new Match{Id=7,PouleId=1,equipe1="Les Pieuvres",equipe2="ENSC",scoreEquipe1=1,scoreEquipe2=4,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-24")},
                    new Match{Id=8,PouleId=1,equipe1="Bordeaux INP 2",equipe2="Torpedo 1917",scoreEquipe1=6,scoreEquipe2=1,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-25")},
                    new Match{Id=9,PouleId=1,equipe1="Sciences Tech 4",equipe2="Montaigne 3",scoreEquipe1=0,scoreEquipe2=1,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-11-25")},
                    new Match{Id=10,PouleId=1,equipe1="ENSC",equipe2="Montaigne 3",scoreEquipe1=5,scoreEquipe2=1,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-02")},
                    new Match{Id=11,PouleId=1,equipe1="Les Pieuvres",equipe2="Bordeaux INP 2",scoreEquipe1=1,scoreEquipe2=3,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-02")},
                    new Match{Id=12,PouleId=1,equipe1="Torpedo 1917",equipe2="Sciences Tech 4",scoreEquipe1=5,scoreEquipe2=2,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-02")},
                    new Match{Id=13,PouleId=1,equipe1="ENSC",equipe2="Bordeaux INP 2",scoreEquipe1=2,scoreEquipe2=6,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-09")},
                    new Match{Id=14,PouleId=1,equipe1="Les Pieuvres",equipe2="Sciences Tech 4",scoreEquipe1=0,scoreEquipe2=0,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-09")},
                    new Match{Id=15,PouleId=1,equipe1="Torpedo 1917",equipe2="Montaigne 3",scoreEquipe1=2,scoreEquipe2=5,coteVictoireE1=0.5,coteVictoireE2=1.4,coteMNul=0.8,dateDuMatch=DateTime.Parse("2021-12-09")},
                };
                context.Match.AddRange(matchs);

                var poules = new Poule[]
                {
                    new Poule{Id=1,lesMatchs=matchs,classement=equipes}
                    
                };
                context.Poule.AddRange(poules);

                context.SaveChanges();
            }
        }
    }
}