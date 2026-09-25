# 🔢 Print Odd Numbers from 1 to 99

1 ile 99 (dâhil) arasındaki tüm tek sayıları döngü, mod operatörü ve sekmeli dize hizalaması (`\t\t{i,5}`) kullanarak konsolda ortalanmış bir kart formatında listeleyen C# uygulaması.

---

## 📌 Problem Tanımı

1'den başlayıp 99'a kadar olan sayılar arasından tek olanları filtrelemek ve bunları başlıkla dengeli, hizalı bir sütun halinde ekrana basmak.

- **Dinamik Çerçeve:** `title.Length` baz alınarak `new string('-', title.Length + 16)` ile başlık genişliğine tam oturan ayırıcı çizgiler (`divider`) üretilir.
- **Tek Sayı Algoritması:** `for` döngüsü 1-99 aralığını tarar; `i % 2 == 1` koşuluyla sadece tek sayılar seçilir.
- **Hizalı Sütun Formatı:** Çıktıda `\t\t{i,5}` dize biçimlendirmesi kullanılarak sayılar kartın orta eksenine taşınır ve basamak farkı olmaksızın sağa yaslı bir sütun oluşturulur.

---

## 🧪 Beklenen Çıktı

```text
----------------------------------------
        Odd Numbers from 1 to 99
----------------------------------------

		    1
		    3
		    5
		    7
		    9
		   11
		   ..
		   95
		   97
		   99

----------------------------------------
```