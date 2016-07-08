
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    //酷酷快玩订单服务类
    public class KkkwOrderService:BaseService<tb_KkkwOrder>
    {
        public KkkwOrderService() :base(RepositoryFactory.KkkwOrderRepository){ }
    }
}
