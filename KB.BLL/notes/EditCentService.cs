
using KB.DAL;
using KB.Models;
using System.Linq;


namespace KB.BLL
{
    //编辑币日志服务类
    public class EditCentService:BaseService<tb_EditCent>
    {
        public EditCentService() : base(RepositoryFactory.EditCentRepository) { }
        public tb_EditCent Find(int AdID)
        {
            return CurrentRepository.Find(c=>c.AdID==AdID,c=>c.AddTime);
        }
    }
}
