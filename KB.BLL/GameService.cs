
using KB.DAL;
using KB.Models;
using System.Linq;

namespace KB.BLL
{
    // <summary>
    /// 游戏服务类
    /// </summary>
    public class GameService : BaseService<tb_Game>
    {
        public GameService() : base(RepositoryFactory.GameRepository) { }
        public tb_Game Find(string GName)
        {
            return CurrentRepository.Find(u => u.GName == GName);
        }
        public tb_Game Find(int GID)
        {
            return CurrentRepository.Find(u => u.GID == GID);
        }
        public IQueryable<tb_Game> FindList(int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "GID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "GID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "Gname";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "Gname";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "GTable";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "GTable";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "GID";
                    break;
            }
            return CurrentRepository.FindList(u => true, _orderName, _isAsc);

        }
        public IQueryable<tb_Game> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "GID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "GID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "Gname";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "Gname";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "GTable";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "GTable";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "GID";
                    break;
            }
            return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);


        }
    }
}
