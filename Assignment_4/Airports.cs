using System.ComponentModel.DataAnnotations;

namespace MW_Assignment_4.Entities
{
    public class Airports
    {
        public int airportid { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string icaocode { get; set; }
        public bool ismilitary { get; set; }

    }
}
