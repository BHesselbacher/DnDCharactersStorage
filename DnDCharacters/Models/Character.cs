namespace DnDCharacters.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Str { get; set; }
        [Required]
        public int Dex { get; set; }
        [Required]
        public int Con { get; set; }
        [Required]
        public int Int { get; set; }
        [Required]
        public int Wis { get; set; }
        [Required]
        public int Cha { get; set; }
    }
}
