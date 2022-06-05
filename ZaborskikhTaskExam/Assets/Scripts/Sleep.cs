using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class Sleep : Action
    {
        public override Node Evaluate()
        {
            Debug.Log("Sleeping");
            
            return base.Evaluate();
        }
        
    }
}