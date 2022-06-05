using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class Sit : Action
    {
        public override Node Evaluate()
        {
            Debug.Log("Sitting");
            return base.Evaluate();
        }
    }
}