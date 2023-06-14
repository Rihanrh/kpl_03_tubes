using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AccountManager
{
    public class Config
    {
        public string tipe_akun { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Config() { }

        public Config(string tipe_akun, string username, string password)
        {
            this.tipe_akun = tipe_akun;
            this.username = username;
            this.password = password;
        }
    }

    public class AccountConfig
    {
        public List<Config> configs;
        public const string filePath = @"./acc_config.json";

        public AccountConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        public List<Config> ReadConfigFile()
        {
            string configJsonData = File.ReadAllText(filePath);
            configs = JsonSerializer.Deserialize<List<Config>>(configJsonData);
            return configs;
        }

        private void SetDefault()
        {
            configs = new List<Config>
            {
                new Config("Pembeli", "username", "password")
            };
        }

        public void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(configs, options);
            File.WriteAllText(filePath, jsonString);
        }

    }
}
