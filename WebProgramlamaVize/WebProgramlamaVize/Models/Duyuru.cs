using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaVize.Models
{
    public class Duyuru
    {
        [Key]                                               //duyuruId'yi first key yapar.
        public int duyuruId { get; set; }
        [Required]                                          //duyuruBaslik hücresini boş bırakılamaz yapar.
        public string duyuruBaslik { get; set; }            //duyuru başlık ekledik
        [Required]                                          //duyuruiçerik hücresini boş bırakılamaz yapar.
        public string duyuruIcerik { get; set; }            //duyuru içerik ekledik

        public string duyuruGorsel { get; set; }            //duyuru görsel ekledik

        public DateTime duyuruTarih { get; set; } = DateTime.Now;   //Duyurunun oluşturulduğu anlık tarih değerini ekler.
    }
}
