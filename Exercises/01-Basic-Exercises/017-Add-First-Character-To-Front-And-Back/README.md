# 🔤 Add First Character to Front and Back

Kullanıcıdan alınan metnin ilk karakterini hem en başa hem de en sona ekleyerek yeni bir metin üreten ve dinamik konsol hizalaması kullanan C# uygulaması.

---

## 📌 Problem Tanımı

Verilen en az 1 karakter uzunluğundaki bir metnin ilk karakterini (`text[0]`) yakalayıp hem başa hem de sona ekleyen bir C# programı yazınız.

- **Kullanılan Yaklaşım:** String Interpolation (`$"{firstChar}{input}{firstChar}"`) ve dinamik çizgi oluşturucu (`new string('-', length)`).

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Metin Girişi:** `TextInput` metodu ile boş (`""`) girişler engellenir, kullanıcıya sarı renkli uyarı mesajı verilir.
- **Verimli String Birleştirme:** String interpolation arka planda optimize edilmiş `string.Concat` çağrısına dönüştüğü için tek seferde bellek tahsisi yapar.
- **Dinamik Çizgi Boyutlandırma:** Ayırıcı çizgiler sabit değer yerine konsol ön eki (18 karakter) + sonuç metninin uzunluğuna göre dinamik olarak hesaplanarak üretilir.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1

**Giriş:**
```text
Enter a string: The quick brown fox jumps over the lazy dog.
```

**Çıktı:**
```text
Original text	: The quick brown fox jumps over the lazy dog.
-----------------------------------------------------------------------------
Resulting text	: TThe quick brown fox jumps over the lazy dog.T
-----------------------------------------------------------------------------
```

---

### Test Verisi 2

**Giriş:**
```text
Enter a string: w3resource
```

**Çıktı:**
```text
Original text	: w3resource
------------------------------
Resulting text	: ww3resourcew
------------------------------
```

---

### Test Verisi 3

**Giriş:**
```text
Enter a string: x
```

**Çıktı:**
```text
Original text	: x
---------------------
Resulting text	: xxx
---------------------
```