
// See https://aka.ms/new-console-template for more information
using System.Data.OleDb;

Console.WriteLine("Hello, World!");

var conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\grippst1\\OneDrive - Reti\\Documents\\Databasestetitoli.accdb;");
conn.Open();
var cmd = new OleDbCommand("SELECT * FROM DossierTitoli", conn);
var reader = cmd.ExecuteReader();
reader.Read();
Console.WriteLine(reader["Titolo"]);
conn.Close();
