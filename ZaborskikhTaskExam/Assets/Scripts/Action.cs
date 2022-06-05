using UnityEngine;

namespace BehaviourTreeSys
{
    public abstract class Action : IBehaviourTreeNode
    {
        public Node State => _state;
        protected Node _state = Node.Idling;
        public GameObject player;
        
        public virtual Node Evaluate()
        {
            _state = Node.Done;
            player = GameObject.FindWithTag("Enemy");
            return _state;
        }
        
        public virtual void Reset()
        {
            _state = Node.Idling;
        }
    }
}