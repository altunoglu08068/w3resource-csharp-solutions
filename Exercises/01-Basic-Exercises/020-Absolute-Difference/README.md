# 📐 Absolute Difference

Kullanıcıdan alınan iki tam sayı arasındaki mutlak farkı hesaplayan; birinci sayı ikinciden büyükse mutlak farkın 2 katını, aksi halde doğrudan mutlak farkı yeşil vurguyla ekrana basan C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen iki tam sayının ($num1, num2$) farkının mutlak değerini ($|num1 - num2|$) bulunuz. Eğer ilk sayı ikinciden büyükse ($num1 > num2$), mutlak farkın iki katı ($2 \times |num1 - num2|$) döndürülmelidir.

- **Kullanılan Yaklaşımlar:** `Math.Abs`, expression-bodied ternary fonksiyon (`=>`), null-forgiving ve `int.TryParse` ile güvenli döngü, bağımsız CLI/ekran metodu (`PrintHeader`).

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Sayı Girişi:** `InputNumber` fonksiyonu `null` değerleri kontrol altına alır (`?? ""`) ve geçerli bir tamsayı girilene kadar sarı uyarı vererek döngüyü sürdürür.
- **Tek Satırlık Karar Mantığı:** `CalculateAbsoluteDifference` metodu büyüklük kontrolünü tek bir ternary ifadesiyle çözer; algoritma $\mathcal{O}(1)$ zaman ve $\mathcal{O}(1)$ alan karmaşıklığında çalışır.
- **Modüler CLI Mimarisi:** Yazdırma ve görselleştirme mantığı `PrintHeader` metoduna devredilerek `Main` metodu yalnızca veri akışını yönetecek şekilde sade tutulmuştur.
- **Dinamik Sınır Çizgisi:** Karşılaştırma metinlerinin uzunluğu `Math.Max` ile taranarak ayırıcı çizgilerin (`divider`) genişliği en uzun satıra göre dinamik hesaplanır.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 ($num1 \le num2$)

**Giriş:**
```text
Enter the first number	: 13
Enter the second number	: 40
```

**Çıktı:**
```text
========================================
      Absolute Difference Calculator     
========================================

--------------------------------------
First number	: 13
Second number	: 40
--------------------------------------
Result (Normal)	: |13 - 40| = 27
--------------------------------------
```

---

### Test Verisi 2 ($num1 > num2$)

**Giriş:**
```text
Enter the first number	: 50
Enter the second number	: 21
```

**Çıktı:**
```text
========================================
      Absolute Difference Calculator     
========================================

------------------------------------------
First number	: 50
Second number	: 21
------------------------------------------
Result (Double)	: |50 - 21| x 2 = 58
------------------------------------------
```