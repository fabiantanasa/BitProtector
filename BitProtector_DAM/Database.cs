using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BitProtector_DAM
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contact>().Wait();
            //_database.DropTableAsync<Contact>().Wait();     *---Pentru a sterge toate elementele din baza de date---*
        }

        public Task<List<Contact>> GetContactsAsync()
        {
            return _database.Table<Contact>().ToListAsync();
        }

        public Task<int> SaveContactAsync(Contact contact)
        {
            return _database.InsertAsync(contact);
        }

    }
}
