
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    //消费日志服务类
    public class SpendTextService : BaseService<tb_SpendText>
    {
        public SpendTextService() : base(RepositoryFactory.SpendTextRepository) { }

    }
}
