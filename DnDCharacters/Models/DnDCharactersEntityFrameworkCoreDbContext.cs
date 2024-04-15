using DnDCharacters.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacters.Models
{
    public class DnDCharactersEntityFrameworkCoreDbContext : DbContext, ApplicationDbContext
    {
        public DnDCharactersEntityFrameworkCoreDbContext(DbContextOptions<DnDCharactersEntityFrameworkCoreDbContext> options)
            : base(options) { }

        DbSet<Character> Characters { get; set; }

        public void AddCharacter(Character character)
        {
            Characters.Add(character);
            SaveChanges();
        }

        public List<Character> GetAllCharacters()
        { 
            return Characters.ToList();
        }
    }
}
