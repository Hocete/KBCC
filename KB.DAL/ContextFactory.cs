using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace KB.DAL
{
    public class ContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static KBDbContext GetCurrentContext()
        {
            KBDbContext _nContext = CallContext.GetData("KBDbContext") as KBDbContext;
            if (_nContext == null)
            {
                _nContext = new KBDbContext();
                CallContext.SetData("KBDbContext", _nContext);
            }
            _nContext.Database.CreateIfNotExists();//如果没有就创建数据库
            
            return _nContext;
        }
    }
}
