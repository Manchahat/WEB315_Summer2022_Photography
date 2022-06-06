using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Summer2022_Photography.Models
{
    public class photography
    {
        public int ID { get; set; }
        public string name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}