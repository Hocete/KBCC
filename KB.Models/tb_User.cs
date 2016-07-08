using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "用户ID")]
        public int UsID { get; set; }
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "用户名需要{1}到{0}个字符")]
        [Display(Name = "用户名")]
        [RegularExpression(@"^[\u4E00-\u9FA5A-Za-z0-9]+$", ErrorMessage = "请正确的输入用户名")]
        public string UsName { get; set; }
        [Display(Name = "用户密码")]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "密码长度不符，应为{1}到{0}个字符")]
        [DataType(DataType.Password)]
        public string UsPwd { get; set; }
        [Display(Name ="客户ID")]
        public int AdID { get; set; }
        [Display(Name = "钱币数量")]
        public decimal Cent { get; set; }
        [Display(Name = "备注名称")]
        public string MarkName { get; set; }
        [Display(Name = "备注信息")]
        public string Content { get; set; }
        [Display(Name = "可玩的游戏")]
        public string CanGame { get; set; }
    }
}
