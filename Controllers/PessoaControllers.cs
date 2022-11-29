using Microsoft.AspNetCore.Mvc;
using ProjetoAds8.Models;
using ProjetoAds8.Repositories;

namespace ProjetoAds8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaControllers : ControllerBase
    {
        private readonly IProjetoAds8Repository _pessoaRepository;
        public PessoaControllers(IProjetoAds8Repository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> GetPessoa()
        {
            return await _pessoaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id) 
        {
            return await _pessoaRepository.Get(id);
                
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa([FromBody] Pessoa pessoa)
        {
            var newPessoa = await _pessoaRepository.Create(pessoa);
            return CreatedAtAction(nameof(GetPessoa), new { id = newPessoa.Id }, newPessoa);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var pessoaToDelete = await _pessoaRepository.Get(id);

            if (pessoaToDelete == null) 
            return NotFound();

            await _pessoaRepository.Delete(pessoaToDelete.Id);
            return NoContent();




        }

        [HttpPut]
        public async Task<ActionResult> PutPessoa(int id,[FromBody] Pessoa pessoa)
        {
            if (id != pessoa.Id)
                return BadRequest();

            await _pessoaRepository.Update(pessoa);

            return NoContent();
        }
    }
}
