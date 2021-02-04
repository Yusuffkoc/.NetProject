using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    //new() : new'lenebilir olmalı(IEntity interface newlenemiyor.)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //id si bu olan urunu veya kategoriyi getir dıyebılmek için
        //filtre vermemiş ise tüm datayı istiyor demektir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
