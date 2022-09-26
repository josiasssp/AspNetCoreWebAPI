using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]  //o que é
    [Route("api/[controller]")] //rota
    public class AlunoController : ControllerBase //construção da classe
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno(){
                Id = 1,
                Nome = "Maria",
                Sobrenome = "Ana",
                Telefone = "1234455"
            },
            new Aluno(){
                Id = 2,
                Nome = "João",
                Sobrenome = "Gordo",
                Telefone = "3434323"
            },
            new Aluno(){
                Id = 3,
                Nome = "Laura",
                Sobrenome = "Kent",
                Telefone = "56432424"
            },
        };
        public AlunoController() { }
        
        [HttpGet] //solicitação

        public IActionResult Get() //açao do resutado (get)
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")] //solicitação

        public IActionResult GetById(int id) //açao do resutado (get)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno ==null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpGet("ByName")] //solicitação

        public IActionResult GetByName(string nome, string Sobrenome) //açao do resutado (get)
        {
            var aluno = Alunos.FirstOrDefault(a => 
            a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome)
            );
            if (aluno ==null) return BadRequest("O Aluno não foi encontrado");
            return Ok(aluno);
        }

        [HttpPost] //solicitação

        public IActionResult Post (Aluno aluno) //açao do resutado (get)
        {
        
            return Ok(aluno);
        }

        [HttpPut("{id}")] //solicitação

        public IActionResult Put (int id, Aluno aluno) //açao do resutado (get)
        {
        
            return Ok(aluno);
        }

        [HttpPatch("{id}")] //solicitação

        public IActionResult Patch (int id, Aluno aluno) //açao do resutado (get)
        {
        
            return Ok(aluno);
        }

        [HttpDelete("{id}")] //solicitação

        public IActionResult Delete (int id) //açao do resutado (get)
        {
        
            return Ok();
        }

        

        
            
        
    }
}