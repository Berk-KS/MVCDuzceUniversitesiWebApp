using Microsoft.AspNetCore.Mvc;
using WebProgramlamaVize.Data;
using WebProgramlamaVize.Models;

namespace WebProgramlamaVize.Components
{
    [ViewComponent]     //View Component tanımlaması
    public class SonDuyurularViewComponent : ViewComponent 
    {
        private readonly ApplicationDbContext _db;  

        public SonDuyurularViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()       //Son üç duyuruyu listeleyen görev
        {
            var item = from i in _db.Duyurular.Take(3)          //Duyurular tablosundan ID numarasına göre son 3 duyuruyu listeler
                       orderby i.duyuruId descending            //SELECT i FROM _db.Duyurular AS i TAKE(3) WHERE
                                                                //[duyuruId],[duyuruBaslik],[duyuruIcerik],[duyuruGorsel],[duyuruTarih] 
                                                                //ORDERBY i.duyuruId DESC
                       select i;

            return View(item.ToList());                         //Listeyi vieW componentin default view'una yollar.
        }
    }
}

