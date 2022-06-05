namespace BehaviourTreeSys
{
    public interface IBehaviourTreeNode
    {
        Node State { get; }
        Node Evaluate();
        void Reset();
    }
}