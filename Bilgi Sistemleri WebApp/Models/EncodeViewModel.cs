namespace Bilgi_Sistemleri_WebApp.Models
{
    public class EncodeViewModel
    {
        public string EncodeText { get; set; }
        public string EncodeType { get; set; }

        public EncodeViewModel()
        {
            EncodeType = "";
            EncodeText = "";
        }
    }
}