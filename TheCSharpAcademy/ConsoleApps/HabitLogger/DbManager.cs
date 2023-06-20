using System.Data.SQLite;

namespace HabitLogger;

public class DbManager
{
    readonly private string _DbName;
    SQLiteConnection _connection;

    public DbManager(string dbName)
    {
        _DbName = dbName;
        TestDBConnection();
        _connection = new SQLiteConnection($"Data Source={_DbName}");
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
        //create the table within the db if it doesn't exist:

        string createTable = "CREATE TABLE IF NOT EXISTS workouts (PRIMARYKEY INTEGER, distance VARCHAR, timeTaken VARCHAR, Date DATETIME)";
    }
}
