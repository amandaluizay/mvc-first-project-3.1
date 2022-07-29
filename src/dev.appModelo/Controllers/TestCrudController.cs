using dev.appModelo.Data;
using dev.appModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace dev.appModelo.Controllers
{
    public class TestCrudController : Controller
    {
        // adicionando injeção de dependência
        private readonly MeuDbContext _contexto;

        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            //atribuindo novo aluno na variavel 
            var aluno = new Aluno
            {
                Nome = "Eduardo",
                DataNascimento = DateTime.Now,
                Email = "eduardo@gmail.com"
            };

            //adicionando aluno dentro da memoria do db context com entity framework
            _contexto.Alunos.Add(aluno);
           //salvar o aluno na base de dados 
            _contexto.SaveChanges();

            //buscando aluno por id
            var aluno1 = _contexto.Alunos.Find(aluno.Id);
            //buscando unico aluno por email
            var aluno2 = _contexto.Alunos.FirstOrDefault(a=> a.Email == "eduardo@gmail.com");
            // buscando coleção de alunos por email
            var aluno3 = _contexto.Alunos.Where(a => a.Email == "eduardo@gmail.com");

            //atualizando o Aluno da variável "aluno" para joão
            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            // remove o aluno da instancia aluno 
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
