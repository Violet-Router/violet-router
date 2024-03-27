using System.Reflection.Metadata.Ecma335;

namespace VIOLET.ROUTER.Domain.Catalog;

public class Item
{
    public int Id {get; set; }
    public string Name {get; set; }
    public string Description {get; set; }
    public required string Brand { get; set; }
    public decimal Price {get; set; }
    public List<Rating> Ratings {get; set; } = new List<Rating>();
    

    public Item(string name, string description, string brand, decimal price)
    {
        if(string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentException("Name is required");
        }

         if(string.IsNullOrWhiteSpace(Description))
        {
            throw new ArgumentException("Description is required");
        }

         if(string.IsNullOrWhiteSpace(Brand))
        {
            throw new ArgumentException("Brand is required");
        }

        if(Price < 0 || Price == 0)
        {
            throw new ArgumentException("Price cannot be negative or zero.");
        }

    
        Name = name;
        Description = description;
        Brand = brand;
        Price = price;

    }

    public void AddRating(Rating rating)
    {
        Ratings.Add(rating);
    }
}
