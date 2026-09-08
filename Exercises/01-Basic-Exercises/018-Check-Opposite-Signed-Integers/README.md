# ⚖️ Check Opposite-Signed Integers

Kullanıcıdan alınan iki tam sayının zıt işaretli olup olmadığını kontrol eden, renkli konsol çıktısı ve dinamik ayırıcı çizgiler kullanan C# konsol uygulaması.

---

## 📌 Problem Tanımı

Kullanıcıdan alınan iki tam sayıyı inceleyen ve sayılardan **biri negatif, diğeri pozitifse** `true`, aksi durumlarda (her ikisi pozitif, her ikisi negatif veya sıfır bulunması halinde) `false` döndüren bir C# programı yazınız.

- **Kullanılan Yaklaşım:** Expression-bodied metot (`=>`), `int.TryParse` ile güvenli girdi döngüsü, dinamik çizgi boyutu ve renkli konsol çıktısı (`ConsoleColor`).

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Sayı Girişi:** `InputInteger` fonksiyonu `int.TryParse` denetimi yaparak hatalı veya harf içeren girişlerde sarı renkli uyarı verir ve geçerli bir tam sayı girilene kadar döngüyü sürdürür.
- **Expression-Bodied Mantıksal Fonksiyon:** `AreOppositeSigned` metodu tek satırda `(num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0)` mantığını değerlendirir.
- **Koşullu Konsol Renklendirmesi:** Cümle gövdesi standart konsol renginde kalırken, mantıksal sonuç ternary operatörü ile dinamik olarak renklendirilir: `True` için **Yeşil**, `False` için **Kırmızı**.
- **Dinamik Çizgi Boyutlandırma:** Ayırıcı çizgiler üretilen metnin toplam karakter uzunluğuna (`fullText.Length`) göre tam uyumlu olarak çizilir.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1

**Giriş:**
```text
Enter the first integer	: -1
Enter the second integer: 2
```

**Çıktı:**
```text
-------------------------------------------------------
The integers -1 and 2 have opposite signs: True
-------------------------------------------------------
```

---

### Test Verisi 2

**Giriş:**
```text
Enter the first integer	: 2
Enter the second integer: -1
```

**Çıktı:**
```text
-------------------------------------------------------
The integers 2 and -1 have opposite signs: True
-------------------------------------------------------
```

---

### Test Verisi 3

**Giriş:**
```text
Enter the first integer	: -5
Enter the second integer: -6
```

**Çıktı:**
```text
---------------------------------------------------------
The integers -5 and -6 have opposite signs: False
---------------------------------------------------------
```

---

### Test Verisi 4

**Giriş:**
```text
Enter the first integer	: 10
Enter the second integer: 20
```

**Çıktı:**
```text
---------------------------------------------------------
The integers 10 and 20 have opposite signs: False
---------------------------------------------------------
```