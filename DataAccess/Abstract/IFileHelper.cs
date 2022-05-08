﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helper
{
    public interface IFileHelper
    {
        void DeleteOldFile(string directory);
        void CreateFile(string directory, IFormFile file);
        void CheckDirectoryExists(string directory);
        IResult CheckFileTypeValid(string type);
        IResult CheckFileExists(IFormFile file);
        IResult Add(IFormFile file);
        IResult Update(IFormFile file, string imagePath);
        IResult Delete(string path);


    }
}
