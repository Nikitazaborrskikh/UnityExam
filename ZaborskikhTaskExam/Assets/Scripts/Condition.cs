namespace BehaviourTreeSys
{
    public abstract class Condition : Action
    {
        private readonly IBehaviourTreeNode _nodeA;
        private readonly IBehaviourTreeNode _nodeB;

        private IBehaviourTreeNode _currentNode;
        
        public Condition(IBehaviourTreeNode nodeA, IBehaviourTreeNode nodeB)
        {
            _nodeA = nodeA;
            _nodeB = nodeB;
        }
        
        public override Node Evaluate()
        {
            _currentNode ??= Conditions() ? _nodeA : _nodeB;
            _state = _currentNode.Evaluate();

            if (_state == Node.Done)
            {
                _currentNode.Reset();
                _currentNode = null;
            }
            
            return _state;
        }

        protected abstract bool Conditions();
    }
}