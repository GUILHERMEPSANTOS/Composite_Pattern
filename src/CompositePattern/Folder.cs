using CompositePattern.Common;

namespace CompositePattern
{
    public class Folder : FileSystemComposite
    {
        public List<FileSystemComponent> Components = new List<FileSystemComponent>();

        public Folder(string name) : base(name)
        {
        }

        public override void Add(FileSystemComponent component)
        {
            Components.Add(component);
        }

        public override FileSystemComponent GetChild(int index)
        {
            return Components[index];
        }

        public override double GetSizeInMB()
        {
            return Components.Sum(component => component.GetSizeInMB());
        }

        public override void Remove(FileSystemComponent component)
        {
            Components.Remove(component);
        }

     
    }
}
