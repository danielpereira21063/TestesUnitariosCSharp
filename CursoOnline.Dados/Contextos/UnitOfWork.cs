﻿using CursoOnline.Dominio._Base;
using System.Threading.Tasks;

namespace CursoOnline.Dados.Contextos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}