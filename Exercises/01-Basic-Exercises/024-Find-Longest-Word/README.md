# 📏 Find Longest Word in String

Kullanıcıdan alınan bir cümledeki kelimeleri boşluk karakterine göre ayrıştıran, hazır kütüphanelere dayanmadan saf döngü mantığıyla en uzun kelimeyi ve karakter sayısını tespit eden C# konsol uygulaması.

---

## 📌 Problem Tanımı

Verilen bir metin veya cümle içerisindeki en çok karaktere (harfe) sahip olan kelimeyi bulup ekrana yazdırmak.

- **Kelimeleri Ayrıştırma:** Cümle `Split(' ')` kullanılarak boşluklardan kelime dizisine dönüştürülür.
- **Boş Eleman Denetimi (Manual Filtering):** Cümle içinde birden fazla boşluk bırakıldığında ortaya çıkan boş string (`""`) elemanları hazır kütüphane metotları yerine döngü içinde `word != ""` kontrolü ile elenir.
- **Kullanılan Yaklaşımlar:** `do-while` ile zorunlu girdi denetimi, `foreach` döngüsü ile uzunluk (`Length`) kıyaslaması, `ConsoleColor.Green` ile terminal vurgulaması ve `Math.Max` ile dinamik kart çerçevesi.

---

## 🚀 Öne Çıkan Özellikler

- **Zorunlu ve Kontrollü Girdi:** `TextInput` metodu `do-while` döngüsü kullanarak kullanıcının sadece boşluk girmesini veya boş bırakmasını engeller; hatalı girişte sarı uyarı vererek tekrar giriş ister.
- **Saf Algoritma Mantığı:** `StringSplitOptions` veya LINQ (`OrderByDescending`) gibi hazır fonksiyonlara başvurmadan, `FindLongest` fonksiyonunda her bir kelimenin uzunluğu kıyaslanarak en büyük değere sahip kelime dinamik olarak seçilir.
- **Dinamik Kart Çerçevesi:** `PrintHeader` fonksiyonu; orijinal metin, bulunan kelime ve karakter sayısı uzunluklarını karşılaştırarak terminaldeki ayırıcı çizgiyi (`divider`) en uzun satıra göre otomatik ölçekler.

---

## 🧪 Test Verileri ve Beklenen Çıktı

### Test Verisi 1 (Standart Örnek)

**Giriş:**
```text
Enter a sentence	: Write a C# Sharp Program to display the following pattern using the alphabet.
```

**Çıktı:**
```text
========================================
        Find Longest Word in String     
========================================

--------------------------------------------------------------------------------------------------
Input Sentence	: Write a C# Sharp Program to display the following pattern using the alphabet.
--------------------------------------------------------------------------------------------------
Longest Word	: following
Character Count	: 9
--------------------------------------------------------------------------------------------------
```

---

### Test Verisi 2 (Kısa Cümle)

**Giriş:**
```text
Enter a sentence	: Clean architecture leads to robust applications
```

**Çıktı:**
```text
========================================
        Find Longest Word in String     
========================================

-----------------------------------------------------------------
Input Sentence	: Clean architecture leads to robust applications
-----------------------------------------------------------------
Longest Word	: architecture
Character Count	: 12
-----------------------------------------------------------------
```