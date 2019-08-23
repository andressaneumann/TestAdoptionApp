using System;
namespace TestAdoptionApp.Models
{
    public class Pet
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvaliableToAdoption { get; set; }


        public Pet()
        {
        }
    }
}
