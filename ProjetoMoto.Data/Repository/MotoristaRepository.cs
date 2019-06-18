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
    public class MotoristaRepository
    {
        protected ProjetoMotoContext db = new ProjetoMotoContext();

        public void Adicionar(Motorista obj)
        {
            db.Set<Motorista>().Add(obj);
            db.SaveChanges();
        }

        public IEnumerable<Motorista> BuscarTodos()
        {
            return db.Motoristas.ToList();
        }

        public Motorista BuscarPorId(int id)
        {
            return db.Set<Motorista>().Find(id);
        }

        public void Remove(int id)
        {
            db.Set<Motorista>().Remove(db.Set<Motorista>().Find(id));
            db.SaveChanges();
        }

        public void Update(Motorista obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
