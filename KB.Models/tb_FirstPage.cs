using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB.Models
{
    public class tb_FirstPage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "标识ID")]
        public int FID { get; set; }
        [Display(Name = "客户ID")]
        [Required(ErrorMessage = "不能为空")]
        public int AdID { get; set; }
        [Display(Name = "标题")]
        public string FTile { get; set; }
        [Display(Name = "图片轮播地址")]
        public string RowUrl { get; set; }
        [Display(Name = "交流链接")]
        public string ChatUrl { get; set; }
    }
}
