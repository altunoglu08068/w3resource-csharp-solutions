# 🎯 Within 20 of 100 or 200 Check

Kullanıcıdan alınan bir tam sayının 100 veya 200 sayılarına mutlak olarak en fazla 20 birim mesafede olup olmadığını kontrol eden; şart sağlanıyorsa `True` (yeşil), sağlanmıyorsa `False` (kırmızı) sonucunu terminalde dinamik bir kart tasarımıyla sunan C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen bir tam sayı ($n$) için mutlak fark kontrolü yapılır:
- $|100 - n| \le 20$ (yani $n \in [80, 120]$),
- VEYA $|200 - n| \le 20$ (yani $n \in [180, 220]$),

Bu iki aralıktan herhangi birine denk geliyorsa program `True`, aksi halde `False` döndürmelidir.

- **Kullanılan Yaklaşımlar:** `Math.Abs` ile mutlak değer fark hesabı, mantıksal VEYA (`||`) operatörüyle tek satırlık expression-bodied fonksiyon (`=>`), dinamik terminal renklendirmesi (`ConsoleColor`), `int.TryParse` ile güvenli döngü ve modüler UI ayrımı (`PrintHeader`).

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Sayı Girişi:** `InputNumber` fonksiyonu boş veya `null` girişleri engeller (`?? ""`) ve geçerli bir tamsayı girilene kadar sarı uyarı vererek kullanıcıdan girdi almaya devam eder.
- **Matematiksel Mantık:** `Math.Abs` kullanılarak mesafe kontrolü karmaşık `if-else` bloklarına gerek kalmadan $\mathcal{O}(1)$ zaman ve $\mathcal{O}(1)$ bellek karmaşıklığında tek satırda çözülür.
- **Akıllı Renk Geri Bildirimi:** Sonuç `True` olduğunda yeşil, `False` olduğunda kırmızı renkle terminale basılarak kullanıcı deneyimi artırılmıştır.
- **Dinamik Sınır Çizgisi:** Karşılaştırma metinlerinin uzunluğu `Math.Max` ile hesaplanarak ayırıcı çizgilerin (`divider`) genişliği girilen sayının basamak uzunluğuna göre dinamik hizalanır.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 (Aralık Dışı)

**Giriş:**
```text
Enter an integer	: 25
```

**Çıktı:**
```text
========================================
     Within 20 of 100 or 200 Check      
========================================

--------------------------
Input number	: 25
--------------------------
Result		: False
--------------------------
```

---

### Test Verisi 2 (100'e Yakın Sınır Değeri)

**Giriş:**
```text
Enter an integer	: 115
```

**Çıktı:**
```text
========================================
     Within 20 of 100 or 200 Check      
========================================

---------------------------
Input number	: 115
---------------------------
Result		: True
---------------------------
```

---

### Test Verisi 3 (200'e Yakın Sınır Değeri)

**Giriş:**
```text
Enter an integer	: 185
```

**Çıktı:**
```text
========================================
     Within 20 of 100 or 200 Check      
========================================

---------------------------
Input number	: 185
---------------------------
Result		: True
---------------------------
```