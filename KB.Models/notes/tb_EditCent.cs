using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB.Models
{
    public class tb_EditCent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int ID { get; set; }
        [Display(Name = "客户ID")]
        public int AdID { get; set; }
        [Display(Name = "编辑前客户币数")]
        public decimal BeforeCent { get; set; }
        [Display(Name = "编辑后客户币数")]
        public decimal AfterCent { get; set; }
        [Display(Name = "添加时间")]
        public DateTime AddTime { get; set; }
    }
}
