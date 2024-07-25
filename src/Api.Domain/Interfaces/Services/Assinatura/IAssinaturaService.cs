
using Domain.Dtos.Assinatura;

namespace Domain.Interfaces.Services.Assinatura
{
    public interface IAssinaturaService
    {
        public byte[] Sign(byte[] document, byte[] certificate, AssinaturaDto assinatura/*, string signatureText = null*/);
    }
}
