using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodIt.FoodIt.dtos
{
    public class Ingredient
    {
        private int id;
        private string name;
        private string description;
        private string unit;
        private string image;
        private string status;
        private string amount;

        public Ingredient(int id, string name, string description, string unit, string image, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Unit = unit;
            this.Image = image;
            this.Status = status;
        }

        public Ingredient(int id, string name, string description, string amount)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Image { get => image; set => image = value; }
        public string Status { get => status; set => status = value; }
        public string Amount { get => amount; set => amount = value; }
    }
}
