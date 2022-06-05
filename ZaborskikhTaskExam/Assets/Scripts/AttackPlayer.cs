using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class AttackPlayer : Action
    {
        public override Node Evaluate()
        {
            Debug.Log("Attacking");
            return base.Evaluate();
        }
    }
}