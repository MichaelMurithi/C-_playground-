﻿using System.IO;

namespace WordCounter.ModernApp.IO
{
    public class FileArchiver
    {
        public void CopyFile(string sourcePath, string targetPath)
        {
            using var inputStream = File.OpenRead(sourcePath);
            using (var outputStream = File.Create(targetPath))
            {
                inputStream.CopyTo(outputStream);
            }
        }
    }
}
