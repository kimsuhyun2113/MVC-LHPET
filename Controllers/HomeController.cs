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
        //instancias do tipo cliente 
        Cliente cliente1 = new  Cliente(01, "yerin kim", "157.888.968-63","yerinkim@gmail.com","kiko");
        Cliente cliente2 = new  Cliente(02, "yerin kim", "157.888.968-63","yerinkim@gmail.com","pulgs");
        Cliente cliente3 = new  Cliente(03, "Desirre castro", "225.369.874-98","dekaka@gmail.com","maymay");
        Cliente cliente4 = new  Cliente(04, "su kim", "025.369.147-85","kim123@gmail.com","demonio");
        //lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"galeao","123.312.313/2111-08","galeao@gmail.com ");
        //lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);

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
