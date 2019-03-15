using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace agenda_de_contatos.Models
{
    public class AgendaContext : DbContext
    {
        public AgendaContext() : base("name=AgendaContext")
        {
        }

        public System.Data.Entity.DbSet<agenda_de_contatos.Models.Contato> Contatoes { get; set; }
    }
}
