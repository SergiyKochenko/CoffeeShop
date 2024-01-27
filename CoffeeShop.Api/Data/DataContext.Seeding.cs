using Microsoft.EntityFrameworkCore;
using CoffeeShop.Api.Data.Entities;

namespace CoffeeShop.Api.Data
{
    public partial class DataContext
    {
        public void SeedData(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Category>()
                .HasData(
					new Category(1, "Burgers", "burgers.png"),
					new Category(2, "Dessarts", "desserts.png"),
					new Category(3, "Drinks", "drinks.png"),
					new Category(4, "Non-Veg", "nonveg.png"),
					new Category(5, "Pizza", "pizza.png"),
					new Category(6, "Rice", "rice.png"),
					new Category(7, "Seafood", "seafood.png"),
					new Category(8, "Soups", "soups.png"),
					new Category(9, "Veg", "veg.png")

				);

			modelBuilder.Entity<Offer>()
				.HasData(
					new Offer(1, "50 Percent Off", "percent_50p.npg", "50 Percent off on all food items", "OFF-50", OfferType.Percentage, 50, null, DateTime.Now.AddDays(7)),
					new Offer(2, "Hot Offer", "hot_offer.png", "Hot Offer", "HOT-80", OfferType.Percentage, 80, null, DateTime.Now.AddDays(2)),
					new Offer(3, "Up to 25% OFF", "upto_25_percent.png", "Upto 25 OFF", "UPTO-25", OfferType.Percentage, 25, 500, null, "Yellow"),
					new Offer(4, "Half Price", "half_price.png", "Half Price", "HALF", OfferType.Percentage, 50, 1000, DateTime.Now.AddDays(2), "Red"),
					new Offer(5, "Flat Euros 100 off Today Only", "today_only.png", "Flat Euros 100 Off Today Only", "100-TODAY", OfferType.Flat, 100, null, DateTime.Today),
					new Offer(6, "30% OFF", "thirty_percent.png", "50", "OFF", OfferType.Percentage, 30, 300, DateTime.Now.AddMonths(1), "#FFFFFF"),
					new Offer(7, "Special Festival Offer", "special_offer.png", "Special Festival Offer", "FEST-150", OfferType.Flat, 150, null, DateTime.Now.AddDays(5)),
					new Offer(8, "SALE 40% OFF", "sale_40_percent.png", "SALE 40% OFF", "SALE-40", OfferType.Percentage, 40, null, DateTime.Now.AddDays(4), "Gray"),
					new Offer(9, "50% OFF", "fifty_percent_off.png", "50% OFF", "OFF-50", OfferType.Percentage, 50, null, DateTime.Today)
				);
        }
    }
}
