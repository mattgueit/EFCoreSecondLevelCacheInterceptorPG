using EFCoreSecondLevelCacheInterceptorPG.Models;
using System.Linq;

namespace EFCoreSecondLevelCacheInterceptorPG.Data
{
    public class DbInitializer
    {
        public static void Initialize(UltimateTeamContext context)
        {
            context.Database.EnsureCreated();

            // Look for any players.
            if (context.Players.Any())
                return;

            var players = new Player[]
            {
                new Player{FirstName="Thomas", LastName="Partey"},
                new Player{FirstName="Alexandre", LastName="Lacazette"},
                new Player{FirstName="Pierre-Emerick", LastName="Aubameyang"},
                new Player{FirstName="Nicolas", LastName="Pepe"},
                new Player{FirstName="Ben", LastName="White"},
                new Player{FirstName="Hector", LastName="Bellerin"},
                new Player{FirstName="Kieran", LastName="Tierney"},
                new Player{FirstName="Bernd", LastName="Leno"},
                new Player{FirstName="Gabriel", LastName="Martinelli"},
                new Player{FirstName="Sead", LastName="Kolasinac"},
                new Player{FirstName="Lucas", LastName="Torreira"},
                new Player{FirstName="Pablo", LastName="Marí"},
                new Player{FirstName="Granit", LastName="Xhaka"},
                new Player{FirstName="Cedric", LastName="Soares"},
                new Player{FirstName="Rob", LastName="Holding"},
                new Player{FirstName="Ainsley", LastName="Maitland"},
                new Player{FirstName="Gabriel", LastName="Magalhães"},
                new Player{FirstName="Edward", LastName="Nketiah"},
                new Player{FirstName="Mohamed", LastName="Elneny"},
                new Player{FirstName="Calum", LastName="Chambers"},
                new Player{FirstName="Matteo", LastName="Guendouzi"},
                new Player{FirstName="William", LastName="Saliba"},
                new Player{FirstName="Rúnar", LastName="Alex"},
                new Player{FirstName="Konstantinos", LastName="Mavropanos"},
                new Player{FirstName="Nuno", LastName="Tavares"},
                new Player{FirstName="Bukayo", LastName="Saka"},
                new Player{FirstName="Emile", LastName="Smith-Rowe"},
                new Player{FirstName="Aaron", LastName="Ramsdale"},
                new Player{FirstName="Martin", LastName="Ødegaard"},
                new Player{FirstName="Arthur", LastName="Okonkwo"},
                new Player{FirstName="Albert", LastName="Sambi"},
                new Player{FirstName="Takehiro", LastName="Tomiyasu"}
            };

            foreach (var player in players)
            {
                context.Players.Add(player);
            }
            context.SaveChanges();

            var cards = new Card[]
            {
                new Card{PlayerId=1,  Overall=78, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=2,  Overall=80, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=3,  Overall=83, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=4,  Overall=77, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=5,  Overall=77, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=6,  Overall=81, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=7,  Overall=82, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=8,  Overall=80, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=9,  Overall=75, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=10, Overall=89, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=11, Overall=76, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=12, Overall=81, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=13, Overall=80, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=14, Overall=70, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=15, Overall=84, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=16, Overall=82, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=17, Overall=91, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=18, Overall=64, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=19, Overall=71, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=20, Overall=85, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=21, Overall=72, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=22, Overall=90, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=23, Overall=88, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=24, Overall=75, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=25, Overall=87, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=26, Overall=66, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=27, Overall=79, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=28, Overall=86, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=29, Overall=85, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=30, Overall=70, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=31, Overall=86, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1},
                new Card{PlayerId=32, Overall=79, Pace=1, Shooting=1, Passing=1, Dribbling=1, Defending=1, Physical=1}
            };

            foreach (var card in cards)
            {
                context.Cards.Add(card);
            }
            context.SaveChanges();
        }
    }
}
