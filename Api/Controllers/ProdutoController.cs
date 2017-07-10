using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace Api.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        [HttpGet]
        public List<string> BuscarTudo()
        {
            return new List<string>
            {
                "mouse de bolinha",
                "teclado sem fio",
                "monitor lcd 19",
                "monitor led 21"
            };
        }

        [HttpGet, Route("{nome}")]
        public List<string> BuscarPorNome(string nome)
        {
            return new List<string>
            {
                "mouse de bolinha",
                "teclado sem fio",
                "monitor lcd 19",
                "monitor led 21"
            }.Where(x => x.Trim().ToLower().Contains(nome.Trim().ToLower())).ToList();
        }
    }
}