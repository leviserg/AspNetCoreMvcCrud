using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public Microsoft.AspNetCore.Identity.IdentityUser AplicationUser { get; set; }

        public Joke()
        {

        }
    }

    public class ModelExt
    {
        public int JokeId { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        public string UserName { get; set; }

        public ModelExt()
        {

        }
    }
}
