using System;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace BehaviourTreeSys
{
    public class RandomAction : Action
    {
        private readonly IBehaviourTreeNode[] _actions;

        private IBehaviourTreeNode _action;

        public RandomAction(params IBehaviourTreeNode[] actions)
        {
            _actions = actions ?? throw new ArgumentNullException(nameof(actions));
        }
        
        public override Node Evaluate()
        {
            _action ??= _actions[Random.Range(0, _actions.Length)];
            _state = _action.Evaluate();
            if (_state == Node.Done)
            {
                _action.Reset();
                _action = null;
            }

            return _state;
        }
    }
}