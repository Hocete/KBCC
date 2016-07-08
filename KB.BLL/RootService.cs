
using KB.DAL;
using KB.Models;
using System.Linq;
using System;

namespace KB.BLL
{
    // <summary>
    /// Root管理员服务类
    /// </summary>
    public class RootService : BaseService<tb_Root>
    {
        public RootService() : base(RepositoryFactory.RootRepository) { }

        public bool Exist(string RoName)
        {
            return CurrentRepository.Exist(u => u.RoName == RoName);
        }
        public bool Exist(string RoName, string RoPwd)
        {
            return CurrentRepository.Exist(u => u.RoName == RoName && u.RoPwd == RoPwd);
        }
        public tb_Root Find(string RoName)
        {
            return CurrentRepository.Find(u => u.RoName == RoName);
        }
        public tb_Root Find(string RoName,string RoPwd)
        {
            return CurrentRepository.Find(u => u.RoName == RoName && u.RoPwd == RoPwd);
        }
        public tb_Root FindID(int RoID)
        {
            return CurrentRepository.Find(u => u.RoID == RoID);
        }

        public IQueryable<tb_Root> FindList(int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "RoID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "RoID";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "RoID";
                    break;
            }
            return CurrentRepository.FindList(u => true, _orderName, _isAsc);
        }
        public IQueryable<tb_Root> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "RoID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "RoID";
                    break;    
                default:
                    _isAsc = false;
                    _orderName = "RoID";
                    break;
            }
            return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);
        }

    }
}
