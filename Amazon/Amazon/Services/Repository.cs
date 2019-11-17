using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models;

namespace TodoApi1.Services
{
    public class Repository : IRepository
    {
        IEnumerable<Commento> _commenti;
        CommentoContext _listacommenti;
        public Repository(IEnumerable<Commento> commenti, CommentoContext listacommenti)
        {
            _commenti = commenti;
            _listacommenti = listacommenti;
        }


        public IEnumerable<Commento> AddCommento(Commento commento, IEnumerable<Commento> listacommenti)
        {
            return listacommenti;
        }

        public IEnumerable<Commento> ChangeCommento(Commento commento, IEnumerable<Commento> listacommenti)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Commento> DeleteCommento(Commento commento, IEnumerable<Commento> listacommenti)
        {
            throw new NotImplementedException();
        }

        public DbSet<Commento> GetCommento()
        {
            return _listacommenti.Commenti;
        }

        public IEnumerable<Commento> GetCommento(Commento commento, IEnumerable<Commento> listacommenti)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> AddTodoItem(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> DeleteTodoItem(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }

        public DbSet<Prodotto> GetTodoItem()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> ChangeTodoItem(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> AddProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> DeleteProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }

        public DbSet<Prodotto> GetProdotto()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prodotto> ChangeProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti)
        {
            throw new NotImplementedException();
        }
    }
}
