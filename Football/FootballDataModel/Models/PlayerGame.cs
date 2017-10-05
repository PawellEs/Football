using System;

namespace FootballDataModel.Models
{
    public class PlayerGame
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public int PlayerId { get; set; }

        public string PlayerPosition { get; set; }  // powinien byc enum pozniej wg mnie

        public TimeSpan PlayerEntryTime { get; set; }

        public TimeSpan PlayerLeaveTime { get; set; }


        public virtual Game Game { get; set; }

        public virtual Player Player { get; set; }
    }
}
