using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Opera
    {

        [Display(Name = "編號")]
        public int OperaID { get; set; }

        [Display(Name = "歌劇名稱")]
        [Required(ErrorMessage = "歌劇名稱不可以空白")]
        [StringLength(200)]
        public string Title { get; set; }

        [Display(Name = "年代")]
        [CheckValidYear]
        public int? Year { get; set; }

        [Display(Name = "作者")]
        [Required]
        public string Composer { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }

}
