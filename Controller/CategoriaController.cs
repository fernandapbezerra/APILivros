using API_Projeto_Livros.Interface;
using API_Projeto_Livros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Livros.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaController (ICategoriaRepository repository)
        {
            _repository = repository;
       }

        [HttpGet]
        public IActionResult ListarTodos()
        {
             var categorias = _repository.ListarTodos();
            return Ok(categorias);
        }
        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            _repository.Cadastrar(categoria);
            return Created();
        }
    
    }
}
