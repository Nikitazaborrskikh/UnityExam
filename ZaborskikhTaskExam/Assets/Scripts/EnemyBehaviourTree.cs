using System;
using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class EnemyBehaviourTree : BehaviourTree
    {
        [SerializeField] private Transform player;
        protected override IBehaviourTreeNode GetRoot()
        {
            IBehaviourTreeNode EnemyBehaviour = new RandomAction(new Sit(), new Idle(), new Sleep());
            return new PlayerDistance(new AttackPlayer(), EnemyBehaviour, transform, player, 5f);
        }
        private void Update()
        {
            if (!IsWalking)
            {
                Walk();
            }
        }

        
    }
}