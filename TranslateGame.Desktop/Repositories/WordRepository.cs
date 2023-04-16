using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TranslateGame.Desktop.Contans;
using TranslateGame.Desktop.Enums;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Models;

namespace TranslateGame.Desktop.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly string _dbPath = DbConstans.WORDS_DB;
        public bool Create(Word obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Words = JsonConvert.DeserializeObject<List<Word>>(json);
                Words.Add(obj);
                json = JsonConvert.SerializeObject(Words, Formatting.Indented);
                File.WriteAllText(_dbPath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Word GetByWord(string word)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Words = JsonConvert.DeserializeObject<List<Word>>(json);

                return Words.FirstOrDefault(w => w.WordName == word);
            }
            catch
            {
                return null;
            }
        }

        public async Task<IList<Word>> GetConfigurated(int count, TestLevel level)
        {
            string json = File.ReadAllText(_dbPath);
            var words = JsonConvert.DeserializeObject<IEnumerable<Word>>(json);

            words = words.Where(w => w.Level == level);
            var rand = new Random();
            var randomList = words.OrderBy(x => rand.Next()).Take(count).ToList();

            return randomList;
        }

        public bool Update(string word, Word obj)
        {
            try
            {
                string json = File.ReadAllText(_dbPath);
                var Words = JsonConvert.DeserializeObject<List<Word>>(json);

                for (int i = 0; i < Words.Count; i++)
                    if (Words[i].WordName == word)
                        Words[i] = obj;

                File.WriteAllText(_dbPath, JsonConvert.SerializeObject(Words, Formatting.Indented));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
