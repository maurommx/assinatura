using Domain.Dtos.Assinatura;
using Domain.Interfaces.Services.Assinatura;
using Domain.PdfSigner;

namespace Service.Services
{
    public class AssinaturaService : IAssinaturaService
    {
        public byte[] Sign(byte[] document, byte[] certificate, AssinaturaDto assinatura/*, string signatureText = null,*/)
        {
            return PdfSigner.Sign(document, certificate, assinatura/*, signatureText*/);
        }
    }
}
