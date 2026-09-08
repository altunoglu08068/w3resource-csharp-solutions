# ➕ Sum or Triple Sum

Kullanıcıdan alınan iki tam sayının toplamını hesaplayan, sayılar birbirine eşitse bu toplamın 3 katını döndüren ve yeşil vurgulu dinamik konsol çıktısı sunan C# uygulaması.

---

## 📌 Problem Tanımı

Kullanıcıdan alınan iki tam sayıyı toplayan bir C# programı yazınız. Eğer girilen sayılar birbirine eşitse, toplamlarının üç katı ($3 \times (a + b)$) hesaplanmalıdır.

- **Kullanılan Yaklaşım:** Expression-bodied ternary fonksiyon (`=>`), `int.TryParse` ile güvenli döngü, ön ek ve sonuç ayrımıyla dinamik çizgi hesabı ve renkli konsol çıktısı.

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Sayı Girişi:** `InputNumber` fonksiyonu geçersiz veya metinsel girişlerde kullanıcıya sarı renkli uyarı verir ve geçerli bir tam sayı girilene kadar sormayı sürdürür.
- **Ternary Operatörü ile Kompakt Mantık:** `CalculateSumOrTripleSum` metodu tek satırda sayılann eşitliğini denetleyerek doğru matematiksel işlemi seçer.
- **Dinamik Ayırıcı Çizgiler:** Sekme (`\t`) payı ve en uzun satır uzunluğu (`maxLength + 8`) dinamik olarak hesaplanarak terminale tam oturan çerçeve oluşturulur.
- **Hedefli Renklendirme:** Sonuç metninin tamamı yerine yalnızca sayısal sonuç (`resultText`) yeşil renkte basılarak çıktı okunabilirliği artırılır.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 (Farklı Sayılar)

**Giriş:**
```text
Enter the first number	: 1
Enter the second number	: 2
```

**Çıktı:**
```text
--------------------------------
First number	: 1
Second number	: 2
--------------------------------
Result (Sum)	: 1 + 2 = 3
--------------------------------
```

---

### Test Verisi 2 (Eşit Sayılar)

**Giriş:**
```text
Enter the first number	: 2
Enter the second number	: 2
```

**Çıktı:**
```text
-----------------------------------------
First number	: 2
Second number	: 2
-----------------------------------------
Result (Triple)	: 3 x (2 + 2) = 12
-----------------------------------------
```