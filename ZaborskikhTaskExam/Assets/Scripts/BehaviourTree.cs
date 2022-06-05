using System;
using System.Collections;
using UnityEngine;

namespace BehaviourTreeSys
{
    public abstract class BehaviourTree : MonoBehaviour
    {

        public bool IsWalking { get; private set; }
        private Coroutine _processCoroutine;
        
        public void Walk()
        {
            if (IsWalking)
            {
                return;
            }
            _processCoroutine = StartCoroutine(Process(GetRoot()));
        }

        protected abstract IBehaviourTreeNode GetRoot();

        private IEnumerator Process(IBehaviourTreeNode root)
        {
            IsWalking = true;
            do
            {
                root.Evaluate();
                if (root.State == Node.Fail)
                {
                    break;
                }
                yield return null;
            }
            while (root.State != Node.Done);
            IsWalking = false;
        }
    }
}