using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    //管理员模型
    public class tb_Root
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="编号")]
        public int RoID { get; set; }
        [Required(ErrorMessage = "*账号不能为空")]
        [StringLength(20,MinimumLength =2,ErrorMessage = "*管理员账号需要{2}到{1}个字符")]
        [Display(Name ="管理员账号")]
        [RegularExpression(@"^@.*", ErrorMessage = "*请正确的输入管理员账号，以@开头")]
        public string RoName { get; set; }
        [Display(Name ="管理员密码")]
        [Required(ErrorMessage = "*不能为空")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "*密码长度不符，应为{2}到{1}个字符")]
        [DataType(DataType.Password)]
        public string RoPwd { get; set; }
    }
}
