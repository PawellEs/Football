using System.Collections.Generic;

namespace FootballDataModel.Models
{
    public class League
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Club> Clubs { get; set; }
    }
}
