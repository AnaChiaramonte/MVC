using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Ana clara lopes", "ana.c.lopes23@aluno.senai.br", 3489);
            Aluno a2 = new Aluno(2, "Ana Geremias", " ana.Geremias@aluno.senai.br", 3492);
            Aluno a3 = new Aluno(3, "Beatriz silva", "Bia.Silva@aluno.senai.br", 4503);
            Aluno a4 = new Aluno(4, "Livia solla", "Livia.solla@aluno.senai.br", 3689);
            Aluno a5 = new Aluno(5, "Gabriela caputti", "Gabriela.Caputti@aluno.senai.br", 4449);

            List<Aluno> list = new List<Aluno>();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            list.Add(a4);
            list.Add(a5);

            //enviando a lista com parametri view
            return View(list);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
