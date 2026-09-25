# ➕ Sum of the Digits of an Integer

Kullanıcıdan alınan tamsayının basamaklarındaki rakamları aritmetik operatörler (`%` ve `/`) kullanarak ayrıştıran ve toplamını hesaplayan C# konsol uygulaması.

---

## 📌 Problem Tanımı

Girilen pozitif veya negatif bir sayının tüm basamak değerlerini toplayıp sonucu biçimlendirilmiş bir kart arayüzünde ekrana basmak.

- **Basamak Ayrıştırma Mantığı (`SumOfDigits`):**
  - `lastDigit = x % 10`: Sayının birler basamağını elde eder.
  - `sum += lastDigit`: Elde edilen basamağı kümülatif toplama ekler.
  - `x /= 10`: Tamsayı bölmesi sayesinde işlenen basamağı sayıdan atar.
- **Uç Durum (Edge Case) Denetimi:** Negatif sayıların da basamaklarının doğru toplanabilmesi için döngü öncesinde `Math.Abs(number)` uygulanır.
- **Girdi Doğrulama (`InputNumber`):** `int.TryParse` ve boş dize kontrolü (`?? ""`) ile hatalı kullanıcı girişleri filtrelenir.
- **Dinamik Kart Çerçevesi:** `Math.Max` ile başlık ve içerik satırlarının en uzun olanı tespit edilerek tam oturan ayırıcı çizgiler (`divider`) oluşturulur.

---

## 🧪 Beklenen Çıktı

```text
Enter an integer: 567

-----------------------------------
    Sum of Digits of an Integer
-----------------------------------

    Input Number : 567
    Digit Sum    : 18

-----------------------------------
```