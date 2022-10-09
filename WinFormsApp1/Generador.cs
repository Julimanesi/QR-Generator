using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WinFormsApp1
{
    class Generador
    {
        private static readonly HttpClient client = new HttpClient();
        public Image QRBarcode = null;
        public string texto { get; }
        public string advertencia { get; set; }

        public Generador(string text)
        {
            texto = text;
        }

        public async Task GenerarQR()
        {
            using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://chart.googleapis.com/chart?cht=qr&chl=" + texto + "&choe=UTF-8&chs=300x300"))
            {
                try
                {
                    var response = await client.SendAsync(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        QRBarcode = Image.FromStream(await response.Content.ReadAsStreamAsync());
                    else
                    {
                        switch (response.StatusCode)
                        {
                            case System.Net.HttpStatusCode.BadRequest:
                                advertencia = "No se pudo procesar";
                                break;
                            case System.Net.HttpStatusCode.NotFound:
                                advertencia = "No encontrado";
                                break;
                            case System.Net.HttpStatusCode.InternalServerError:
                                advertencia = "Error en el servidor.";
                                break;
                        }
                    }
                }
                catch(HttpRequestException e)
                {
                    advertencia ="Error: "+e.Message;
                }
                
            }
        }
    }
}
