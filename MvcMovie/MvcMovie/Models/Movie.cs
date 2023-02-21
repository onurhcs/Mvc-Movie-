using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

        //public int Id { get; set; }

        //public void IdBildir()
        //{
        //    int okunan = Id;
        //    MailAt(okunan);
        //}

        //private int _id;

        //public int Id 
        //{
        //    get
        //    {
        //        return _id;
        //    }
        //    set
        //    { 
        //        _id = value; 
        //    }
        //}
    }
}
