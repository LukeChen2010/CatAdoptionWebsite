using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAdoptionWebsite.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public bool SpayedNeutered { get; set; }
        public bool IsAdopted { get; set; }
    }
}
