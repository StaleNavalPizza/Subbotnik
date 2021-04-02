
namespace Subbotnik.Model
{
    public class Bastard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public string Login { get; set; }

        public string Password { get; set; }

        public Bastard()
        { }


        // NOTE: this shit is only usefull in the repo-mock setup!
        public Bastard Clone()
        {
            return new Bastard
            {
                Id = Id,
                Name = Name,
                Password = Password,
            };
        }
    }
}
