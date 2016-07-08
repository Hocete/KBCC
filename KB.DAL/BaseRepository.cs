using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KB.IDAL;
using System.Data.Entity.Infrastructure;

namespace KB.DAL
{
    /// <summary>
    /// 仓储基类
    /// <remarks>创建：2014.02.03</remarks>
    /// </summary>
    public class BaseRepository<T> : InterfaceBaseRepository<T> where T : class
    {
        protected KBDbContext nContext = ContextFactory.GetCurrentContext();
        
        public T Add(T entity)
        {
            nContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Added;
            nContext.SaveChanges();
            return entity;
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return nContext.Set<T>().Count(predicate);
        }

        public bool Update(T entity)
        {
            nContext.Set<T>().Attach(entity);
            nContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            return nContext.SaveChanges() > 0;
        }
        public void UpdateEntityFields(T entity, List<string> fileds)
        {
            if (entity != null && fileds != null)
            {
                nContext.Set<T>().Attach(entity);
                var SetEntry = ((IObjectContextAdapter)nContext).ObjectContext.
                    ObjectStateManager.GetObjectStateEntry(entity);
                foreach (var t in fileds)
                {
                    SetEntry.SetModifiedProperty(t);
                }
                nContext.SaveChanges();
            }
        }
        public bool Delete(T entity)
        {
            nContext.Set<T>().Attach(entity);
            nContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
            return nContext.SaveChanges() > 0;
        }

        public bool Exist(Expression<Func<T, bool>> anyLambda)
        {
            return nContext.Set<T>().Any(anyLambda);
        }

        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            T _entity = nContext.Set<T>().FirstOrDefault<T>(whereLambda);
            return _entity;
        }
        public T Find(Expression<Func<T, bool>> whereLambda,Expression<Func<T,DateTime>> whereLambda2)
        {
            var _entity = nContext.Set<T>().Where(whereLambda).OrderByDescending(whereLambda2).FirstOrDefault();
            return _entity;
        }
        public IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba,string orderName, bool isAsc)
        {
            var _list = nContext.Set<T>().Where<T>(whereLamdba);
            _list = OrderBy(_list,orderName,isAsc);
            return _list;
        }
        public IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc)
        {
            var _list = nContext.Set<T>().Where<T>(whereLamdba);
            totalRecord = _list.Count();
            _list = OrderBy(_list, orderName, isAsc).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            return _list;
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">原IQueryable</param>
        /// <param name="propertyName">排序属性名</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>排序后的IQueryable<T></returns>
        private IQueryable<T> OrderBy(IQueryable<T> source, string propertyName, bool isAsc)
        {
            if (source == null) throw new ArgumentNullException("source", "不能为空");
            if (string.IsNullOrEmpty(propertyName)) return source;
            var _parameter = Expression.Parameter(source.ElementType);
            var _property = Expression.Property(_parameter, propertyName);
            if (_property == null) throw new ArgumentNullException("propertyName", "属性不存在");
            var _lambda = Expression.Lambda(_property, _parameter);
            var _methodName = isAsc ? "OrderBy" : "OrderByDescending";
            var _resultExpression = Expression.Call(typeof(Queryable), _methodName, new Type[] { source.ElementType, _property.Type }, source.Expression, Expression.Quote(_lambda));
            return source.Provider.CreateQuery<T>(_resultExpression);
        }



    }
}
