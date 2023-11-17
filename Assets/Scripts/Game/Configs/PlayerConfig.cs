using UnityEngine;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "Player Configs", menuName = "Configs/Player Config")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private int health;
        public GameObject PlayerPrefab => playerPrefab;
        public int Health => health;
    }
}