using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> Provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
            },
            new Province() {    //2
                ProvinceCode = "ON",
                ProvinceName="Ontario",
            },
            new Province() {    // 3
                ProvinceCode = "QC",
                ProvinceName = "Quebec",
            }
        };

        return Provinces;
    }

    public static List<City> GetCities() {
        List<City> Cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population= 2000000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Surrey",
                Population= 300000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Burnaby",
                Population= 400000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Toronto",
                Population= 3000000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 5,
                CityName = "Ottawa",
                Population= 1000000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 6,
                CityName = "Niagra Falls",
                Population= 100000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 7,
                CityName = "Montreal",
                Population= 1500000,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 8,
                CityName = "Quebec City",
                Population= 500000,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 9,
                CityName = "Saguenay",
                Population= 150000,
                ProvinceCode = "QC"
            },
        };

        return Cities;
    }
}
}