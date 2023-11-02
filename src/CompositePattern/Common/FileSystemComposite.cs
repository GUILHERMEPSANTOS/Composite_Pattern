using CompositePattern.Abstractions;

namespace CompositePattern.Common
{
    public abstract class FileSystemComposite : FileSystemComponent, ICompositeAbstraction<FileSystemComponent>
    {
        protected FileSystemComposite(string name) : base(name)
        {
        }
       
        public List<FileSystemComponent> Components = new List<FileSystemComponent>();

        public abstract void Add(FileSystemComponent component);

        public abstract void Remove(FileSystemComponent component);

        public abstract FileSystemComponent GetChild(int index);        
    }
}
