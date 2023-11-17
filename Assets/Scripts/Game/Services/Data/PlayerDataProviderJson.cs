using Game.Configs;
using Unity.Serialization.Json;
using UnityEngine;

namespace Game.Services
{
    public class PlayerDataProviderJson : IPlayerDataProvider
    {
        private const string DATA_KEY = "PlayerData";
        private readonly ConfigProvider _configProvider;
        
        public PlayerDataProviderJson(ConfigProvider configProvider)
        {
            _configProvider = configProvider;
        }

        public PlayerDataModel Load()
        {
            PlayerDataModel data;

            string json = PlayerPrefs.GetString(DATA_KEY);

            if (string.IsNullOrEmpty(json))
            {
                Debug.LogWarning("Data doesn't exist. Creating a new one");
                data = new PlayerDataModel(_configProvider.PlayerConfig.Health, 0);
            }
            else
            {
                data = JsonSerialization.FromJson<PlayerDataModel>(json);
            }

            return data;
        }

        public void Save(PlayerDataModel data)
        {
            string json = JsonSerialization.ToJson(data);
            PlayerPrefs.SetString(DATA_KEY, json);
            PlayerPrefs.Save();
        }
    }
}