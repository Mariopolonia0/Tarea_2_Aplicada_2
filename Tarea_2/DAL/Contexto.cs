using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_2.BLL;

namespace Tarea_2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
    }
}
