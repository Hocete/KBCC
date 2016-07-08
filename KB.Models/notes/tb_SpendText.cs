using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB.Models
{
    public class tb_SpendText
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int ID { get; set; }
        [Display(Name ="客户ID")]
        public int AdID { get; set; }
        [Display(Name = "用户ID")]
        public int UsID { get; set; }
        [Display(Name = "变化币数")]
        public decimal AcCent { get; set; }
        [Display(Name = "改变后的总币数")]
        public decimal AfterCent { get; set; }
        [Display(Name ="游戏ID")]
        public int GameID { get; set; }
        [Display(Name = "说明")]
        public string Content { get; set; }
        [Display(Name ="添加时间")]
        public DateTime AddTime { get; set; }


    }
}
