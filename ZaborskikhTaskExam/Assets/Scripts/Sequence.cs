using System;
using System.Collections.Generic;
using System.Linq;

namespace BehaviourTreeSys
{
    public class Sequence : Action
    {
        private readonly IBehaviourTreeNode[] _nodesSequence;
        private int _currentNode = 0;

        protected IBehaviourTreeNode CurrentNode => _nodesSequence[_currentNode];

        public Sequence(params IBehaviourTreeNode[] nodesSequence)
        {
            _nodesSequence = nodesSequence ?? throw new ArgumentNullException(nameof(nodesSequence));
        }

        public override Node Evaluate()
        {
            _state = Node.Walking;
            while (_currentNode != _nodesSequence.Length)
            {
                CurrentNode.Evaluate();
                if (CurrentNode.State == Node.Fail)break;
                
                if (CurrentNode.State == Node.Walking)return _state;
                
                if (CurrentNode.State == Node.Done)CurrentNode.Reset();
                
                _currentNode++;
            }

            _state = Node.Done;
            return _state;
        }
    }
}