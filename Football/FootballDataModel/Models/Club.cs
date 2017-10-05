using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataModel.Models
{
    public class Club
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual League League { get; set; }


        public virtual ICollection<PlayerClub> PlayersClub { get; set; }

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Game> HomeGames { get; set; }

        [InverseProperty("GuestTeam")]
        public virtual ICollection<Game> GuestGames { get; set; }
    }
}
