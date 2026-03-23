namespace RestaurantProject.Models.Entities
{
    public class Products
    {
        public int id { get; set; }

        public string name { get; set; }

        public decimal price { get; set; }  

        public bool nuts { get; set; }  

        public int categoryId { get; set; }

        public int spiciness { get; set; }  
        
        public bool vegetarian { get; set; }

        public string image { get; set; }   
    }
}
