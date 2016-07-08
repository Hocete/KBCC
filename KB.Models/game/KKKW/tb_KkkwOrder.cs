using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_KkkwOrder
    {
        //ID 编号
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //AdID 客户ID
        public int AdID { get; set; }
        //Type 购买类型
        public int Type { get; set; }
        //KKDate 购买期号
        public string KKDate { get; set; }
        //Num 购买号码
        public string Num { get; set; }
        //UsID 用户ID
        public int UsID { get; set; }
        //Odds 赔率
        public float Odds { get; set; }
        //Price 单注花费币数
        public decimal Price { get; set; }
        //Zhu 投注注数
        public int Zhu { get; set; }
        //AddTime 下注时间
        public DateTime AddTime { get; set;}
        //WinCent 获奖币数
        public decimal WinCent { get; set; }
        //WinNotes 获奖日志
        public string WinNotes { get; set; }
        //State 状态：
        public int State { get; set; }

    }
}
