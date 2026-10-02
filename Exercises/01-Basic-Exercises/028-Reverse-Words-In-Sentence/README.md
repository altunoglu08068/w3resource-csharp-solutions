# 🔄 Reverse Words in a Sentence

Kullanıcıdan alınan cümledeki kelimeleri ters sırada yazdıran C# konsol uygulaması.

---

## 📌 Problem Tanımı

Bir cümle alıp kelimeleri boşluk karakterine göre ayıran ve ardından kelimeleri sondan başa doğru yeniden düzenleyerek ekrana yazdıran program.

- **Girdi Kontrolü (`TextInput`):** Kullanıcıdan gelen girişin boş olup olmadığını kontrol eder.
- **Kelime Ayrıştırma:** `text.Split(' ')` ile cümle kelimelere ayrılır.
- **Ters Çevirme (`ReverseWords`):** Yeni bir dizi oluşturup kelimeleri tersten yerleştirir.
- **Sonuç Yazdırma (`PrintReversedWords`):** Orijinal cümleyi ve ters çevrilmiş cümleyi düzenli bir formatta gösterir.
- **Çizgi ve Çerçeve:** Metnin uzunluğuna göre eşit genişlikte ayırıcı çizgiler oluşturur.

---

## 🧪 Beklenen Çıktı

```text
Enter a sentence: Display the pattern like pyramid using the alphabet

==========================================
Original sentence                       : Display the pattern like pyramid using the alphabet
------------------------------------------
Reversed words in the sentence         : alphabet the using pyramid like pattern the Display
==========================================
```

---

## 🔍 Örnek Çalışma

Girdi:

```text
Display the pattern like pyramid using the alphabet
```

Çıktı:

```text
alphabet the using pyramid like pattern the Display
```
