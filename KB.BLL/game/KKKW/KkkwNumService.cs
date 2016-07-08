
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    //酷酷快玩开奖号码服务类
    public class KkkwNumService:BaseService<tb_KkkwNum>
    {
        public KkkwNumService() : base(RepositoryFactory.KkkwNumRepository) { }
    }
}
