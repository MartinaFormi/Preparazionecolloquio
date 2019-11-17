using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models;

namespace TodoApi1.Services
{
    interface IRepository
    {

        IEnumerable<Commento> AddCommento(Commento commento, IEnumerable<Commento> listacommenti);

        IEnumerable<Commento> DeleteCommento(Commento commento, IEnumerable<Commento> listacommenti);

        DbSet<Commento> GetCommento();

        IEnumerable<Commento> ChangeCommento(Commento commento, IEnumerable<Commento> listacommenti);

        IEnumerable<Prodotto> AddProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti);

        IEnumerable<Prodotto> DeleteProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti);

        DbSet<Prodotto> GetProdotto();

        IEnumerable<Prodotto> ChangeProdotto(Prodotto prodotto, IEnumerable<Prodotto> listaProdotti);



    }
}
