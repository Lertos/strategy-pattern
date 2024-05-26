namespace strategy_pattern
{
    //A demonstration of the Strategy pattern in C#
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class SomeController
    {
        //Any type of file storage can be chosen as long as it implements the shared interface
        IFileStorage fileStorage;

        //Gives much more flexibility. You aren't concerned with "how" it is done, only that it is done.
        public SomeController(IFileStorage fileStorage)
        {
            this.fileStorage = fileStorage;
        }
    }

    interface IFileStorage
    {
        byte[] GetFile(string id);
        void SaveFile();
    }

    class LocalStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveFile()
        {
            throw new NotImplementedException();
        }
    }

    class RemoteStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveFile()
        {
            throw new NotImplementedException();
        }
    }

    class VirtualStorage : IFileStorage
    {
        public byte[] GetFile(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveFile()
        {
            throw new NotImplementedException();
        }
    }
}
