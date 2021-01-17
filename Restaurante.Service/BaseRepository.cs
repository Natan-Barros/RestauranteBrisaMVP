using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Restaurante.Shared.Entities;

namespace Restaurante.Service
{
    public class BaseRepository<T>  where T : Entidade
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            this.dbSet = contexto.Set<T>();
        }


    }
}
