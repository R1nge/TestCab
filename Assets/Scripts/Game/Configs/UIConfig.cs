using UnityEngine;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "UI Config", menuName = "Configs/UI Config")]
    public class UIConfig : ScriptableObject
    {
        [SerializeField] private GameObject mainMenuUI, inGameUI, gameOverUI;
        
        public GameObject MainMenuUI => mainMenuUI;
        public GameObject InGameUI => inGameUI;
        public GameObject GameOverUI => gameOverUI;
    }
}