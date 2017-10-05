using System.Collections.Generic;

namespace FootballDataModel.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }


        public virtual ICollection<PlayerClub> PlayerClubs { get; set; }
        public virtual ICollection<PlayerGame> PlayerGames { get; set; }
    }
}
