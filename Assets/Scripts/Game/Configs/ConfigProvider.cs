using UnityEngine;

namespace Game.Configs
{
    public class ConfigProvider : MonoBehaviour
    {
        [SerializeField] private UIConfig uiConfig;

        public UIConfig UIConfig => uiConfig;
    }
}