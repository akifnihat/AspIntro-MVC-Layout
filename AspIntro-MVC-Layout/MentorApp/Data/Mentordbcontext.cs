using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Data
{
    public class Mentordbcontext: DbContext
    {
        public Mentordbcontext(DbContextOptions<Mentordbcontext> options) : base(options)
        {

        }
        public DbSet<Atributes> Atributess { get; set; }



    }
}
