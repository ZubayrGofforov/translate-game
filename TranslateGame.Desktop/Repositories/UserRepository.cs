using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TranslateGame.Desktop.Contans;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _dbPath = DbConstans.USERS_DB;
        public bool Create(User obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Users = JsonConvert.DeserializeObject<List<User>>(json);
                Users.Add(obj);
                json = JsonConvert.SerializeObject(Users, Formatting.Indented);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User Get(Guid id)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Users = JsonConvert.DeserializeObject<List<User>>(json);

                return Users.FirstOrDefault(user => user.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public IList<User> GetAll()
        {
            string json = File.ReadAllText(_dbPath);
            var Users = JsonConvert.DeserializeObject<List<User>>(json);
            return Users;
        }

        public User GetByUsername(string username)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Users = JsonConvert.DeserializeObject<List<User>>(json);

                return Users.FirstOrDefault(x => x.Username == username);
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Guid id, User obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Users = JsonConvert.DeserializeObject<List<User>>(json);

                for (int i = 0; i < Users.Count; i++)
                    if (Users[i].Id == id)
                        Users[i] = obj;

                File.WriteAllText(_dbPath, JsonConvert.SerializeObject(Users, Formatting.Indented));

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
