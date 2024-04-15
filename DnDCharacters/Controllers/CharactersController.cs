using DnDCharacters.Database;
using DnDCharacters.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacters.Controllers
{
    public class CharactersController : Controller
    {
        private ApplicationDbContext _characterRepository;

        public CharactersController(ApplicationDbContext characterRepository)
        {
            _characterRepository = characterRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Character> characters = _characterRepository.GetAllCharacters();

            return View(characters);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            if (ModelState.IsValid == true)
            {
                _characterRepository.AddCharacter(character);

                return RedirectToAction("Index");
            }

            return View(character);
        }
    }
}
