using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DatabaseConfig
{
    public string Host { get; set; }
    public string Port { get; set; }
    public string Database { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string WZPath { get; set; }

    public override string ToString()
    {
        return $"{Host}:{Port} - {Database}";
    }
}

public static class DatabaseConfigManager
{
    private const string ConfigFileName = "DBConfig.json";

    /// <summary>
    /// Saves a list of DatabaseConfig objects to disk as JSON.
    /// </summary>
    public static void Save(List<DatabaseConfig> configs)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true // make file human-readable
        };

        string json = JsonSerializer.Serialize(configs, options);
        File.WriteAllText(ConfigFileName, json);
    }

    /// <summary>
    /// Loads a list of DatabaseConfig objects from disk.
    /// Returns an empty list if file doesn’t exist or is invalid.
    /// </summary>
    public static List<DatabaseConfig> Load()
    {
        if (!File.Exists(ConfigFileName))
            return new List<DatabaseConfig>();

        try
        {
            string json = File.ReadAllText(ConfigFileName);
            var configs = JsonSerializer.Deserialize<List<DatabaseConfig>>(json);
            return configs ?? new List<DatabaseConfig>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading DBConfig: {ex.Message}");
            return new List<DatabaseConfig>();
        }
    }
}