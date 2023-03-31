using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                		new Product
                {
                    Name = "Apple",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2,
                    PictureUrl = "/images/products/apple.jpg",
                    Brand = "Farm Fresh",
                    Type = "Fruit",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pear",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 3,
                    PictureUrl = "/images/products/pear.jpg",
                    Brand = "Happy Harvest",
                    Type = "Fruit",
                    QuantityInStock = 132
                },
                new Product
                {
                    Name = "Cilantro",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 1,
                    PictureUrl = "/images/products/cilantro.jpg",
                    Brand = "Farm Fresh",
                    Type = "Herb",
                    QuantityInStock = 65
                },
                new Product
                {
                    Name = "Pumpkin",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 5,
                    PictureUrl = "/images/products/pumpkin.jpg",
                    Brand = "Gourmet Greens",
                    Type = "Squash",
                    QuantityInStock = 68
                },
                new Product
                {
                    Name = "Blueberries",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 4,
                    PictureUrl = "/images/products/blueberries.jpg",
                    Brand = "Gourmet Greens",
                    Type = "Fruit",
                    QuantityInStock = 53
                },
                new Product
                {
                    Name = "Cabbage",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2,
                    PictureUrl = "/images/products/cabbage.jpg",
                    Brand = "Farm Fresh",
                    Type = "Vegetable",
                    QuantityInStock = 231
                },
                new Product
                {
                    Name = "Corn",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies.",
                    Price = 1,
                    PictureUrl = "/images/products/corn.jpg",
                    Brand = "Happy Harvest",
                    Type = "Vegetable",
                    QuantityInStock = 134
                },
                new Product
                {
                    Name = "Watermelon",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 6,
                    PictureUrl = "/images/products/watermelon.jpg",
                    Brand = "Farm Fresh",
                    Type = "Fruit",
                    QuantityInStock = 43
                },
                new Product
                {
                    Name = "Mango",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5,
                    PictureUrl = "/images/products/mango.jpg",
                    Brand = "Farm Fresh",
                    Type = "Fruit",
                    QuantityInStock = 25
                },
                new Product
                {
                    Name = "Orange",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 2,
                    PictureUrl = "/images/products/orange.jpg",
                    Brand = "Gourmet Greens",
                    Type = "Fruit",
                    QuantityInStock = 24
                },
                new Product
                {
                    Name = "Durian",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 7,
                    PictureUrl = "/images/products/durian.jpg",
                    Brand = "Stinky Soil",
                    Type = "Fruit",
                    QuantityInStock = 74
                },
                new Product
                {
                    Name = "Lychee",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 5,
                    PictureUrl = "/images/products/lychee.jpg",
                    Brand = "Happy Harvest",
                    Type = "Fruit",
                    QuantityInStock = 32
                },
                new Product
                {
                    Name = "Banana",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 4,
                    PictureUrl = "/images/products/banana.jpg",
                    Brand = "Gourmet Greens",
                    Type = "Fruit",
                    QuantityInStock = 153
                },
                new Product
                {
                    Name = "Avocado",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 2,
                    PictureUrl = "/images/products/avocado.jpg",
                    Brand = "Farm Fresh",
                    Type = "Fruit",
                    QuantityInStock = 32
                },
                new Product
                {
                    Name = "Broccoli",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 3,
                    PictureUrl = "/images/products/broccoli.jpg",
                    Brand = "Happy Harvest",
                    Type = "Vegetable",
                    QuantityInStock = 33
                },
                new Product
                {
                    Name = "Lettuce",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 4,
                    PictureUrl = "/images/products/lettuce.jpg",
                    Brand = "Happy Harvest",
                    Type = "Vegetable",
                    QuantityInStock = 53
                },
                new Product
                {
                    Name = "Carrot",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 2,
                    PictureUrl = "/images/products/carrot.jpg",
                    Brand = "Gourmet Greens",
                    Type = "Vegetable",
                    QuantityInStock = 142
                },
                new Product
                {
                    Name = "Mushroom",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 3,
                    PictureUrl = "/images/products/mushroom.jpg",
                    Brand = "Happy Harvest",
                    Type = "Vegetable",
                    QuantityInStock = 86
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}