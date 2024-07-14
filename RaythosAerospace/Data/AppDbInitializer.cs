using RaythosAerospace.Models;

namespace RaythosAerospace.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();

                context.Database.EnsureCreated();

                // Seed the database with initial data 
                if (!context.User.Any())
                {
                    context.User.Add(new User { UserName = "Admin", Password = "!@#$1234", Email = "admin@raythos.com", Role = UserRoles.Admin, ProfilePictureURL= "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxAQEA8ODxAPDhEODQ0NDw8ODw8PDw4QFREWFhUSExMYHSggGBolGxMTITEhJSkrLi4uFx8zODMsNygtLisBCgoKBQUFDgUFDisZExkrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrKysrK//AABEIAOEA4QMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAAAwQBAgUGB//EADMQAQACAQEGAwcCBgMAAAAAAAABAgMRBAUhMVFxEkGRIjJhgaGxwVLhQnKSstHwI4Ki/8QAFAEBAAAAAAAAAAAAAAAAAAAAAP/EABQRAQAAAAAAAAAAAAAAAAAAAAD/2gAMAwEAAhEDEQA/APuIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAxMseOOsA2GvjjrDMSDIAAAAAAAAAAAAAAAAAAAAADFrRHNFfL09UUyCW2bp9Uc3nq1AAAAAbReeqSubr9EIC1W8TybKaWmXqCcYiWQAAAAAAAAAAAAAJBiZV8mTXsZL69mgAAAAAAAAAAAANqX0Wa21VG1LaAtDETrxZAAAAAAAAAAAQ5r+XqltbSNVWZBgAAABply1pGtp0+89mcl4rE2nlEauJtGab21n5R0gFjPvG0+77Mesqtstp52tPeZagNq5LRytaO0ysYd4Xrz9qPjz9VUB3cGet41rPePOEjgYsk1mLRwmP8AdHb2fNF6xaPnHSegJAAAAS4b+XVOprOO2sA3AAAAAAAAABDnnlHzQtsk6zLUAAAAHO3rl92n/afw56xvGf8Akt8IrH0VwAAAAFzdeXS3h8rR9YU0myzpen81fuDugAAAJcE8dOqJmJ04gtgAAAAAAAMSy1vynsCqAAAAADkbzrpkmesRP4/Cq6u88OtYtHOvP+VygAAAAE2x11yUj46+nFC6G6sPPJPav5kHRAAAAABaxzwjs2aYeUNwAAAAAAGt+U9mzEgqAAAAAAOTtuxzXW1eNf7f2dYB54dbPu+luMezPw5eirbdt/Kaz85gFMXK7tv5zWPnM/hYw7urHG0+L4coBT2TZZvPSsc56/CHYrWIiIjhERpDMRpwjgAAAAAAAs4eUN2uOOEdmwAAAAAAAAKt40me7VNnjlPyQgAAAADTLlrSNbTp957Odm3jaeFI8MdZ4z+wOojnPSOd6/1Q4l8k296ZnvLUHdjaKT/HT+qEkTry49nnma2mOUzHadAegHJw7wvHve1HpPq6ODaK3j2Z7xPOASgAAAMxDCTDXj2BYgAAAAAAAAAGt66xoqriDNXzBEAAg2vaYxx1tPKPzKTPlilZtPl9ZcPLkm0zaec/7oBkyTadbTrLUAAAAAGa2mJ1iZiY84YAdfYtr8fCeFo9J+MLTz1bTExMcJjjEu3smfx11844Wj4gmAAWcVdI78UWKms9lgAAAAAAAAAABiYZAVb00ardq6q166cwcnemXW0U8q8Z7ypNsl/FM26zMtQAAAAAAAAFnd+Xw3jpb2Z/CsA9CzWuvBrs8+OKzHnET2W6U0BmtdI0ZAAAAAAAAAAAAABi9YmJieUxpLIDhbZuu1dZpravT+KP8ue9arbTsNMnGY0n9VeE/uDzY6GfdN6+7pePSVHJitX3qzXvEwDUAAAAZpSbcKxM9omV3BurJb3tKR8eM+kAorux7tvfjPsV6zzntDqbNu7HTjp4p62/ELgNMOKKViteUcIbgAAAAAAAAAAAAAAAAAAAxMMgIL7HjnnSvpEfZFO7MP6fS1v8rgCnG7MP6f8A1ZJTYsUcqV+ca/dYAYrWI4RGnbgyAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP/Z" });
                    context.SaveChanges();
                }
                if (!context.Aircraft.Any())
                {
                    context.Aircraft.AddRange(new List<Aircraft>()
                    {
                        new Aircraft {
                            ModelName = "CHALLENGER 3500",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/aircraft-challenger3500.png",
                            BasePrice = 3400000,
                            Specifications = "882 KM/H",
                            Status = true
                        },
                        new Aircraft {
                            ModelName = "CHALLENGER 6500",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/aircraft-challenger650.png",
                            BasePrice = 4000000,
                            Specifications = "893 KM/H",
                            Status = true
                        },
                        new Aircraft {
                            ModelName = "GLOBAL 5500",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/aircraft-global5500_0.png",
                            BasePrice = 5900000,
                            Specifications = "956 KM/H",
                            Status = true
                        },
                        new Aircraft {
                            ModelName = "GLOBAL 6500",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/Global6500_silhouette_rightside_2.png",
                            BasePrice = 6600000,
                            Specifications = "956 KM/H",
                            Status = true
                        },
                        new Aircraft {
                            ModelName = "GLOBAL 7500",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/DDBA0457_Global7500_RightSide_V1_0_1.png",
                            BasePrice = 7700000,
                            Specifications = "982 KM/H",
                            Status = true
                        },
                        new Aircraft {
                            ModelName = "GLOBAL 8000",
                            ImageURL = "https://bombardier.com/sites/default/files/2024-04/Global8000_RightSide_0.png",
                            BasePrice = 8000000,
                            Specifications = "14,816 KM/H",
                            Status = true
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Inventory.Any())
                {
                    context.Inventory.AddRange(new List<Inventory>()
                    {
                        new Inventory {
                            AircraftId = 1,
                            Quantity = 10,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        },
                        new Inventory {
                            AircraftId = 2,
                            Quantity = 8,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        },
                        new Inventory {
                            AircraftId = 3,
                            Quantity = 6,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        },
                        new Inventory {
                            AircraftId = 4,
                            Quantity = 4,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        },
                        new Inventory {
                            AircraftId = 5,
                            Quantity = 2,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        },
                        new Inventory {
                            AircraftId = 6,
                            Quantity = 2,
                            RestockDate = DateTime.Parse("2024-12-01"),
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
