# 🔤 Convert String to Lowercase

Kullanıcıdan alınan bir metni işletim sisteminin yerel kültür kurallarına takılmadan (`ToLowerInvariant`) küçük harfe dönüştüren ve sonucu dinamik hizalanmış renkli bir CLI kart tasarımıyla terminale basan C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen bir karakter dizisinin (string) tüm büyük harfli karakterlerini küçük harfe dönüştürmek.

- **Kültür Problemi (Culture Invariant):** Standart `ToLower()` işletim sisteminin diline bakar; örneğin Türkçe sistemlerde `I` harfi küçük `i` yerine noktasız `ı` karakterine dönüşebilir. Bu durum yazılım algoritmalarında öngörülemeyen hatalara yol açtığından kültürden bağımsız çalışan `ToLowerInvariant()` tercih edilmiştir.
- **Kullanılan Yaklaşımlar:** `do-while` ile zorunlu girdi denetimi, `Trim()` ile yalnızca boşluk içeren girişlerin filtrelenmesi, expression-bodied metot (`=>`), `ConsoleColor.Green` ile terminal renklendirmesi ve `Math.Max` ile dinamik kart genişliği.

---

## 🚀 Öne Çıkan Özellikler

- **Zorunlu ve Kontrollü Girdi:** `TextInput` fonksiyonu `do-while` döngüsü kullanarak kullanıcının boşluk veya boş karakter girmesini engeller; hatalı girişte sarı uyarı vererek istemi yineler.
- **Kültürden Bağımsız Küçük Harf:** `ToLowerInvariant()` sayesinde uygulama hangi dildeki işletim sisteminde çalışırsa çalışsın daima İngilizce/ASCII standartlarında küçük harf dönüşümü yapar.
- **Dinamik Kart Çerçevesi:** `PrintHeader` fonksiyonu, girilen metnin ve dönüştürülen metnin uzunluklarını kıyaslayarak ayırıcı çizgiyi (`divider`) metin uzunluğuna göre esnetir.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 (Standart Cümle)

**Giriş:**
```text
Enter a text	: WRITE A C# PROGRAM TO DISPLAY PATTERN
```

**Çıktı:**
```text
========================================
       String to Lowercase Converter    
========================================

----------------------------------------------------------------
Original text	: WRITE A C# PROGRAM TO DISPLAY PATTERN
----------------------------------------------------------------
Lowercase text	: write a c# program to display pattern
----------------------------------------------------------------
```

---

### Test Verisi 2 (Karışık Harf ve Özel Karakterler)

**Giriş:**
```text
Enter a text	: Git & .NET CORE Platform!
```

**Çıktı:**
```text
========================================
       String to Lowercase Converter    
========================================

-------------------------------------------------
Original text	: Git & .NET CORE Platform!
-------------------------------------------------
Lowercase text	: git & .net core platform!
-------------------------------------------------
```