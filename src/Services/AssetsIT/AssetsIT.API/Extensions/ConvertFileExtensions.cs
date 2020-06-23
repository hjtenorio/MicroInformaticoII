using AssetsIT.API.Models.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace AssetsIT.API.Extensions
{
    public class ConvertFileExtensions
    {
        public FileDTOResponse ConvertFileToBase64(IFormFile formFile) {
            byte[] ImageBytes = null;
            BinaryReader reader = new BinaryReader(formFile.OpenReadStream());
            ImageBytes = reader.ReadBytes((int)formFile.Length);
            var base64 = Convert.ToBase64String(ImageBytes);

            FileDTOResponse file = new FileDTOResponse {
                FileName = formFile.FileName,
                ContentType = formFile.ContentType + "; name='" + formFile.FileName + "'",
                Base64 = base64
            };

            return file;
        }

        public List<FileDTOResponse> ListConvertFileToBase64(List<IFormFile> formFile) {
            List<FileDTOResponse> formFiles = new List<FileDTOResponse>();
            foreach (IFormFile files in formFile) {
                var result = ConvertFileToBase64(files);
                formFiles.Add(new FileDTOResponse {
                    FileName = result.FileName,
                    ContentType = result.ContentType + "; name='" + result.FileName + "'",
                    Base64 = result.Base64
                });
            }

            return formFiles;
        }
    }
}