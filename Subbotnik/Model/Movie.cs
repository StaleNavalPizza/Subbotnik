namespace Subbotnik.Model
{
    public class Movie
    {
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
                Title = Title,
                Validated = Validated,
                ProductionYear = ProductionYear,
                Comment = Comment,
            };
        }
    }
}
