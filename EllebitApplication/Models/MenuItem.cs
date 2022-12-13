using System.ComponentModel.DataAnnotations;

namespace EllebitApplication.Models
{
    public class MenuItem
    {
        [Key]
        public int itemID { get; set; }
        public string name { get; set; }
        public float cost { get; set; }
        public string description { get; set; }

        MenuItem(int itemID, string name, float cost)
        {
            this.itemID = itemID;
            this.name = name;
            this.cost = cost;
        }
    }
}
