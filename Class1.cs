using Dapper;
using System.Data.SQLite;

namespace M7P1;

internal class Class1
{
    string connectionString = "Data Source=database.db;";


    public void PrintAllBuyers(DataGridView dataGridView1)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var customers = connection.Query<Customer>("SELECT * FROM Customers").ToList();

            dataGridView1.DataSource = customers;
        }
    }

    public void PrintAllEmails(DataGridView dataGridView1)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var emails = connection.Query("SELECT CustomerId, Email FROM Customers").Select(row => new { CustomerId = row.CustomerId, Email = row.Email }).ToList();

            dataGridView1.DataSource = emails;
        }
    }

    public void PrintAllDistinctSections(DataGridView dataGridView1)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var sections = connection.Query<Interest>("SELECT Section FROM Interests").Select(row => new { Section = row.Section }).ToList();

            dataGridView1.DataSource = sections;
        }
    }

    public void PrintListOfPromotionalProducts(DataGridView dataGridView1)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var promotedItems = connection.Query("SELECT ItemName FROM PromotedItems").Select(row => new { ItemName = row.ItemName }).ToList();

            dataGridView1.DataSource = promotedItems;
        }
    }

    public void PrintAllCities(DataGridView dataGridView1)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var cities = connection.Query("SELECT City FROM Customers").Select(row => new { City = row.City }).ToList();

            dataGridView1.DataSource = cities;
        }
    }

    public void PrintAllCountries(DataGridView dataGridView1)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var countries = connection.Query("SELECT Country FROM Customers").Select(row => new { Country = row.Country }).ToList();

            dataGridView1.DataSource = countries;
        }
    }

    public void PrintAllBuyersFromCertainCity(DataGridView dataGridView1, string city)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var customers = connection.Query<Customer>("SELECT * FROM Customers WHERE City = @City", new { City = city }).ToList();

            dataGridView1.DataSource = customers;
        }
    }

    public void PrintAllBuyersFromSpecificCountry(DataGridView dataGridView1, string country)
    {

        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var customers = connection.Query<Customer>("SELECT * FROM Customers WHERE Country = @Country", new { Country = country }).ToList();

            dataGridView1.DataSource = customers;
        }
    }

    public void PrintAllPromotionsForSpecificCountry(DataGridView dataGridView1, string country)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            var promotions = connection.Query<Promotion, PromotedItem, Promotion>(
                @"SELECT * FROM Promotions
              JOIN PromotedItems ON Promotions.PromotionId = PromotedItems.PromotionId
              WHERE Promotions.Country = @Country",
                (promotion, promotedItem) =>
                {
                    promotion.PromotedItems.Add(promotedItem);
                    return promotion;
                },
                new { Country = country },
                splitOn: "PromotedItemId"
            ).Distinct().ToList();

            dataGridView1.DataSource = promotions;
        }
    }


}
