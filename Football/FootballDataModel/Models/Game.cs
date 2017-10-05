using System;
using System.Collections.Generic;

namespace FootballDataModel.Models
{
    public class Game
    {
        public int Id { get; set; }
       
        public int HomeTeamId { get; set; }

        public int GuestTeamId { get; set; }

        public DateTime GameDate { get; set; }

        public int HomeTeamGoals { get; set; }

        public int GuestTeamGoals { get; set; }

        public virtual Club HomeTeam { get; set; }

        public virtual Club GuestTeam { get; set; }


        public virtual ICollection<PlayerGame> PlayersInGame { get; set; }
    }
}
