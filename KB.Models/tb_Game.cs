using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    //系统游戏管理模型
    public class tb_Game
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "游戏ID")]
        public int GID { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "游戏名称")]
        public string GName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [Display(Name = "游戏配置表名")]
        public string GTable { get; set; }
    }
}
