using Microsoft.AspNetCore.Mvc;
using WebProgramlamaVize.Data;
using WebProgramlamaVize.Models;
using Microsoft.AspNetCore.Http;

namespace WebProgramlamaVize.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;


        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        //Adminde duyuruları listeler
        public IActionResult Index() {

            if (HttpContext.Session.GetString("GirisYapanAdmin") == null )
            {
                return RedirectToAction("Login", "Admin");
            }

            var duyurular = from d in _db.Duyurular             //SELECT d FROM _db.Duyurular AS d WHERE
                            orderby d.duyuruId descending       //[duyuruId],[duyuruBaslik],[duyuruIcerik],[duyuruGorsel],[duyuruTarih]
                            select d;                           //ORDERBY d.duyuruId DESC
                                                                
            ViewData["duyurular"] = duyurular.ToList();
           
            return View();

        }

        [HttpPost]
        public IActionResult Index(Duyuru obj)
        {       //duyuru ekleme işlemi.
            if (Request.Form.ContainsKey("Ekle"))   //Ekle adlı button'a basılırsa alttaki kodları çalıştır.
            {

                obj.duyuruGorsel = "img/DUYURU.PNG";    //Resim yolunu ekler.
                _db.Duyurular.Add(obj);                 //Girilen Duyuru Başlık ve İçeriğini Duyurular tablosuna ekler.
                _db.SaveChanges();                      //Yapılan değişikliği kaydeder.
                
                return RedirectToAction("Index", "Admin");  //Admin panelinin Index Action'una yönlendirir.
            }

            if (Request.Form.ContainsKey("Guncelle"))
            {   //Duyuru güncelleme işlemi.
                var sObj = _db.Duyurular.Find(obj.duyuruId);    //Girilen Id numarasından tablodaki satırı bulur.
                if (sObj == null)
                {
                return NotFound();                              //Girilen Id no boşsa 404 hatasını verir.
                }
                if(obj.duyuruBaslik == null)
                {
                    obj.duyuruBaslik = sObj.duyuruBaslik;       //Başlık değiştirilmek istenmiyorsa eski başlığı eşitler.
                }
                if(obj.duyuruIcerik == null)
                {
                    obj.duyuruIcerik = sObj.duyuruIcerik;       //İçerik değiştirilmek istenmiyorsa eski içeriği eşitler.
                }
                obj.duyuruGorsel = "img/DUYURU.PNG";            //Resim yolunu ekler.
                _db.ChangeTracker.Clear();                      //Context takibini temizler.
                _db.Duyurular.Update(obj);                      //Girilen değerleri tabloda günceller.
                _db.SaveChanges();                              //Yapılan değişikliği kaydeder.
                return RedirectToAction("Index", "Admin");      //Admin panelinin Index Action'una yönlendirir.
            }


            if (Request.Form.ContainsKey("Sil"))
            {   //Duyuru silme işlemi.
                var sObj = _db.Duyurular.Find(obj.duyuruId);    //Girilen Id numarasından tablodaki satırı bulur.
                if (sObj == null)
                {
                    return NotFound();                          //Girilen Id no boşsa 404 hatasını verir.
                }
                _db.Duyurular.Remove(sObj);                     //Girilen Id No'sundaki satırı siler.
                _db.SaveChanges();                              //Yapılan değişikliği kaydeder.
                return RedirectToAction("Index", "Admin");      //Admin panelinin Index Action'una yönlendirir.
            }

            return View();                                      //Admin View'ına returnler.
        }
        //Giriş bilgisini kontrol edip panele erişim sağlar.
        public IActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Login(Admin obj)
        {
            if (Request.Form.ContainsKey("GirisYap")) // login ekranında giriş yap butonuna basıldığında...
            {
                var aObj = _db.Adminler.ToList();       //Adminler tablosundaki verileri liste şeklinde değişkene atar.
                if (aObj == null)
                {
                    return NotFound();                  //Admin tablosu boşsa 404 hatasını verir.
                }
                foreach (var row in aObj)
                {   //Admin Username ve Passwordu girilen değerlerle kıyaslar.
                    if (row.adminUserName == obj.adminUserName && row.adminPassword == obj.adminPassword)
                    {
                        HttpContext.Session.SetString("GirisYapanAdmin", row.adminUserName);    //Adminin kullanıcı adıyla oturuma yönlendirir.
                        TempData["admin"] = HttpContext.Session.GetString("GirisYapanAdmin");   //Yönlendirilen adminin bilgilerini geçici torbaya atar.
                        return RedirectToAction("Index", "Admin");  //Admin panelinin Index Action'una yönlendirir.
                    }
                }
            }
            return View();
        }

        public IActionResult Cikis()
        {   //Oturumu kapatır.
            HttpContext.Session.Remove("GirisYapanAdmin");
            return View("Login"); //Login actionuna yönlendirir.
        }

    }
}

