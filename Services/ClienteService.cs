using BarberTip.Contexts;
using BarberTip.Entities;
using BarberTip.ViewModel;

namespace BarberTip.Services;

public class ClienteService{
    private readonly BarberTipContext _context;
    private ClienteService(BarberTipContext context){
        _context = context;
    }

    public DetalheClienteViewModel AdicionarCliente(AdicionarClienteViewModel dados){
        var cliente = new Cliente(dados.Nome, dados.Telefone, dados.Email, dados.DataNascimento);
        _context.Add(cliente);
        _context.SaveChanges();

        return new DetalheClienteViewModel(cliente.Id, cliente.Nome, cliente.Telefone, cliente.DataNascimento, cliente.Email);

    }
}
