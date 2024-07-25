using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Castle.Core.Internal;
using iTextSharp.text.pdf.qrcode;
using Domain.Interfaces.Services.Assinatura;
using Domain.Dtos.Assinatura;

namespace Api.Application.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssinaturaController : ControllerBase
    {

        public IAssinaturaService _service { get; set; }
        public AssinaturaController(IAssinaturaService service)
        {
            _service = service;
        }


        [AllowAnonymous]
        [HttpPost("DownloadAssinado")]
        public async Task<ActionResult> DownloadAssinado([FromForm] AssinaturaDto assinatura) 
        {
            try
            {

                if ((assinatura.pdf == null) || (assinatura.pdf.Length <= 0))
                    return BadRequest(new { error = "Favor enviar o arquivo PDF" });

                if ((assinatura.imagemAssinaturaURL == null) || (assinatura.imagemAssinaturaURL.IsNullOrEmpty()))
                    return BadRequest(new { error = "Favor Informar a URL da imagem da Assinatura" });

                if ((assinatura.arquivoAsssinatura == null) || (assinatura.arquivoAsssinatura.Length <= 0))
                    return BadRequest(new { error = "Favor enviar o arquivo da Assinatura" });


                if ((assinatura.password == null) || (assinatura.password.IsNullOrEmpty()))
                    return BadRequest(new { error = "Favor informar a senha do arquivo da assinatura" });

                if (assinatura.x == null)
                {
                    return BadRequest(new { error = "Favor informar o valor de x" });
                }

                if (assinatura.y == null)
                {
                    return BadRequest(new { error = "Favor informar o valor de y" });
                }

                if (assinatura.altura == null)
                {
                    return BadRequest(new { error = "Favor informar o valor de altura" });
                }

                if (assinatura.largura == null)
                {
                    return BadRequest(new { error = "Favor informar o valor de largura" });
                }

                MemoryStream PdfStream = new();
                MemoryStream AssinaturaDigitalStream = new();
                MemoryStream ArquivoAssinado = new();

                await assinatura.pdf.CopyToAsync(PdfStream);
                await assinatura.arquivoAsssinatura.CopyToAsync(AssinaturaDigitalStream);

                var textToShow = string.Empty;  //String.Format("Signed by: MySelf!\nSign date: {0}", DateTime.Now.ToShortDateString());

                var document = _service.Sign(PdfStream.ToArray(), AssinaturaDigitalStream.ToArray(), assinatura);

                return File(document, assinatura.pdf.ContentType, assinatura.pdf.FileName);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        
    }
}
