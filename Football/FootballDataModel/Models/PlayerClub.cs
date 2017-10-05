using System;

namespace FootballDataModel.Models
{
    public class PlayerClub
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public int ClubId { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime? LeaveDate { get; set; }

        public float TransferValue { get; set; }


        public virtual Player Player { get; set; }
        public virtual Club Club { get; set; }
    }
}
