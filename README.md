# 🚘 **Cental Car Project**
Cental Araç Projesi, kullanıcıların çeşitli araç modellerini detaylı şekilde inceleyip karşılaştırabildikleri, hızlı ve kolay bir şekilde rezervasyon yapabildikleri kapsamlı bir web platformudur. 
Kullanıcılar araçlar hakkında yorum yapabilir, puan verebilir ve deneyimlerini diğer kullanıcılarla paylaşabilirler. Ayrıca doğrudan mesaj yoluyla sistemle ilgili sorularını ileterek destek alabilirler.

## 🌟 **Genel Özellikler**
- 🚗 Araç İnceleme & Karşılaştırma: Farklı araç modellerini detaylı olarak görüntüleyip kıyaslayabilirsiniz.

- 📝 Yorumlar & Puanlama: Kullanıcılar araç deneyimlerini yorumlarla aktarabilir, puan verebilir.

- 📩 Mesajlaşma & Destek: Site üzerinden hızlı mesajlaşma yoluyla destek hizmeti alınabilir.

- 👤 Profil Yönetimi: Kayıtlı kullanıcılar kendi bilgilerini yönetebilir, rezervasyon geçmişini takip edebilir.

## 🛠️ **Mimari ve Teknoloji**
Proje, ASP.NET Core MVC mimarisi ile .NET Core üzerinde, N Katmanlı Mimari prensiplerine göre inşa edilmiştir. Entity Framework Core kullanılarak Code-First Migration yöntemiyle veritabanı oluşturulmuş ve geliştirilmiştir. 
Identity kütüphanesi ile kullanıcı doğrulama ve yetkilendirme işlemleri güvenli bir şekilde sağlanmıştır.

## 📜 **Paneller ve Yetkiler**

### 🔑 **Admin Paneli**
- Rol Yönetimi: Kullanıcılara özel yetkilendirme ve rol atama.

- Rezervasyon Kontrolü: Rezervasyonları onaylama, askıya alma veya iptal etme.

- Mesajlar: Kullanıcılardan gelen mesajların takibi ve yönetimi.

- Değerlendirmeler: Araçlara ait kullanıcı puan ve yorumlarını inceleme.

- Araç ve Marka Yönetimi: Sistem üzerindeki araç ve markaların kontrolü.

- İçerik Düzenleme: Hakkımızda, hizmetler ve öne çıkan alanlar gibi bölümlerin yönetimi.

### 🧑‍💼 **Manager Paneli**
- Profil Yönetimi: Kendi kullanıcı bilgilerini güncelleme.

- Sosyal Medya Ayarları: Sosyal medya hesaplarını ekleme, düzenleme veya silme.

- Rezervasyon Takibi: Rezervasyon başvurularını görüntüleme ve yanıt verme.

### 👥 **User Paneli**
- Kullanıcı Profili: Hesap bilgilerini görüntüleme ve düzenleme.

- Rezervasyon Geçmişi: Önceki rezervasyonları görme ve takip etme.

- Araç Değerlendirmesi: Kiralanan araçlara puan ve yorum ekleme.

## 📦 **Kullanılan Araçlar ve Kütüphaneler**
- Microsoft.AspNetCore.Identity

- AutoMapper

- FluentValidation

- SweetAlert

- PagedList


Ek olarak, Areas, ViewComponents yapıları ve Lazy Loading teknikleri sayesinde sistemin performansı artırılmıştır.


### 🏠 **Kullanıcı Arayüzü (UI)**

<img width="1900" height="908" alt="default1" src="https://github.com/user-attachments/assets/11f550ab-addc-4bde-897a-82f26ad4035f" />

<img width="1894" height="908" alt="default2" src="https://github.com/user-attachments/assets/fcf21e2a-a55a-42d5-abb8-68275502ec54" />

<img width="1891" height="904" alt="default3" src="https://github.com/user-attachments/assets/3661ccc2-1611-4fb6-b0d6-293485029b0c" />

<img width="1894" height="905" alt="default4" src="https://github.com/user-attachments/assets/384e2c08-51d8-465a-995a-049693c37378" />

<img width="1881" height="901" alt="default5" src="https://github.com/user-attachments/assets/106ced60-c973-44f9-bb74-14010d0d3f69" />

<img width="716" height="909" alt="default about" src="https://github.com/user-attachments/assets/08a87e5f-3bef-4692-8ce0-f3cde256fac5" />

<img width="1185" height="903" alt="default contact" src="https://github.com/user-attachments/assets/23c43876-e4ec-4cb7-bc62-de55c580e509" />

### 🔄 **Login-Register**

<img width="1914" height="910" alt="login1" src="https://github.com/user-attachments/assets/cdcf8d26-1bd6-468b-9a4e-015f10953658" />

<img width="1915" height="912" alt="login2" src="https://github.com/user-attachments/assets/ce11b8ae-1985-41e9-a4da-b90dabf8ca69" />

### 🔑 **Admin Paneli**

<img width="1899" height="908" alt="admin1" src="https://github.com/user-attachments/assets/eac549fa-a351-4e28-a84d-a3e0b29a5497" />

<img width="1896" height="911" alt="admin2" src="https://github.com/user-attachments/assets/b88d30f9-c2e3-4d44-9e0b-4d9f5829b063" />

<img width="1901" height="910" alt="admin3" src="https://github.com/user-attachments/assets/6e0e39c5-2298-4310-8ef1-aa02ec0bbbc1" />

<img width="1899" height="908" alt="admin4" src="https://github.com/user-attachments/assets/4a66e53c-9c9b-4db5-abd9-b48a90081edf" />

<img width="1900" height="913" alt="admin5" src="https://github.com/user-attachments/assets/e95f7bf1-2dad-49c5-94a0-c0cddf813b29" />

<img width="1901" height="908" alt="admin6" src="https://github.com/user-attachments/assets/120bfea1-e550-4304-9f57-62d9892f3e16" />

<img width="1900" height="906" alt="admin7" src="https://github.com/user-attachments/assets/39b97386-b6ce-4fe3-b7bc-b066e0886095" />

<img width="1901" height="908" alt="admin8" src="https://github.com/user-attachments/assets/c212b483-843a-4f46-b58c-32d248b9c9c0" />

<img width="1899" height="910" alt="admin9" src="https://github.com/user-attachments/assets/7ec5d52a-9d1b-48f6-b5e7-7bc45a55e118" />

### 🧑‍💼 **Manager Paneli**

<img width="1898" height="907" alt="manager1" src="https://github.com/user-attachments/assets/0a904825-5678-424f-ae80-cee3b7da5949" />

<img width="1899" height="907" alt="manager2" src="https://github.com/user-attachments/assets/fa05bb45-ad33-4519-92cc-b19b3fdee265" />

<img width="1900" height="905" alt="manager3" src="https://github.com/user-attachments/assets/9142c8ba-bf61-45e9-a639-2d573b58c51d" />

### 👥 **User Paneli**

<img width="1899" height="910" alt="user1" src="https://github.com/user-attachments/assets/d93af63f-371c-4fd4-8d63-76fbe464b040" />

<img width="1900" height="908" alt="user2" src="https://github.com/user-attachments/assets/baf9c08e-f15b-4a7e-af81-c5526c2bb3d5" />
