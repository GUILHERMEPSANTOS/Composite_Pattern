using System.ComponentModel;

namespace CompositePattern.Abstractions
{
    public interface ICompositeAbstraction<T>  where T : IComponentAbstraction
    {        
        void Add(T component);
        void Remove(T component);
        T GetChild(int index);
    }
}
