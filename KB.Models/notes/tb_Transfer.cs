using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KB.Models
{
    public class tb_Transfer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "编号")]
        public int ID { get; set; }
        [Display(Name = "来自ID")]
        public int AdID { get; set; }
        [Display(Name = "过给ID")]
        public int UsID { get; set; }
        [Display(Name = "变化币数")]
        public decimal AfterCent {get; set;}
        [Display(Name = "说明")]
        public string Content {get; set;}
        [Display(Name = "添加时间")]
        public DateTime AddTime {get; set;}
    }
}
