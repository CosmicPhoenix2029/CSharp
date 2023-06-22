using System.Data.SQLite;
namespace HabitLogger;
//full disclaimer I used https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=netcore-cli to help me with the SQLite syntax

public class DbManager
{
    readonly private string _DbName;

    public DbManager(string dbName)
    {
        _DbName = dbName;
        TestDBConnection();
        CreateTableIfNotExists();
    }

    public void TestDBConnection()
    {
        //create a db file if one doesnt already exist:
        if (!File.Exists(_DbName))
        {
            SQLiteConnection.CreateFile(_DbName);
        }
    }

    public void CreateTableIfNotExists()
    {
        using var connection = new SQLiteConnection($"Data Source={_DbName}");
        //create the table within the db if it doesn't exist:
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = 
            @"
                CREATE TABLE IF NOT EXISTS runs (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    distance VARCHAR NOT NULL,
                    timeTaken VARCHAR NOT NULL,
                    Date DATETIME
                )
            ;";

        try { command.ExecuteNonQuery(); }
        catch (SQLiteException error){ Console.WriteLine(error.Message); }
        finally { connection.Close(); }  
    }

    public void CreateEntry(string distance, string timeTaken, DateTime date) 
    {
        using var connection = new SQLiteConnection($"Data Source={_DbName}");
        //create the table within the db if it doesn't exist:
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = 
            @$"
                INSERT INTO runs
                VALUES ({distance}, {timeTaken}, {date})
            ";
        //need to add a bit here to check an existing entry with the same parameters doesn't already exist.

        try { command.ExecuteNonQuery(); }
        catch (SQLiteException error) { Console.WriteLine(error.Message); }
        finally { connection.Close(); }
    }

    public void ReadEntry()
    {
        using var connection = new SQLiteConnection($"Data Source={_DbName}");
        //create the table within the db if it doesn't exist:
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = 
            @"
                SELECT * FROM runs
                WHERE 
            ";

        try { command.ExecuteNonQuery(); }
        catch (SQLiteException error) { Console.WriteLine(error.Message); }
        finally { connection.Close(); }
    }

    public void UpdateEntry(string distance, string time)
    {
        using var connection = new SQLiteConnection($"Data Source={_DbName}");
        //create the table within the db if it doesn't exist:
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = 
            @$"
                UPDATE runs
                SET distance = {distance}, time = {time}
            ";

        try { command.ExecuteNonQuery(); }
        catch (SQLiteException error) { Console.WriteLine(error.Message); }
        finally { connection.Close(); }
    }

    public void DeleteEntry(string distance, string time) 
    {
        using var connection = new SQLiteConnection($"Data Source={_DbName}");
        //create the table within the db if it doesn't exist:
        connection.Open();

        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = 
            @$"
                DELETE FROM runs WHERE distance = {distance} AND time = {time}
            ";

        try { command.ExecuteNonQuery(); }
        catch (SQLiteException error) { Console.WriteLine(error.Message); }
        finally { connection.Close(); }
    }
}
