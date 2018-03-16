using System;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace technoApi
{
    public class AppDb : IDisposable
    {
        public IConfiguration Configuration { get; }
        public MySqlConnection Connection;

        public AppDb(IConfiguration configuration)
        {
            Configuration = configuration;
            Connection = new MySqlConnection(Configuration["ConnectionStrings:technoConnection"]);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}