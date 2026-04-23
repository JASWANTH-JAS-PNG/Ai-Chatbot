using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OllamaController : ControllerBase
    {
        private readonly OllamaServices _ollama;

        public OllamaController(OllamaServices ollama)
        {
            _ollama = ollama;
        }   

        [HttpPost("query")]
        public IActionResult QueryOllama([FromBody] string query)
        {
           
            var ollamaResponse = $"You queried: {query}. This is a response from Ollama.";
            return Ok(new { ollamaResponse });
        }
    }
}