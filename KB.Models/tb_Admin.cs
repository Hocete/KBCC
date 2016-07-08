using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "客户ID")]
        public int AdID{ get; set; }
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0}需要{2}到{1}个字符")]
        [Display(Name = "客户用户名")]
        public string AdName { get; set; }
        [Display(Name = "客户密码")]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0}长度不符，应为{2}到{1}个字符")]
        [DataType(DataType.Password)]
        public string AdPwd { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0}需要{2}到{1}个字符")]
        [Display(Name = "钱币名称")]
        public string CentName { get; set; }
        [Display(Name = "购买的游戏")]
        [DefaultValue("0")]
        public string GetGame { get; set; }
        [Display(Name = "客户系统币数")]
        [DefaultValue(0)]
        public decimal CentNum { get; set; }

    }
}
