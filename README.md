# 🎬 DapperProject - Film Veritabanı Yönetim Sistemi 🍿

---

📊 **DapperProject**, Kaggle’dan alınan büyük film verisiyle geliştirilmiş modern bir film veritabanı yönetim sistemidir.  
Bu proje, **ASP.NET Core 9.0** ve **Dapper ORM** kullanılarak geliştirilmiştir ve kullanıcılarına:

- 🎥 Filmleri listeleme
- 🔍 Filtreleme ve arama
- 📈 Grafiklerle analiz
- 📊 Gerçek zamanlı istatistik

gibi birçok gelişmiş özellik sunar.

---

## 🛠️ Backend Teknolojileri

| Teknoloji | Açıklama |
| --------- | -------- |
| 🧠 **.NET 9.0** | En güncel .NET framework |
| 🌐 **ASP.NET Core MVC** | Web uygulama çatısı |
| ⚙️ **Dapper 2.1.66** | Micro ORM teknolojisi |
| 🗄️ **Microsoft.Data.SqlClient 6.1.0** | SQL Server bağlantı sağlayıcısı |
| 🔄 **AutoMapper 13.0.1** | Nesne dönüşümleri için |

---

## 🎨 Frontend Teknolojileri

| Teknoloji | Açıklama |
| --------- | -------- |
| 🧩 **Bootstrap** | Responsive CSS framework |
| 💡 **jQuery** | JavaScript kütüphanesi |
| 📊 **Chart.js** | İnteraktif grafikler |
| 🗺️ **ECharts** |  Gelişmiş grafikler |
| 🎯 **Font Awesome** | İkon kütüphanesi |

---

## 🗃️ Veritabanı & Kaynaklar

- 🏢 **Microsoft SQL Server**
- 🎬 **Kaggle Movie Database**  
  > İçerisinde 1.140.160 adet film verisi yer almakta olup, veriler sayfalama ile optimize edilmiştir (95.014 sayfa x ~12 film).

---

## 🧠 Design Patterns

- 🧱 **Repository Pattern** – Veri erişim katmanı  
- 🧪 **Service Layer Pattern** – İş mantığı  
- 📦 **DTO Pattern** – Veri transfer nesneleri  
- 🧬 **Dependency Injection** – Bağımlılık yönetimi  

---

## 📋 Proje Özellikleri

### 🎞️ 1. Film Yönetimi

✅ Film listesi:  
`genres`, `vote_count`, `release_date`, `runtime` gibi bilgilerle birlikte gösterilir.

✅ Detay sayfası:  
Her filme özel detaylı bilgi ekranı.

✅ Gelişmiş filtreleme:  
- 🎯 Oy sayısı, puan, yıl ve tür bazlı filtreleme  
- 🔍 Arama kutusuyla film ismine göre filtreleme  
- ⚠️ Film bulunamadı uyarısı ile kullanıcı bilgilendirme

✅ Sayfalama (Pagination):  
12 film/sayfa olacak şekilde optimize edilmiş yapı.

✅ Responsive tasarım:  
Her cihazda mükemmel görünüm.

---

### 📊 2. Dashboard & Analitik Panel

| Özellik | Açıklama |
|--------|---------|
| 📈 **Toplam Film Sayısı** | Kaggle datasından alınan 1M+ veri |
| 🏆 **En Çok Oy Alan Film** | Film adı, ülke, oy bilgisi |
| 💰 **En Yüksek Hasılat** | Gelir bazlı sıralama |
| 🌍 **En Yüksek Hasılat Yapan Ve Oy Alan 5 Film Grafiği** | Gelir Ve Oy Bazlı Gösterim |
| 📉 **Gerçek Zamanlı Analiz** | Anlık veri görselleştirmeleri |

---

### 📐 3. Veri Görselleştirme

- 📊 **Chart.js** ile dinamik grafikler  
- 🌎 **ECharts** ile En Yüksek Hasılat Yapan Ve Oy Alan 5 Film Grafiği
- 🖤 **Dark Mode** destekli modern UI  
- 🖼️ **Öne Çıkan Filmler:** En çok oy almış 4 film gösterilir  

---

## 💡 Ekstra Detaylar

🔍 Kullanıcı film listesinde;

- 🎬 Film adı  
- 🕐 Yayın tarihi & Süre  
- 🗳️ Oy sayısı  
- 📚 Tür bilgisi  

gibi birçok bilgiyi hızlıca görebilir.  
🎯 **Detaya Git** butonuyla film sayfasına ulaşır ve aşağıdaki detaylara erişebilir:

- 🎫 IMDb benzeri web bağlantısı  
- 💬 Slogan  
- 🏷️ Tür ve etiket bilgileri  
- 📅 Yayın tarihi  
- ⏱️ Süre (dk)  
- 💰 Bütçe & Gelir  
- 🌍 Üretim ülkesi ve dili  
- 🧠 Anahtar kelimeler (arama için)

---
# 📸 DapperProject - Görsel Tanıtım Kartları

Projenin kullanıcıya sunduğu özellikleri daha anlaşılır kılmak için aşağıda ekran görüntüleri ve ilgili açıklamalarıyla detaylandırılmış bir kart yapısı sunulmuştur. 👇

---

## 🏠 Ana Sayfa (Dashboard)


### 🎬 Film İstatistik Paneli ve Öne Çıkan Filmler

<img width="2536" height="993" alt="Ekran görüntüsü 2025-07-31 171349" src="https://github.com/user-attachments/assets/cd61683a-e804-4422-b542-a2345612dd2d" />

<img width="1363" height="848" alt="Ekran görüntüsü 2025-07-31 171411" src="https://github.com/user-attachments/assets/8b9ec10e-12b2-47ae-ba6f-fa65c4911940" />
<img width="2525" height="1252" alt="Ekran görüntüsü 2025-07-31 171458" src="https://github.com/user-attachments/assets/6a9712c4-e4d5-422d-8c09-a3661d41db04" /> 


<img width="1370" height="1121" alt="Ekran görüntüsü 2025-07-31 171538" src="https://github.com/user-attachments/assets/746a0440-89f4-4b45-8df8-047a9efeff66" />
<img width="2541" height="1211" alt="Ekran görüntüsü 2025-07-31 171608" src="https://github.com/user-attachments/assets/6c1bc83c-bd91-4554-b4ee-4d4f538be2c6" />
<img width="2267" height="721" alt="Ekran görüntüsü 2025-07-31 171618" src="https://github.com/user-attachments/assets/cce7364e-e58b-4fa1-b535-1f2bb7c73fdb" />
<img width="1369" height="946" alt="Ekran görüntüsü 2025-07-31 172211" src="https://github.com/user-attachments/assets/6b4d531b-3629-433f-bd0d-87b573690070" />
<img width="1348" height="959" alt="Ekran görüntüsü 2025-07-31 172236" src="https://github.com/user-attachments/assets/c7844364-013b-4f0f-b4c6-83decba54a1c" />
<img width="1361" height="1079" alt="Ekran görüntüsü 2025-07-31 172039" src="https://github.com/user-attachments/assets/58ae5c7b-f9c7-47ed-8e9d-0ffebb7b7ca0" />

