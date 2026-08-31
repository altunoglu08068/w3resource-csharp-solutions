# 🌡️ Convert Celsius to Kelvin and Fahrenheit

Kullanıcıdan alınan Santigrat (°C) sıcaklık değerini **Kelvin (K)** ve **Fahrenheit (°F)** birimlerine dönüştüren C# konsol uygulaması.

---

## 📌 Problem Tanımı

Santigrat cinsinden girilen bir sıcaklık değerini Kelvin ve Fahrenheit birimlerine çeviren bir C# programı yazınız.

- **Kelvin Formülü:** `K = °C + 273.15`
- **Fahrenheit Formülü:** `°F = (°C × 9 / 5) + 32`

---

## 🚀 Öne Çıkan Özellikler

- **Güvenli Girdi Kontrolü:** `double.TryParse` kullanılarak geçersiz girişler engellenir ve kullanıcıya renkli uyarı mesajı verilir.
- **Modüler Yapı:** Hesaplamalar tek sorumluluk prensibine uygun olarak ifade gövdeli (expression-bodied) metotlara (`CelsiusToKelvin`, `CelsiusToFahrenheit`) ayrılmıştır.
- **Hizalı ve Hassas Çıktı:** `\t` tab boşlukları ile iki nokta üst üste (`:`) hizalaması sağlanmış ve `:F2` ile virgülden sonra iki basamak formatlanmıştır.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Giriş

```text
Enter the amount of celsius: 30
```

### Çıktı

```text
Celsius: 30,00 °C

--------------------------
Kelvin		: 303,15 K
Fahrenheit	: 86,00 °F
--------------------------
```