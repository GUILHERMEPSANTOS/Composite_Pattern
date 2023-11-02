using CompositePattern.Abstractions;
using System;

namespace CompositePattern.Common
{
    public abstract class FileSystemComponent : IFileSystemComponet
    {
        public string Name { get; set; }

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract double GetSizeInMB();
    }
}
