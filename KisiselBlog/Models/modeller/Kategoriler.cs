using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KisiselBlog.Models.modeller
{
    [Table("Kategoriler")]
    public class Kategoriler
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(30),Required]
        public string KategoriAdi { get; set; }
        
        public virtual List<Yazi> Yazilar { get; set; }
    }
}