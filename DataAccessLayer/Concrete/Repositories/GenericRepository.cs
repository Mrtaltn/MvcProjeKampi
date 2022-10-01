
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
   public class GenericRepository<T> : IRepository<T> where T : class//şartım t degerim class olmalı 
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()//yapıcı metot class ismiyle aynı olur.t degerinin hangi sınıfa ait oldugunu bilmek için contructur(yapıcı)Metot tanımladım.
        {
            _object = c.Set<T>();//deger ataması yaptık.object isimli field ım dısardan gnderdigim entity ne ise o olacak.

        }


        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();//şartlı listelemede filter dan gelen degere gore listeleme yapar.
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
