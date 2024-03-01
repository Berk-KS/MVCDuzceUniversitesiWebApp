using Microsoft.AspNetCore.Mvc;
using WebProgramlamaVize.Data;
using WebProgramlamaVize.Models;

namespace WebProgramlamaVize.Controllers
{
    public class DuyuruController : Controller
    {

        private readonly ApplicationDbContext _db;

        public DuyuruController(ApplicationDbContext db)
        {

            _db = db;
        }

        public IActionResult Index(int pg = 1)
        {
            var duyurular = from d in _db.Duyurular             //Duyurular tablosundan duyuruId'ye göre azalan şekilde sırala.
                            orderby d.duyuruId descending       //SELECT d FROM _db.Duyurular AS d WHERE 
                            select d;                           //[duyuruId],[duyuruBaslik],[duyuruIcerik],[duyuruGorsel],[duyuruTarih] ORDERBY d.duyuruId DESC
            const int pageSize = 9;                             //Bir sayfada enfazla 9 duyuru olmalıdır. Paging işlemi.
            if (pg < 1)
                pg = 1;

            int recsCount = duyurular.Count();

            var pager = new Pager(recsCount, pg, pageSize);

            int recSkip = (pg - 1) * pageSize;

            var data = duyurular.Skip(recSkip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager;

            return View(data.ToList());                         //Id'ye göre listeyi View'a yollar.
        }
    }
}
