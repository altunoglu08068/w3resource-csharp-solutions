# ✂️ Remove Character by Index

Kullanıcıdan alınan bir metinden, belirtilen indeksteki karakteri güvenli bir şekilde kaldıran C# konsol uygulaması.

---

## 📌 Problem Tanımı

Boş olmayan bir metin ve geçerli bir indeks değeri alarak, ilgili indeksteki tek bir karakteri silen bir C# programı yazınız.

- **Kullanılan Metot:** `string.Remove(startIndex, count)`

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Metin Girişi:** `TextInput` fonksiyonu ile boş (`""`) girişler engellenir ve kullanıcıya sarı renkli uyarı verilir.
- **Dinamik Aralık Kontrolü:** `IndexInput` fonksiyonu, metnin uzunluğunu (`Length`) baz alarak `0` ile `Length - 1` dışındaki tüm geçersiz indeks ve sayı dışı girişleri reddeder.
- **Hizalı Konsol Çıktısı:** `\t` tab boşluğu ile düzenli ve temiz bir sonuç ekranı sunulur.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Giriş

```text
Enter a text: w3resource
Enter an index (0 - 9): 1
```

### Çıktı

```text
You entered: w3resource
--------------------------
Resulting text	: wresource
--------------------------
```