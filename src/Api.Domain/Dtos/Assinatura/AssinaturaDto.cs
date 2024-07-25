using Microsoft.AspNetCore.Http;

namespace Domain.Dtos.Assinatura
{
    public class AssinaturaDto
    {

        public IFormFile pdf { get; set; }
        public string imagemAssinaturaURL { get; set; }
        public int largura { get; set; } = 270;
        public int altura { get; set; } = 90;
        public int x { get; set; } = 840;
        public int y { get; set; } = 100;
        public IFormFile arquivoAsssinatura { get; set; }
        public string password { get; set; }
        public bool todas { get; set; } = true;
    }
}
