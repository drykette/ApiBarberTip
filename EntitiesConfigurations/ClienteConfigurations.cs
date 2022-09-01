using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarberTip.Entities;
namespace BarberTip.EntityConfigurations;


public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c=>c.Id);
        builder.Property(c=>c.Nome)
                .IsRequired()
                .HasMaxLength(60);
        builder.Property(c=>c.Telefone)
                .IsRequired()
                .HasMaxLength(11);
        builder.Property(c=>c.Email)
                .IsRequired()
                .HasMaxLength(60);
        builder.Property(c=>c.DataNascimento)
                .IsRequired();
                //Data não tem tamanho, pois se trata de uma struct (estrutura)     
                //DataTime = Struct          


    }
}