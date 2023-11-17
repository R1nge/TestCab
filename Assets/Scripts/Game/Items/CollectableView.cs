using Game.Services;
using UnityEngine;
using Zenject;

namespace Game.Items
{
    [RequireComponent(typeof(Rigidbody))]
    public class CollectableView : MonoBehaviour, ICollectable
    {
        [SerializeField] private int score = 1;
        private ScoreService _scoreService;

        [Inject]
        private void Inject(ScoreService scoreService) => _scoreService = scoreService;

        public void Collect()
        {
            _scoreService.AddScore(score);
            Destroy(gameObject);
        }
    }
}