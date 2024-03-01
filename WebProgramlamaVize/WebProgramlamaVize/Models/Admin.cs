using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaVize.Models
{
    public class Admin
    {
        [Key]                                       //admin ID yi First key olarak belirledik
        public int adminId { get; set; }            
        [Required]                                  //admin username  hücresini boş bırakılamaz yapar 
        public string adminUserName { get; set; }   //Tabloya username ekledik
        [Required]                                  //admin password  hücresini boş bırakılamaz yapar
        public string adminPassword { get; set; }   //Tabloya password ekledik
    }
}
