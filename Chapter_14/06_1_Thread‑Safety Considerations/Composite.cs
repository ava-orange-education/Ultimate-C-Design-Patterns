public sealed class Composite : Component
{
    private readonly object _sync = new object();
    private readonly List<Component> _children = new List<Component>();

    public void Add(Component child)
    {
        lock (_sync)
        {
            _children.Add(child);
        }
    }

    public void Remove(Component child)
    {
        lock (_sync)
        {
            _children.Remove(child);
        }
    }

    public override void Operation()
    {
        Component[] snapshot;

        lock (_sync)
        {
            snapshot = _children.ToArray();
        }

        foreach (var child in snapshot)
        {
            child.Operation();
        }
    }
}