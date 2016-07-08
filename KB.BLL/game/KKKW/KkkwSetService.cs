
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    //酷酷快玩设置服务类
    public class KkkwSetService:BaseService<tb_KkkwSet>
    {
        public KkkwSetService() :base(RepositoryFactory.KkkwSetRepository){ }
    }
}
