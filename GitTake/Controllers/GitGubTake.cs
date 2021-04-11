using GitTake.Models;
using GitTake.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitTake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitGubTake : ControllerBase
    {
        // GET: api/<GitGubTake>
        [HttpGet("posicao")]
        public async Task<CarrosselInfo> GetAsync(int posicao)
        {
            GitHubTakeRepo _repo = new GitHubTakeRepo();
            List<CarrosselInfo> lista = await _repo.getGitRepos();

            return lista[posicao];
        }

      
    }
}
