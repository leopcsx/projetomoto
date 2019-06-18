using ProjetoMoto.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMoto.Data.Entities;
using System.Data.Entity;

namespace ProjetoMoto.Data.Repository
{
    public class ContratadaRepository
    {
        protected ProjetoMotoContext db = new ProjetoMotoContext();

        public void Adicionar(Contratada obj)
        {
            db.Set<Contratada>().Add(obj);
            db.SaveChanges();
        }

        public IEnumerable<Contratada> BuscarTodos()
        {
            return db.Contratadas.ToList();
        }

        public Contratada BuscarPorId(int id)
        {
            return db.Set<Contratada>().Find(id);
        }

        public void Remove(int id)
        {
            db.Set<Contratada>().Remove(db.Set<Contratada>().Find(id));
            db.SaveChanges();
        }

        public void Update(Contratada obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
