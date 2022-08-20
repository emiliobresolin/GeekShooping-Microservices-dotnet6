using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camiseta No Internet",
                Price = new decimal(69.9),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Capacete Darth Vader Star Wars Black Series",
                Price = new decimal(999.99),
                Description = "An action figure is a poseable character model figure made most commonly of plastic, and often based upon characters from a film, comic book, military, video game or television program; fictional or historical. These figures are usually marketed toward boys and adult collectors.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                Price = new decimal(189.99),
                Description = "An action figure is a poseable character model figure made most commonly of plastic, and often based upon characters from a film, comic book, military, video game or television program; fictional or historical. These figures are usually marketed toward boys and adult collectors.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Gamer",
                Price = new decimal(69.99),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta SpaceX",
                Price = new decimal(49.99),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camiseta Feminina Coffee Benefits",
                Price = new decimal(69.9),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Moletom Com Capuz Cobra Kai",
                Price = new decimal(159.9),
                Description = "A loose, long-sleeved, collarless pullover of soft, absorbent fabric, as cotton jersey, with close-fitting or elastic cuffs and sometimes a drawstring at the waist, commonly worn during athletic activity for warmth or to induce sweating.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                CategoryName = "Sweatshirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Livro Star Talk – Neil DeGrasse Tyson",
                Price = new decimal(49.9),
                Description = "A good book description is a detailed, descriptive copy that is good for public display, used for your book marketing, book discovery, and for sales purposes. It helps potential buyers find and understand your book. It's your pitch. Your chance to get people interested.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true",
                CategoryName = "Book"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Price = new decimal(359.99),
                Description = "An action figure is a poseable character model figure made most commonly of plastic, and often based upon characters from a film, comic book, military, video game or television program; fictional or historical. These figures are usually marketed toward boys and adult collectors.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                Price = new decimal(59.99),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Camiseta GNU Linux Programador Masculina",
                Price = new decimal(59.99),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Camiseta Goku Fases",
                Price = new decimal(59.99),
                Description = "A T-shirt, or tee, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean.",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg",
                CategoryName = "T-shirt"
            });
        }
    }
}
