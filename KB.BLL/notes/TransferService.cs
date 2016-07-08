
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    //过币服务类
    public class TransferService : BaseService<tb_Transfer>
    {
        public TransferService() : base(RepositoryFactory.TransferRepository) { }
    }
}
