using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProgramlamaVize.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.adminId);
                });

            migrationBuilder.CreateTable(
                name: "Duyurular",
                columns: table => new
                {
                    duyuruId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duyuruBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruGorsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duyuruTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyurular", x => x.duyuruId);
                });

            migrationBuilder.InsertData(
                table: "Adminler",
                columns: new[] { "adminId", "adminPassword", "adminUserName" },
                values: new object[,]
                {
                    { 1, "12345", "admin@gmail.com" },
                    { 2, "12345", "ilhan@gmail.com" },
                    { 3, "12345", "berk@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Duyurular",
                columns: new[] { "duyuruId", "duyuruBaslik", "duyuruGorsel", "duyuruIcerik", "duyuruTarih" },
                values: new object[,]
                {
                    { 1, "23 Kasım Düzce Depremi, Etkileri ve Normalleşme", "img/DUYURU.png", "Üniversitemiz Deprem Uygulama ve Araştırma Merkezi tarafından düzenlenen “23 Kasım Düzce Depremi, Etkileri ve Normalleşme başlıklı program, Cumhuriyet Konferans Salonu’nda gerçekleştirildi.Konferansın konuşmacısı Üniversitemiz Deprem Uygulama ve Araştırma Merkezi Müdürü Doç. Dr. Mehmet Emin Arslan, 23 Kasım 2022 tarihinde 5,9 büyüklüğünde yaşanan depremde Düzce’nin, yapı stokunu yenilediği ve eski yapıları da güçlendirdiği için başarılı bir süreç geçirdiğini ifade etti. Çevre Şehircilik ve İklim Değişikliği Bakanlığı ile AFAD yetkilileriyle birlikte saha çalışmalarında bulunduğunu belirten Doç. Dr. Arslan, toptan göçme yaşanmadığını sözlerine ekledi.", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5083) },
                    { 2, "Öğretim Üyemizin Uluslararası Hakemli Tarih Dergisi TR Dizine Girdi", "img/DUYURU.png", "Üniversitemiz Fen Edebiyat Fakültesi Tarih Bölümü Öğretim Üyesi Doç. Dr. Sabit Dokuyan’ın sahibi ve editörü olduğu “Journal of Universal History Studies” adlı uluslararası hakemli tarih dergi, TR Dizine girme başarısı gösterdi.Haziran ve Aralık aylarında olmak üzere yılda iki sayı olarak çıkarılan Journal of Universal History Studies’de Tarih ve Arkeoloji alanlarında çalışmalar yayınlanıyor.Yayınlanan tüm makalelere DOI numarasının atandığı dergi ile ilgili detaylı bilgilere https://dergipark.org.tr/tr/pub/juhis internet adresinden ulaşılabiliyor.", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5107) },
                    { 3, "Sanal İstihdam Fuarı", "img/DUYURU.png", "Değerli Mensuplarımız,İstihdam Seferberliği kapsamında Türkiye’nin dört bir yanında gerçekleşen İstihdam Fuarları ve Kariyer Günleri oluşturulan “Sanal Fuar” teknolojisi ile daha global ve ulaşılabilir hale gelmektedir. Vatandaşlarımız,Sanal Fuar tarihlerinde https://sanalistihdamfuari.iskur.gov.tr adresine girerek, katılımcı firmalar ile yazılı veya görüntülü olarak görüşebilecek ve online olarak CV’ lerini bırakabileceklerdir.“Sanal Fuarı” ziyaret etmek isteyen vatandaşlarımızın izleyeceği adımlar şu şekildedir;1)Cep telefonu, bilgisayar veya tabletinizden https://sanalistihdamfuari.iskur.gov.tr adresine girin,2) Kayıt olun,3) Fuar tarihlerinde size gönderilen kullanıcı adı ve şifre ile giriş yapın,4) Profilinize önceden hazırladığınız CV’ yi yükleyin veya yeni CV oluşturun,5) Katılımcı firma yetkilileri ile görüşün, firmalar ve iş ve meslek danışmanları tarafından düzenlenecek seminerlere katılarak iş arama süreçleri ile işgücü piyasasına ilişkin bilgi düzeyinizi artırma imkanına sahip olun,6) İstediğiniz firmaya CV’nizi bırakın.Ayrıntılı bilgiye https://sanalistihdamfuari.iskur.gov.tr/login internet adresi üzerinden ulaşabilirsiniz.Bilgilerinize sunarız Düzce Üniversitesi Rektörlüğü", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5118) },
                    { 4, "Türkçe Yeterlik Sınavı", "img/DUYURU.png", "Değerli Mensuplarımız,Yunus Emre Enstitüsü Başkanlığınca düzenlenen “Türkçe Yeterlik Sınavı (TYS)” bu yıl 14 Ocak 2023 tarihinde, sınav başvuruları 23 Kasım-21 Aralık 2022 tarihleri arasında yapılacak..", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5128) },
                    { 5, "Bölgesel Kalkınma Dergisi", "img/DUYURU.png", "Değerli Mensuplarımız,T.C. Sanayi Bakanlığı Kalkınma Ajansları Genel Müdürlüğü tarafından yayımlanmakta olanBölgesel Kalkınma Dergisi” için makale gönderim işlemleri başlamıştır.Detaylı bilgiye htt... ", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5139) },
                    { 6, "Polis ve İletişim", "img/DUYURU.png", "Üniversitemiz Gölyaka Meslek Yüksekokulu Halkla İlişkiler ve Tanıtım Programı'nda görevli Öğr. Gör. Nurgül Soydaş Düzce İl Emniyet Müdürlüğü Trafik Şube biriminde çalışan görevli tüm personele, ileti.", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5151) },
                    { 7, "Dijital İletişim Becerileri Anlatıldı", "img/DUYURU.png", "Üniversitemiz Gölyaka Meslek Yüksekokulu Halkla İlişkiler ve Tanıtım Programı'nda görevli Öğr. Gör.Nurgül Soydaş, KTO Karatay Üniversitesi’nde “Dijital İletişim Becerileri” konulu seminer verdi.Konya...", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5202) },
                    { 8, "Eczacılık Fakültesi Uluslararası Ziyaretçi Konferansı 2022", "img/DUYURU.png", "Eczacılık Fakültesi Uluslararası Ziyaretçi Konferansı ileri bir tarihe ertelenbiştir katılımcıların dikkatine...", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5212) },
                    { 9, "Türk Edebiyatı’nda İnsan Hakları Üzerine Bir Söyleşi", "img/DUYURU.png", "Söyleşi online bir şekilde gerçekleştirilecektir detaylı açıklama önümüzdeki günlerde yapılacaktır.", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5222) },
                    { 10, "Bölgesel Kalkınma Dergisi", "img/DUYURU.png", "Değerli Mensuplarımız,T.C. Sanayi Bakanlığı Kalkınma Ajansları Genel Müdürlüğü tarafından yayımlanmakta olan “Bölgesel Kalkınma Dergisi” için makale gönderim işlemleri başlamıştır.Detaylı bilgiye htt...", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5234) },
                    { 11, "3. Uluslararası Güvenlik Kongres", "img/DUYURU.png", "Değerli Mensuplarımız,T.C. İçişleri Bakanlığı Jandarma ve Sahil Güvenlik Akademisi (JSGA) Başkanlığı tarafından suçla mücadelede bilimsel yöntem ve tekniklerin kullanılması temelinde birbirini tamamla...", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5244) },
                    { 12, "Mezun Öğrenci Takip Sistemi", "img/DUYURU.png", "Değerli Mensuplarımız,Akdeniz Üniversitesi Eğitim Fakültesi tarafından yürütülen kalite akreditasyon çalışmaları kapsamında \"Mezun Öğrenci Takip Sistemi\"nin kurulduğu belirtilmektedir.Mezun Öğrenci Ta...", new DateTime(2022, 12, 12, 19, 31, 15, 116, DateTimeKind.Local).AddTicks(5254) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "Duyurular");
        }
    }
}
