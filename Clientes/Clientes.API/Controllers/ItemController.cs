using APIClientes.Entities;
using APIClientes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Item> Get()
        {
           return new ItemRepository().ObterLista();
        }

        [HttpGet("pedido/{pedidoId}")]
        public IEnumerable<Item> GetByPedido(int pedidoId)
        {
           return new ItemRepository().ObterListaPorPedido(pedidoId);
        }

        [HttpPost]
        public Item Post(Item item) => new ItemRepository().Inserir(item);


        /*
        [HttpPost]
        public Item Insert(Item item)
        {
            
            return item;
        }

        [HttpPut]
        public Item Update(Item item)
        {
            
            return item;
        }
        */
    }
}
