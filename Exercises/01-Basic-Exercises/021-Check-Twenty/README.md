# 🎯 Check Twenty Validator

Kullanıcıdan alınan iki tam sayıyı inceleyen; sayılardan biri 20 ise veya iki sayının toplamı 20 ediyorsa `True` (yeşil), şartlar sağlanmıyorsa `False` (kırmızı) sonucunu terminalde dinamik bir kart tasarımıyla gösteren C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen iki tam sayıyı ($num1, num2$) kontrol ediniz:
- Sayılardan herhangi biri 20 ise ($num1 = 20$ veya $num2 = 20$),
- VEYA sayıların toplamı 20 ise ($num1 + num2 = 20$),

Program `True` döndürmelidir. Aksi halde sonuç `False` olmalıdır.

- **Kullanılan Yaklaşımlar:** Mantıksal VEYA (`||`) operatörüyle tek satırlık expression-bodied fonksiyon (`=>`), dinamik terminal renklendirmesi (başarıda yeşil, başarısızlıkta kırmızı), `int.TryParse` ile güvenli döngü ve modüler UI ayrımı (`PrintHeader`).

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Sayı Girişi:** `InputNumber` fonksiyonu `null` girişleri engeller (`?? ""`) ve geçerli bir tamsayı girilene kadar sarı uyarı vererek kullanıcıdan girdi almaya devam eder.
- **Tek Satırlık Karar Mantığı:** `CheckTwenty` fonksiyonu tüm kontrolü kısa devre değerlendirmesi (short-circuit evaluation) yapan mantıksal operatörlerle tek satırda bitirir; algoritma $\mathcal{O}(1)$ zaman ve $\mathcal{O}(1)$ bellek karmaşıklığında çalışır.
- **Akıllı Renk Geri Bildirimi:** Sonuç `True` ise yeşil, `False` ise kırmızı renkle terminale basılarak kullanıcı deneyimi artırılmıştır.
- **Dinamik Sınır Çizgisi:** Karşılaştırma metinlerinin uzunluğu `Math.Max` ile taranarak ayırıcı çizgilerin (`divider`) genişliği en uzun satıra göre milimetrik ayarlanır.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 (Sayı 20)

**Giriş:**
```text
Enter the first number	: 20
Enter the second number	: 7
```

**Çıktı:**
```text
========================================
         Check Twenty Validator         
========================================

--------------------------------------
First number	: 20
Second number	: 7
--------------------------------------
Result (20 check)	: True
--------------------------------------
```

---

### Test Verisi 2 (Toplam 20)

**Giriş:**
```text
Enter the first number	: 14
Enter the second number	: 6
```

**Çıktı:**
```text
========================================
         Check Twenty Validator         
========================================

--------------------------------------
First number	: 14
Second number	: 6
--------------------------------------
Result (20 check)	: True
--------------------------------------
```

---

### Test Verisi 3 (Şart Sağlanmıyor)

**Giriş:**
```text
Enter the first number	: 10
Enter the second number	: 5
```

**Çıktı:**
```text
========================================
         Check Twenty Validator         
========================================

--------------------------------------
First number	: 10
Second number	: 5
--------------------------------------
Result (20 check)	: False
--------------------------------------
```