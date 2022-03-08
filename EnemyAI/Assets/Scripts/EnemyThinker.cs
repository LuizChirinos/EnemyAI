using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.AI
{
    public class EnemyThinker : MonoBehaviour
    {
        [SerializeField] private EnemyBrain enemyBrain;

        public EnemyBrain EnemyBrain { get => enemyBrain; }

        public void WakeUp()
        {
            enemyBrain.Initialize(this);
        }
        public void Sleep()
        {
            enemyBrain.Deactivate(this);
        }

        private void OnEnable()
        {
            WakeUp();
        }
        private void OnDisable()
        {
            Sleep();
        }
    }
}