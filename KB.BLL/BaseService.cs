using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KB.IDAL;
using System.Linq.Expressions;

namespace KB.BLL
{
    /// <summary>
    /// 服务基类
    /// </summary>
    public abstract class BaseService<T>
    {
        

        protected InterfaceBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(InterfaceBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        public T Add(T entity) { return CurrentRepository.Add(entity); }
        public bool Update(T entity) { return CurrentRepository.Update(entity); }
        public void UpdateEntityFields(T entity, List<string> fileds) { CurrentRepository.UpdateEntityFields(entity, fileds); }
        public bool Delete(T entity) { return CurrentRepository.Delete(entity); }

    }
}
