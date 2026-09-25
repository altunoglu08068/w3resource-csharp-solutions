# 🧮 Sum of the First 500 Prime Numbers

Optimize edilmiş asallık testi ($O(\sqrt{n})$) ve sayaç tabanlı `while` döngüsü kullanarak ilk 500 asal sayının toplamını hesaplayan C# konsol uygulaması.

---

## 📌 Problem Tanımı

2'den başlayarak ardışık sayıları test etmek, bulunan her asal sayıyı toplama eklemek ve toplamda tam 500 adet asal sayıya ulaşıldığında döngüyü sonlandırıp sonucu ekrana basmak.

- **Asallık Algoritması (`IsPrime`):**
  - $\le 1$ olan sayılar elenir.
  - Sayı 2 ise doğrudan `true` döner.
  - Bölen taraması $i \times i \le n$ ($\sqrt{n}$) sınırına kadar yapılarak $O(\sqrt{n})$ zaman karmaşıklığında optimize denetim sağlanır.
- **Sayaç Mekanizması (`SumOfPrimes`):**
  - Belirli bir değere kadar değil, belirli bir **adedi** tamamlamak hedeflendiği için `count < targetCount` koşuluyla çalışan `while` döngüsü kullanılır.
  - Toplam değer `int` sınırlarını aşabileceği için `long` veri tipi tercih edilir.

---

## 🧪 Beklenen Çıktı

```text
--------------------------------------------------
    Sum of the first 500 prime numbers
--------------------------------------------------

	Result: 824693

--------------------------------------------------
```