using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "Cp@teste.com.br", 1234);
            Aluno a2 = new Aluno(2, "Ana Clara", "AC@teste.com.br", 3489);
            Aluno a3 = new Aluno(3, "Ana Julia", "AJulia@teste.com.br", 3492);
            Aluno a4 = new Aluno(4, "Beatriz Nascimento", "BeAnas@teste.com.br", 4503);
            Aluno a5 = new Aluno(5, "Livia Linda", "Livia.Linda@teste.com.br", 3689);

            //Criar uma lista de Alunos
            List<Aluno> ListaAlunos = new List<Aluno>();

            ListaAlunos.Add(a1);
            ListaAlunos.Add(a2);
            ListaAlunos.Add(a3);
            ListaAlunos.Add(a4);
            ListaAlunos.Add(a5);

            return View(ListaAlunos);
        }
        public IActionResult cadastrar()
        {
            return View();

        }
    }
}
