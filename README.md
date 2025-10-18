# VB.NET_Giris_Paneli
# VB.NET Giriş Paneli

Bir VB.NET / C# GUI uygulaması olarak geliştirilmiş, kullanıcı giriş (login) ve kayıt (signup) işlemlerini yöneten temel bir panel.  
Projede güvenlik için kriptografi desteği ve kullanıcı yönetimi özellikleri bulunmaktadır.

---

## İçindekiler

- [Özellikler](#özellikler)  
- [Kurulum & Çalıştırma](#kurulum--çalıştırma)  
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)  
- [Yapılandırma](#yapılandırma)  
- [Şifreleme & Güvenlik](#şifreleme--güvenlik)  
- [Katkıda Bulunma](#katkıda-bulunma)  
- [Lisans](#lisans)

---

## Özellikler

- Kullanıcı girişi ve şifre kontrolü  
- Kayıt olma ekranı  
- Temel doğrulama işlemleri (kullanıcı adı, şifre eşleşmesi)  
- Şifrelerin güvenli şekilde saklanması (kriptografi modülü ile)  
- Ayarlar ve koruma (guard) modülleri  
- Projenin genişletilebilmesi için modüler yapı  

---

## Kurulum & Çalıştırma

Aşağıdaki adımları izleyerek projeyi yerel ortamında çalıştırabilirsin:

1. Bu repoyu klonla:
   ```bash
   git clone https://github.com/Ardaa24/VB.NET_Giris_Paneli.git
2. Visual Studio ya da tercih ettiğin geliştirme ortamında projeyi aç.

3. Gerekli .NET Framework sürümünün yüklü olduğundan emin ol (proje ayarlarında hangi sürüm kullanılıyorsa o).

4. Projeyi derle ve çalıştır (F5 tuşu / "Start" komutu).

5. Uygulama açıldığında, giriş ekranı görünür. Yeni kullanıcı kaydı için "Register / Signup" ekranına yönlenebilirsin.

---

Kullanılan Teknolojiler
C# / VB.NET (projede C# kodları var gibi görünüyor)

.NET Framework / Windows Forms

Kriptografi / Hashing modülü

Modüler mimari (Guard, Settings, Cryptology gibi alt sınıflar)

Yapılandırma
Projede bazı dosyaların yapılandırılması gerekebilir:

settings.cs gibi ayar sınıflarında veri bağlantısı ya da ayar parametreleri bulunmaktadır.

Kriptografi sınıfının (örneğin Cryptology.cs) kullanılan algoritmalarını ve tuz (salt) değerlerini yapılandırabilirsin.

Eğer veritabanı bağlantısı kullanıyorsan, bağlantı dizesi (connection string) yapılandırılmalıdır.

---

Şifreleme & Güvenlik
Projede Cryptology sınıfı altında kriptografi işlemleri bulunmakta.

Şifreler doğrudan metin olarak saklanmaz, güvenli bir hash + salt mekanizması ile saklanmalıdır.

Giriş (login) süreçlerinde kullanıcının girdiği şifre, aynı hash+salt işlemlerinden geçirilerek veriyle eşleştirilir.

Gelecekte SSL, iki faktörlü doğrulama (2FA) gibi ilave güvenlik yöntemleri eklenebilir.

---

Katkıda Bulunma
Bu projeye katkı sağlamak istersen:

Fork’la (çatalla).

Yeni bir dal (branch) oluştur: git checkout -b benim-degisiklikim.

Değişikliklerini commit et: git commit -am 'Bir özellik ya da düzeltme ekledim'.

Dalını ana repoya push et: git push origin benim-degisiklikim.

Bir Pull Request (çekme isteği) oluştur.

Her türlü öneri, hata bildirimi ya da iyileştirme fikri memnuniyetle karşılanır.

---

Lisans
Bu proje için bir lisans bilgisi belirtilmemiş.
Varsayılan olarak MIT, Apache 2.0 ya da başka bir açık kaynak lisansı eklemeni öneririm.
Aşağıda örnek bir MIT lisansı:

---

MIT License

  Copyright (c) 2025 …

Permission is hereby granted, free of charge, to any person obtaining a copy
… (rest of MIT lisans metni)
İletişim
Proje ile ilgili sorular ya da geri bildirim için GitHub Issues bölümünden bana ulaşabilirsin. 

---

https://github.com/user-attachments/assets/eaf8d720-23e8-491f-85b1-f683910f4489

