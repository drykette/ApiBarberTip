//Para a classe usar o Framework
using Microsoft.EntityFrameworkCore;
using BarberTip.Entities;
//Mapeamento Objeto-Relacional

namespace BarberTip.Contexts;

//Classe é um conjunto de objetos
//Herança: filho herda do pai
public class BarberTipContext:DbContext{

    //Definimos uma propriedade que irá configuração
    //Aplica as configurações = ConnectionString
    //IConfiguration - Injeção e compedência
    //Animal a = new Animal(); não injeta
    //Animal _a; injetado.
    private readonly IConfiguration _configuration;

    public BarberTipContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //Definir uma classe que será mapeada
    public DbSet<Cliente> Clientes=>Set<Cliente>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BarberTip"));

    }


    /*
    Server: L02409022221\SENAC
    Login:sa
    Senha:senac
    */
}
