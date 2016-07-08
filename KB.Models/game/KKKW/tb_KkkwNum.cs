using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_KkkwNum
    {
        //ID 编号  int
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //AdID    客户ID int
        public int AdID { get; set; }
        //KKDate  系统期号 nvarchar
        public string KKDate { get; set; }
        //OpenNum 开奖号码    nvarchar
        public string OpenNum { get; set; }
        //OpenType    开奖类型 int
        public int OpenType { get; set; }
        //OpenNote    开奖日志：	nvarchar
        public string OpenNote { get; set; }
        //EndTime 开奖时间 datetime
        public DateTime EndTime { get; set; }

    }
}
