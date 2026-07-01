using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1._6_Introduction_Abstract_Factory.StorageService
{
    internal class StorageService1
    {
    }

    public interface IStorageService
    {
        void UploadFile(string fileName);
    }

    public class AwsStorageService : IStorageService
    {
        public void UploadFile(string fileName) => Console.WriteLine($"Uploading {fileName} to AWS S3");
    }

    public class GoogleCloudStorageService : IStorageService
    {
        public void UploadFile(string fileName) => Console.WriteLine($"Uploading {fileName} to Google Cloud Storage");
    }

    public interface IStorageFactory
    {
        IStorageService CreateStorageService();
    }

    public class AwsStorageFactory : IStorageFactory
    {
        public IStorageService CreateStorageService() => new AwsStorageService();
    }

    public class GoogleCloudStorageFactory : IStorageFactory
    {
        public IStorageService CreateStorageService() => new GoogleCloudStorageService();
    }

}
