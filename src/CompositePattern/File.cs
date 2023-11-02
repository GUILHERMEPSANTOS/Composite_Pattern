using CompositePattern.Common;

namespace CompositePattern
{
    public class File : FileSystemComponent
    {
        public double Size { get; set; }

        public File(string name, double size) : base(name)
        {
            Size = size;
        }

        public override double GetSizeInMB()
        {
            return Size;
        }
    }
}
