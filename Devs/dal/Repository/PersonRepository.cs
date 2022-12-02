using Dapper;
using Domain;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        private ConfigurationConnection _connectionString;
        public PersonRepository(ConfigurationConnection connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection Connection()
        {
            return new MySqlConnection(_connectionString.connectionString);
        }

        public async Task<IEnumerable<Person>> GetPeople()
        {
            var connection = Connection();
            var sql = @"SELECT name, lastName, role 
                        FROM people";

            return await connection.QueryAsync<Person>(sql);
        }

        public async Task<bool> InsertPerson(Person person)
        {
            var connection = Connection();
            var sql = @"INSERT INTO people (name, lastName, role) 
                        VALUES (@name, @lastName, @role);";

            return await connection.ExecuteAsync(sql, new { person.name, person.lastName, person.role }) > 0;
        }
    }
}
