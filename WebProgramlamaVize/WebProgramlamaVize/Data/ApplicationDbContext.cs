using Microsoft.EntityFrameworkCore;
using WebProgramlamaVize.Models;

namespace WebProgramlamaVize.Data
{
    public class ApplicationDbContext : DbContext //Database context den ınherite alır.
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Adminler { get; set; }          //adminler tablosuyla ilişki kurar.

        public DbSet<Duyuru> Duyurular { get; set; }        //duyurular tablosuyla ilişki kurar.

        protected override void OnModelCreating(ModelBuilder modelBuilder)    //Modellerin oluşturulacağı zaman kullanılacak seedler.  
        {                       //Databasein ilk updateinde databasede oluşturulacak veriler
            #region AdminSeed           
            modelBuilder.Entity<Admin>().HasData(new Admin { adminId = 1, adminUserName= "admin@gmail.com", adminPassword = "12345" });
            modelBuilder.Entity<Admin>().HasData(new Admin { adminId = 2, adminUserName = "ilhan@gmail.com", adminPassword = "12345" });
            modelBuilder.Entity<Admin>().HasData(new Admin { adminId = 3, adminUserName = "berk@gmail.com", adminPassword = "12345" });
            #endregion

            #region DuyuruSeed
            modelBuilder.Entity<Duyuru>().HasData(new Duyuru { 
                duyuruId= 1,
                duyuruBaslik = "23 Kasım Düzce Depremi, Etkileri ve Normalleşme", 
                duyuruIcerik = "Üniversitemiz Deprem Uygulama ve Araştırma Merkezi tarafından düzenlenen “23 Kasım Düzce Depremi" +
                ", Etkileri ve Normalleşme başlıklı program, Cumhuriyet Konferans Salonu’nda gerçekleştirildi.Konferansın konuşmacısı" +
                " Üniversitemiz Deprem Uygulama ve Araştırma Merkezi Müdürü Doç. Dr. Mehmet Emin Arslan, 23 Kasım 2022 tarihinde 5,9" +
                " büyüklüğünde yaşanan depremde Düzce’nin, yapı stokunu yenilediği ve eski yapıları da güçlendirdiği için başarılı bir " +
                "süreç geçirdiğini ifade etti. Çevre Şehircilik ve İklim Değişikliği Bakanlığı ile AFAD yetkilileriyle birlikte saha " +
                "çalışmalarında bulunduğunu belirten Doç. Dr. Arslan, toptan göçme yaşanmadığını sözlerine ekledi.", 
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru { 
                duyuruId = 2,
                duyuruBaslik = "Öğretim Üyemizin Uluslararası Hakemli Tarih Dergisi TR Dizine Girdi",
                duyuruIcerik = "Üniversitemiz Fen Edebiyat Fakültesi Tarih Bölümü Öğretim Üyesi Doç. Dr. Sabit Dokuyan’ın sahibi ve editörü" +
                " olduğu “Journal of Universal History Studies” adlı uluslararası hakemli tarih dergi, TR Dizine girme başarısı gösterdi.Haziran" +
                " ve Aralık aylarında olmak üzere yılda iki sayı olarak çıkarılan Journal of Universal History Studies’de Tarih ve Arkeoloji " +
                "alanlarında çalışmalar yayınlanıyor.Yayınlanan tüm makalelere DOI numarasının atandığı dergi ile ilgili detaylı bilgilere" +
                " https://dergipark.org.tr/tr/pub/juhis internet adresinden ulaşılabiliyor.",
                duyuruGorsel = "img/DUYURU.png"  });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru { 
                duyuruId = 3,
                duyuruBaslik = "Sanal İstihdam Fuarı",
                duyuruIcerik = "Değerli Mensuplarımız,İstihdam Seferberliği kapsamında Türkiye’nin dört bir yanında gerçekleşen " +
                "İstihdam Fuarları ve Kariyer Günleri oluşturulan “Sanal Fuar” teknolojisi ile daha global ve ulaşılabilir hale gelmektedir." +
                " Vatandaşlarımız,Sanal Fuar tarihlerinde https://sanalistihdamfuari.iskur.gov.tr adresine girerek, katılımcı firmalar ile yazılı " +
                "veya görüntülü olarak görüşebilecek ve online olarak CV’ lerini bırakabileceklerdir.“Sanal Fuarı” " +
                "ziyaret etmek isteyen vatandaşlarımızın izleyeceği adımlar şu şekildedir;1)Cep telefonu, bilgisayar veya tabletinizden " +
                "https://sanalistihdamfuari.iskur.gov.tr adresine girin,2) Kayıt olun,3) Fuar tarihlerinde size gönderilen kullanıcı adı " +
                "ve şifre ile giriş yapın,4) Profilinize önceden hazırladığınız CV’ yi yükleyin veya yeni CV oluşturun,5) Katılımcı firma yetkilileri" +
                " ile görüşün, firmalar ve iş ve meslek danışmanları tarafından düzenlenecek seminerlere katılarak iş arama süreçleri ile işgücü piyasasına " +
                "ilişkin bilgi düzeyinizi artırma imkanına sahip olun,6) İstediğiniz firmaya CV’nizi bırakın.Ayrıntılı bilgiye https://sanalistihdamfuari.iskur.gov.tr/login " +
                "internet adresi üzerinden ulaşabilirsiniz.Bilgilerinize sunarız Düzce Üniversitesi Rektörlüğü",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 4,
                duyuruBaslik = "Türkçe Yeterlik Sınavı",
                duyuruIcerik = "Değerli Mensuplarımız,Yunus Emre Enstitüsü Başkanlığınca düzenlenen “Türkçe Yeterlik Sınavı (TYS)” bu yıl 14 Ocak 2023 tarihinde, " +
                "sınav başvuruları 23 Kasım-21 Aralık 2022 tarihleri arasında yapılacak..",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 5,
                duyuruBaslik = "Bölgesel Kalkınma Dergisi",
                duyuruIcerik = "Değerli Mensuplarımız,T.C. Sanayi Bakanlığı Kalkınma Ajansları Genel Müdürlüğü tarafından yayımlanmakta olanBölgesel Kalkınma Dergisi”" +
                " için makale gönderim işlemleri başlamıştır.Detaylı bilgiye htt... ", 
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 6,
                duyuruBaslik = "Polis ve İletişim",
                duyuruIcerik = "Üniversitemiz Gölyaka Meslek Yüksekokulu Halkla İlişkiler ve Tanıtım Programı'nda görevli Öğr. Gör. Nurgül Soydaş Düzce İl Emniyet Müdürlüğü" +
                " Trafik Şube biriminde çalışan görevli tüm personele, ileti.",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru { 
                duyuruId = 7,
                duyuruBaslik = "Dijital İletişim Becerileri Anlatıldı",
                duyuruIcerik = "Üniversitemiz Gölyaka Meslek Yüksekokulu Halkla İlişkiler ve Tanıtım Programı'nda görevli Öğr. Gör.Nurgül Soydaş, KTO Karatay " +
                "Üniversitesi’nde “Dijital İletişim Becerileri” konulu seminer verdi.Konya...",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 8,
                duyuruBaslik = "Eczacılık Fakültesi Uluslararası Ziyaretçi Konferansı 2022",
                duyuruIcerik = "Eczacılık Fakültesi Uluslararası Ziyaretçi Konferansı ileri bir tarihe ertelenbiştir katılımcıların dikkatine...",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru { 
                duyuruId = 9,
                duyuruBaslik = "Türk Edebiyatı’nda İnsan Hakları Üzerine Bir Söyleşi",
                duyuruIcerik = "Söyleşi online bir şekilde gerçekleştirilecektir detaylı açıklama önümüzdeki günlerde yapılacaktır.",
                duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 10,
                duyuruBaslik = "Bölgesel Kalkınma Dergisi", 
                duyuruIcerik = "Değerli Mensuplarımız,T.C. Sanayi Bakanlığı Kalkınma Ajansları Genel Müdürlüğü tarafından yayımlanmakta olan " +
                "“Bölgesel Kalkınma Dergisi” için makale gönderim işlemleri başlamıştır.Detaylı bilgiye htt...",
                 duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 11,
                duyuruBaslik = "3. Uluslararası Güvenlik Kongres",
                duyuruIcerik = "Değerli Mensuplarımız,T.C. İçişleri Bakanlığı Jandarma ve Sahil Güvenlik Akademisi (JSGA) Başkanlığı tarafından" +
                " suçla mücadelede bilimsel yöntem ve tekniklerin kullanılması temelinde birbirini tamamla...", 
                 duyuruGorsel = "img/DUYURU.png" });

            modelBuilder.Entity<Duyuru>().HasData(new Duyuru {
                duyuruId = 12, 
                duyuruBaslik = "Mezun Öğrenci Takip Sistemi",
                duyuruIcerik = "Değerli Mensuplarımız,Akdeniz Üniversitesi Eğitim Fakültesi tarafından yürütülen kalite akreditasyon çalışmaları" +
                " kapsamında \"Mezun Öğrenci Takip Sistemi\"nin kurulduğu belirtilmektedir.Mezun Öğrenci Ta...",
                duyuruGorsel = "img/DUYURU.png" });
            #endregion
        }

    }
}
