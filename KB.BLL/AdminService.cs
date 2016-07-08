
using KB.DAL;
using KB.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace KB.BLL
{
    //客户管理员服务类
    public class AdminService : BaseService<tb_Admin>
    {
        public AdminService() : base(RepositoryFactory.AdminRepository) { }

        public bool Exist(int AdID)
        {
            return CurrentRepository.Exist(u => u.AdID == AdID);
        }
        public bool Exist(string AdID, string AdPwd)
        {
            return CurrentRepository.Exist(u => u.AdID.ToString() == AdID && u.AdPwd == AdPwd);
        }
        public tb_Admin Find(string AdName)
        {
            return CurrentRepository.Find(u => u.AdName == AdName);
        }
        public tb_Admin Find(int UID)
        {
            return CurrentRepository.Find(u => u.AdID == UID);
        }
        public void EditMe(tb_Admin model)
        {
            List<string> filed = new List<string>();
            filed.Add("AdName");
            filed.Add("AdPwd");
            filed.Add("CentName");
            filed.Add("CentNum");
            new AdminService().UpdateEntityFields(model, filed);
        }
        public IQueryable<tb_Admin> FindList(int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "AdID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "AdName";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "AdName";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "CentName";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "CentName";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
            }
            return CurrentRepository.FindList(u => true, _orderName, _isAsc);
        }
        public IQueryable<tb_Admin> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "AdID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "AdName";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "AdName";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "CentName";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "CentName";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "AdID";
                    break;
            }
            return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);
        }
    }
}
