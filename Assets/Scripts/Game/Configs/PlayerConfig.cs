using UnityEngine;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "Player Configs", menuName = "Configs/Player Config")]
    public class PlayerConfig : ScriptableObject
    {
        [SerializeField] private int health;
        public int Health => health;
    }
}