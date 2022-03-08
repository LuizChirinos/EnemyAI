using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.AI
{
    public abstract class EnemyBrain : ScriptableObject
    {
        public abstract void Initialize(EnemyThinker enemyThinker);
        public abstract void DoUpdate(EnemyThinker enemyThinker);
        public abstract void Deactivate(EnemyThinker enemyThinker);
    }
}
