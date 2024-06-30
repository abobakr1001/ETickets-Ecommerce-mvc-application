using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ETickets.Models
{
    public class actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; } 

    }
}
