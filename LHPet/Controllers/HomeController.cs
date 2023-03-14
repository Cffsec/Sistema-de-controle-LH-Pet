using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente c1 = new Cliente(001, "Carlos Andrade", "978.006.000-01", "CarlosAndradetestetestes@gmail.com", "Toby");
        Cliente c2 = new Cliente(002, "Roberto Queiroz", "978.005.000-01", "Robertoqueirozzzzzzz@gmail.com", "Bob");
        Cliente c3 = new Cliente(003, "Naldo Benny", "978.004.000-02", "NaldoBennymentirosoooooo@gmail.com", "Pinóquio");
        Cliente c4 = new Cliente(004, "Chris Brown", "978.007.000-03", "SingleChrisBrownbreezyyy@icloud.com", "Stuart");
        Cliente c5 = new Cliente(005, "Lebron James", "LebronKingjamesssssss@outlook.com", "978.009.000-09", "Marley");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(c1);
        listaClientes.Add(c2);
        listaClientes.Add(c3);
        listaClientes.Add(c4);
        listaClientes.Add(c5);

        Fornecedor f1 = new Fornecedor(001, "New pets store", "002.003.004/0001-01", "newpetstore.microsoft@outlook.com");
        Fornecedor f2 = new Fornecedor(002, "L&A animals ltda", "002.005.004/0001-08", "laanimals.animals9890@outlook.com");
        Fornecedor f3 = new Fornecedor(003, "BatPet's center", "007.003.005/0001-01", "batpetcenter.2023@gmail.com");
        Fornecedor f4 = new Fornecedor(004, "Supreme shop", "009.010.004/0001-89", "supremeshop.com.br@icloud.com");
        Fornecedor f5 = new Fornecedor(005, "J/a PetShop", "992.003.004/0009-09", "j.apetshop_shop_store@gmail.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(f1);
        listaFornecedores.Add(f2);
        listaFornecedores.Add(f3);
        listaFornecedores.Add(f4);
        listaFornecedores.Add(f5);

        ViewBag.listaClientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
