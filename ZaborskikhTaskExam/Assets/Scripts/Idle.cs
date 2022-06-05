using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class Idle : Action
    {
        public override Node Evaluate()
        {
            Debug.Log("Idling");
            return base.Evaluate();
        }
    }
}