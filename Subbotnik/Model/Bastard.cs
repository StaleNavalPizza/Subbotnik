namespace Subbotnik.Model
{
    public class Bastard
    {
        public string Name { get; set; }

        //public string Login { get; set; }

        public string Password { get; set; }


        public Bastard Clone()
        {
            return new Bastard
            {
                Name = Name,
                Password = Password,
            };
        }
    }
}
