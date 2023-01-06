using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TOPIC_Resume.Data;
using TOPIC_Resume.Entities;

namespace TOPIC_Resume
{
    public static class StaticUtilities
    {
        /// <summary>
        /// Enumerator for different database providers
        /// </summary>
        public enum DbProviderEnum
        {
            MySQL,
            MSSQL,
            SQLite,
            PostGreSQL
        }

        public static CustomIdentityUser GetCustomIdentityUser(this ApplicationDbContext applicationDbContext, AuthenticationState userAuth)
        {
            var userId = userAuth.User.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
            var user = applicationDbContext.Users.Find(userId);
            if (user is null)
            {
                throw new NullReferenceException($"ERROR: User with ID:{userId} not found!");
            }
            return user;
        }

        /// <summary>
        /// Creates a specific DbContext depending on settings. Currently only needed at design-time.
        /// </summary>
        /// <param name="configuration">A complete app configuration</param>
        /// <param name="assemblyType">Assembly type of calling app - specifies where migrations are generated</param>
        /// <returns>Specified database provider as MaddDbContext</returns>
        public static ApplicationDbContext SetupDatabase(IConfiguration configuration)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            SetupDatabaseBuilder(dbContextBuilder, configuration);

            //if (!Enum.TryParse(configuration.GetSection("DatabaseProvider").Value, out DbProviderEnum providerEnum))
            //{
            //    throw new Exception("ERROR: It seems an incorrect database provider type was set:" + configuration.GetSection("DatabaseProvider").Value);
            //}

            return new ApplicationDbContext(dbContextBuilder.Options);

            //Old approach with subcontexts
            //return providerEnum switch
            //{

            //    DbProviderEnum.MSSQL => new MSSQLDbContext(dbContextBuilder.Options),
            //    DbProviderEnum.MySQL => new MySQLDbContext(dbContextBuilder.Options),
            //    DbProviderEnum.SQLite => new SQLiteDbContext(dbContextBuilder.Options),
            //    DbProviderEnum.PostGreSQL => new PostGreSQLDbContext(dbContextBuilder.Options),
            //    _ => throw new ArgumentOutOfRangeException(nameof(DbProviderEnum), "Enumerator out of bounds!")
            //};
        }

        /// <summary>
        /// Prepares options builder with all the required settings
        /// </summary>
        /// <param name="builder">Builder for settings to be applied to</param>
        /// <param name="configuration">Application configuration object</param>
        /// <param name="assemblyType">Typeof assembly where the migrations are to be created</param>
        public static void SetupDatabaseBuilder(this DbContextOptionsBuilder builder, IConfiguration configuration)
        {
            builder.UseLazyLoadingProxies();
            if (!Enum.TryParse(configuration.GetSection("DatabaseProvider").Value, out DbProviderEnum providerEnum))
            {
                throw new Exception("ERROR: It seems an incorrect database provider type was set:" + configuration.GetSection("DatabaseProvider").Value);
            }
            switch (providerEnum)
            {
                case DbProviderEnum.MSSQL:
                    builder.UseSqlServer(GenerateSectionKey(providerEnum, configuration));
                    break;
                case DbProviderEnum.MySQL:
                    builder.UseMySql(GenerateSectionKey(providerEnum, configuration), new MySqlServerVersion(new Version(8, 0, 29)));
                    break;
                case DbProviderEnum.SQLite:
                    builder.UseSqlite(GenerateSectionKey(providerEnum, configuration));
                    break;
                case DbProviderEnum.PostGreSQL:
                    builder.UseNpgsql(GenerateSectionKey(providerEnum, configuration),
                        optionsBuilder => optionsBuilder.SetPostgresVersion(9, 9));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(configuration), "ERROR: Db selection enum out of range!");
            }
        }

        /// <summary>
        /// Returns a key to access provider specific connection string.
        /// </summary>
        /// <param name="dbType">Type of database connection string required</param>
        /// <param name="configuration">Configuration from which to extract the connection string</param>
        /// <returns>Connection string for the specified db provider</returns>
        private static string GenerateSectionKey(DbProviderEnum dbType, IConfiguration configuration)
        {
            //Simpler approach but less customisable
            return configuration.GetConnectionString(dbType + "ConnString");

            //return dbType switch
            //{
            //    DbProviderEnum.MSSQL => configuration.GetConnectionString("MSSQLConnString"),
            //    DbProviderEnum.SQLite => configuration.GetConnectionString("SQLiteConnString"),
            //    DbProviderEnum.MySQL => configuration.GetConnectionString("MySQLConnString"),
            //    DbProviderEnum.PostGreSQL => configuration.GetConnectionString("PostGreSQLConnString"),
            //    _ => throw new Exception("Database provider supports only these values: MSSQL, SQLite, MySQL or PostGreSQL. Provided: " + dbType)
            //};
        }
    }
}
