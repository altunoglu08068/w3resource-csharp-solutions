# 🔄 Exchange First and Last Characters

Kullanıcıdan alınan bir metnin ilk ve son karakterlerini yer değiştirerek yeni bir metin üreten C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen bir metnin ilk ve son karakterlerinin yerini takas eden (swap) bir C# programı yazınız. Eğer metin tek karakterden oluşuyorsa işlem yapılmadan metnin kendisi korunmalıdır.

- **Kullanılan Yaklaşım:** `char[]` dizisi ve modüler takas (`ChangeFirstAndLastCharacters`) fonksiyonu.

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Metin Girişi:** `InputText` fonksiyonu ile boş (`""`) girişler engellenir ve kullanıcıya sarı uyarı mesajı gösterilir.
- **Modüler Fonksiyon Yapısı:** Swap işlemi `ChangeFirstAndLastCharacters` metodu ile ayrıştırılarak tek sorumluluk prensibi (SRP) korunmuştur.
- **Sınır Durum Kontrolü (Edge Case):** `text.Length <= 1` şartı ile tek karakterli metinlerde gereksiz dizi dönüşümü yapılmadan doğrudan metin yazdırılır.
- **Hizalı Konsol Çıktısı:** `\t` tab boşlukları ve ayırıcı çizgiler ile düzenli bir sonuç arayüzü sunulur.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1

**Giriş:**
```text
Enter a text: w3resource
```

**Çıktı:**
```text
Original text	: w3resource
--------------------------
Exchanged text	: e3resourcw
--------------------------
```

---

### Test Verisi 2

**Giriş:**
```text
Enter a text: Python
```

**Çıktı:**
```text
Original text	: Python
--------------------------
Exchanged text	: nythoP
--------------------------
```

---

### Test Verisi 3

**Giriş:**
```text
Enter a text: x
```

**Çıktı:**
```text
Original text	: x
--------------------------
Exchanged text	: x
--------------------------
```