
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    // <summary>
    /// 用户服务类
    /// </summary>
    public class UserService : BaseService<tb_User>
    {
        public UserService() : base(RepositoryFactory.UserRepository) { }
        public bool Exist(string UsName)
        {
            return CurrentRepository.Exist(u => u.UsName == UsName);
        }

        public bool Exist(string UsName,string UsPwd)
        {
            return CurrentRepository.Exist(u => u.UsName == UsName&&u.UsPwd==UsPwd);
        }
        public tb_User Find(string UsName)
        {
            return CurrentRepository.Find(u => u.UsName == UsName);
        }
       
        public tb_User Find(int UsID)
        {
            return CurrentRepository.Find(u => u.UsID == UsID);
        }

        public tb_User FindByAdID(string UsPwd)
        {
            return CurrentRepository.Find(u => u.UsPwd == UsPwd);
        }

        public tb_User FindByAdID(int AdID)
        {
            return CurrentRepository.Find(u => u.AdID == AdID);
        }

        public tb_User FindByCanGame(string CanGame)
        {
            return CurrentRepository.Find(u => u.CanGame == CanGame);
        }

        public tb_User FindByCent(decimal Cent)
        {
            return CurrentRepository.Find(u => u.Cent == Cent);
        }

        public tb_User FindByContent(string Content)
        {
            return CurrentRepository.Find(u => u.Content == Content);
        }

        public tb_User FindByMarkName(string MarkName)
        {
            return CurrentRepository.Find(u => u.MarkName == MarkName);
        }
        public IQueryable<tb_User> FindList(int order,int AdID)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "UsID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "UsID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "Cent";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "Cent";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "AdID";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "UsID";
                    break;
            }
            if (AdID == 0)
            {
                return CurrentRepository.FindList(u => true, _orderName, _isAsc);
            }
            else
            {
                return CurrentRepository.FindList(u => u.AdID==AdID, _orderName, _isAsc);
            }
            
        }
        public IQueryable<tb_User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order,int AdID)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "UsID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "UsID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "Cent";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "Cent";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "AdID";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "UsID";
                    break;
            }
            if (AdID == 0)
            {
                return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);
            }
            else
            {
                return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => u.AdID==AdID, _orderName, _isAsc);
            }
            
        }
    }
}
