using api_with_entity_framework.Model;
using Microsoft.EntityFrameworkCore;

namespace api_with_entity_framework.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> tarefas { get; set; }
    }
}