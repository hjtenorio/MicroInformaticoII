namespace AssetsIT.API.Models.Response
{
    public class FileDTOResponse
    {
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Base64 { get; set; }
    }
}