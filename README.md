## About

Simple Microsoft SQL Server connection tester, a command line program written in C# for .NET 4.6 or newer. Uses the System.Data.SqlClient to connect to a server and database specified in the app.config file and retrieves a list of databases. If a connection cannot be made or another error occurs, exceptions are written to the console.

## Configuration

Edit the **test** connection string in app.config, for example:

`<add name="test" connectionString="Data Source=localhost,1433;Initial Catalog=test;Integrated Security=False;User ID=testuser;Password=;Connect Timeout=30"/>`

## Running the test

Open the terminal (command line) window and run **SqlServerTestConnect.exe**

If you do not see the text `Connection successful...`, examine any exceptions printed and check the connection string.

## Troubleshooting

+ [Troubleshoot connecting to the SQL Server Database Engine](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/troubleshoot-connecting-to-the-sql-server-database-engine?view=sql-server-ver15)
+ [Troubleshooting connectivity issues and other errors with Microsoft Azure SQL Database](https://docs.microsoft.com/en-us/azure/sql-database/troubleshoot-connectivity-issues-microsoft-azure-sql-database)

## Query

The following query is hard-coded to prevent abuse (but not meant to deter determined attackers)

`SELECT name FROM sys.databases`

This query will work for any user with `db_datareader` permission on the configured database.

## Author

This tool was written by Mac Plewa.
