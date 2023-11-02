using CompositePattern.Abstractions;

namespace CompositePattern.Common
{
    public interface IFileSystemComponet : IComponentAbstraction
    {
        public abstract double GetSizeInMB();
    }
}
