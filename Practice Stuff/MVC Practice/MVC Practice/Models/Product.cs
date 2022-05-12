namespace MVC_Practice.Models
{
    //This is a SQL table
    public class Product
    {
        //Entity Framework will automatically recognize this is a primary key AND auto increment it
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
