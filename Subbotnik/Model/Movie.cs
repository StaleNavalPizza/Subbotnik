namespace Subbotnik.Model
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Validated { get; set; }

        public int ProductionYear { get; set; }

        //public string Director { get; set; }

        //public string Country { get; set; }

        public string Comment { get; set; }


        public Movie Clone()
        {
            return new Movie
            {
                Id = Id,
                Title = Title,
                Validated = Validated,
                ProductionYear = ProductionYear,
                Comment = Comment,
            };
        }
    }
}
