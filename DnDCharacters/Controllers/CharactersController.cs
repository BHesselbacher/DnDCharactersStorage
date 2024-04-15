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
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            return View(character);
        }
    }
}
