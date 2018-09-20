namespace GroupApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        //public string Location { get; set; } // Maybe use some kind of Library to use location finder.//
    }
}