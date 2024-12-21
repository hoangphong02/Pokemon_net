namespace Pokemon.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }

    }
}


//public class City
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int CountryId { get; set; } // Foreign key
//    public Country Country { get; set; }
//}

//public class Country
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<City> Cities { get; set; } // One-to-many relationship
//}

//City.Country: Đại diện cho mối quan hệ nhiều-một, nơi mỗi City thuộc về một Country.
//Country.Cities: Đại diện cho mối quan hệ một-nhiều, nơi một Country có thể chứa nhiều City.