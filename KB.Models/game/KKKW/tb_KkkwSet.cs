using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_KkkwSet
    {
        //ID 标识ID
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //Name 游戏名称
        public string Name { get; set; }
        //Logo 个性Logo
        public string Logo { get; set; }
        //AdID 客户ID
        public int AdID { get; set; }
        //Note 公告
        public string Note { get; set; }
        //OpenType 开奖类型
        public int OpenType { get; set; }
        //Odds 赔率
        public int Odds { get; set; }
        //AddTime 开台时间
        public DateTime AddTime { get; set; }
        //AllCent 每期最大总币
        public decimal AllCent { get; set; }
        //MaxCent 最大下币
        public decimal MaxCent { get; set; }
        //MinCent 最小下币
        public decimal MinCent { get; set; }
        //LiveImage 直播图片
        public string LiveImage { get; set; }
        //LiveText 直播文字
        public string LiveText { get; set; }
        //State 当前状态
        public int State { get; set; }
        //KKDate 当前期号
        public string KKDate { get; set; }
    }
}
  