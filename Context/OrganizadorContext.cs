using Microsoft.EntityFrameworkCore;
using trilha_net_api_desafio7.Models;

namespace trilha_net_api_desafio7.Context
{
    public class OrganizadorContext:DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) 
        { 
        
        }

        public DbSet<Tarefa> Tarefas {get; set; }
    }
}
