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
    public class ResultRepositroy : IResultRepository
    {
        private readonly string _dbPath = DbConstans.RESULTS_DB;
        public bool Create(Result obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var results = JsonConvert.DeserializeObject<List<Result>>(json);
                results.Add(obj);
                json = JsonConvert.SerializeObject(results, Formatting.Indented);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Result Get(Guid id)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var results = JsonConvert.DeserializeObject<List<Result>>(json);

                return results.FirstOrDefault(user => user.UserId == id);
            }
            catch
            {
                return null;
            }
        }

        public IList<Result> GetAll()
        {
            string json = File.ReadAllText(_dbPath);
            var results = JsonConvert.DeserializeObject<List<Result>>(json);
            return results;
        }

        public bool Update(Guid id, Result obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var results = JsonConvert.DeserializeObject<List<Result>>(json);

                for (int i = 0; i < results.Count; i++)
                    if (results[i].UserId == id)
                        results[i] = obj;

                File.WriteAllText(_dbPath, JsonConvert.SerializeObject(results, Formatting.Indented));

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
