using BehaviourTreeSys;
using UnityEngine;

namespace EnemyTree
{
    public class PlayerDistance : Condition
    {
        private readonly float _dist;
        private readonly Transform _pos1;
        private readonly Transform _pos2;
        

        public PlayerDistance(IBehaviourTreeNode nodeA, IBehaviourTreeNode nodeB, Transform pos1, Transform pos2, float dist) : base(nodeA, nodeB)
        {
            _pos1 = pos1;
            _pos2 = pos2;
            _dist = dist;
        }

        protected override bool Conditions()
        {
            return Vector3.Distance(_pos1.position, _pos2.position) < _dist;
        }
    }
}