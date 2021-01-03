using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KisiselBlog.Models.modeller
{
    [Table("Yazi")]
    public class Yazi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(200),Required]
        public string baslik { get; set; }
        [StringLength(10000), Required]
        public string metin { get; set; }
        [StringLength(13)]
        public string tarih { get; set; }
        [StringLength(50)]
        public string yazar { get; set; }
        public bool aktif { get; set; }

    }
}