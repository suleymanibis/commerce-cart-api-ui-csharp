using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using E_Commerce_Cart_API_UI.Utils;

namespace E_Commerce_Cart_API_UI.Managers
{
    public class FileManager
    {
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly string _path, _userPath;
        private readonly FileUtils _fileUtils;

        public FileManager(FileUtils fileUtils)
        {
            _jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };

            _fileUtils = fileUtils;

            _path = "sessions.json";
            _userPath = "user_config.json";
        }

        public void SaveSession<T>(T data)
        {
            _fileUtils.Save<T>(_path, _jsonOptions, data);
        }

        public T? ReadSession<T>()
        {
            return _fileUtils.Read<T>(_path, _jsonOptions);
        }

        public void CleanSession()
        {
            _fileUtils.Clean(_path);
        }

        public void SaveConfig<T>(T data)
        {
            _fileUtils.Save<T>(_userPath, _jsonOptions, data);
        }

        public T? ReadConfig<T>()
        {
            return _fileUtils.Read<T>(_userPath, _jsonOptions);
        }

        public void CleanConfig()
        {
            _fileUtils.Clean(_userPath);
        }
    }
}
