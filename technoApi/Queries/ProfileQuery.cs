using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using technoApi.Models;

namespace technoApi.Queries
{
    public class ProfileQuery
    {
        public readonly AppDb Db;
        public IConfiguration Configuration { get; }

        public ProfileQuery(IConfiguration configuration)
        {
            Configuration = configuration;
            Db = new AppDb(Configuration);
        } 
        
        
        public async Task<List<Profile>> AllProfilesASync()
        {
            using (Db)
            {
               await Db.Connection.OpenAsync();
               var cmd = Db.Connection.CreateCommand();
               cmd.CommandText = @"SELECT id, firstName, lastName, email, mobile, address1, address2, " +
                                 " city, county, postCode FROM `Profiles` ORDER BY `Id` DESC LIMIT 10;";
               return await ReadAllAsync(await cmd.ExecuteReaderAsync());
            }
            
        }
        
        private async Task<List<Profile>> ReadAllAsync(DbDataReader reader)
        {
            var posts = new List<Profile>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var post = new Profile(Db)
                    {
                        Id = await reader.GetFieldValueAsync<int>(0),
                        FirstName = await reader.GetFieldValueAsync<string>(1),
                        LastName = await reader.GetFieldValueAsync<string>(2),
                        Email = await reader.GetFieldValueAsync<string>(3),
                        Mobile = await reader.GetFieldValueAsync<string>(4),
                        Address1 = await reader.GetFieldValueAsync<string>(5),
                        Address2 = await reader.GetFieldValueAsync<string>(6),
                        City = await reader.GetFieldValueAsync<string>(7),
                        County = await reader.GetFieldValueAsync<string>(8),
                        PostCode = await reader.GetFieldValueAsync<string>(9)
                    };
                    posts.Add(post);
                }
            }
            return posts;
        }
    }
}