using System.IO;
using Game.Configs;
using Unity.Serialization.Json;
using UnityEngine;

namespace Game.Services
{
    public class PlayerDataProviderJson : IPlayerDataProvider
    {
        private static string DATA_PATH = Path.Combine(Application.persistentDataPath, "SaveData.json");
        private readonly ConfigProvider _configProvider;

        public PlayerDataProviderJson(ConfigProvider configProvider)
        {
            _configProvider = configProvider;
        }

        public PlayerDataModel Load()
        {
            Debug.Log(DATA_PATH);

            PlayerDataModel data;

            if (File.Exists(DATA_PATH))
            {
                using (StreamReader reader = new(DATA_PATH))
                {
                    string json = reader.ReadToEnd();
                    
                    if (json == "{}")
                    {
                        Debug.LogWarning("Data doesn't exist. Creating a new one");
                        data = new PlayerDataModel(_configProvider.PlayerConfig.Health, 0, 0);
                    }
                    else
                    {
                        data = JsonSerialization.FromJson<PlayerDataModel>(json);
                        data.Health = _configProvider.PlayerConfig.Health;
                    }
                }
            }
            else
            {
                Debug.LogWarning("Data doesn't exist. Creating a new one");
                data = new PlayerDataModel(_configProvider.PlayerConfig.Health, 0, 0);
            }

            return data;
        }

        public void Save(PlayerDataModel data)
        {
            string json = JsonSerialization.ToJson(data);
            File.WriteAllText(DATA_PATH, json);
        }
    }
}