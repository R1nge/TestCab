using UnityEngine;

namespace Game.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private UIConfig uiConfig;
        [SerializeField] private PlayerConfig playerConfig;

        public UIConfig UIConfig => uiConfig;
        public PlayerConfig PlayerConfig => playerConfig;
    }
}