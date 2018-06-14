
using Xamarin.Forms;
using FriendApp.Droid.Services;

[assembly: Dependency(typeof(FileHelper))]

namespace FriendApp.Droid.Services
{
    using FriendApp.Services;
    using System;
    using System.IO;
    class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(String fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
           return Path.Combine(path, fileName);
        }
    }
}