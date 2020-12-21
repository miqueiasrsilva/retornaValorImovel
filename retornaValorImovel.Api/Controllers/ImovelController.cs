using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using retornaValorImovel.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace retornaValorImovel.Controllers
{
    [ApiController]
    [Route("v1/imovel")]
    public class RetornoController : ControllerBase
    {
        [HttpGet]
        [Route("GetValorImovel")]
        public async Task<ActionResult<decimal>> GetValorImovel([FromBody] Imovel imovel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            imovel.valorM2 = await GetValorM2();

            return imovel.valorTotal;
        }

        static async Task<decimal> GetValorM2()
        {
            HttpClient client = new HttpClient();

            RetornoM2 retorno = null;
            HttpResponseMessage response = await client.GetAsync("http://retorna-valor-m2.herokuapp.com/v1/retorno/GetValorM2");

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                retorno = JsonConvert.DeserializeObject<RetornoM2>(responseContent);
            }

            if (retorno == null)
            {
                retorno = new RetornoM2();
                retorno.valorM2 = 0;
            }

            return retorno.valorM2;
        }
    }
}