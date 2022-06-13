
Geliştirilecek 1. Servis
----------------------------------------------------------------------
TestVerisiOlustur(int musteriAdet, int sepetAdet)
----------------------------------------------------------------------
- İlk parametre kaç tane müşteri yaratılacağını belirtir.



- Her bir müşterinin ad ve soyad alanları rastgele isimler olabilir.



- Her müşterinin şehir alanı, önceden belirlenmiş 10 tane şehirden biri olmalıdır; Ankara, İstanbul, İzmir, Bursa, Edirne, Konya, Antalya, Diyarbakır, Van, Rize



- İkinci parametre yaratılacak sepet adedini belirtir.



- Her bir sepet rastgele bir müşteriye ait olmalıdır.



- Her bir sepetin içinde 1-5 adet arasında ürün olmalıdır.



- Her bir ürünün tutarı 100 TL - 1000 TL arasında rastgele seçilmelidir. Ürün açıklaması rastgele olabilir.




Geliştirilecek 2. Servis
----------------------------------------------------------------------
SehirBazliAnalizYap()
----------------------------------------------------------------------
- Metod tüm müşteri ve sepet verisini kullanarak şehir bazlı analiz yapar.



- Metod DtoSehirAnaliz listesi dönmelidir. Sıralama sepet adedine göre en yüksekten başlayacak şekilde olmalıdır. Her DtoSehirAnaliz nesnesinde şehrin adı, o şehirdeki toplam sepet adedi ve o sepetlerdeki ürünlerin toplam tutarı olmalıdır.



Ankara - 50 - 5400 TL
İstanbul - 45 - 4800 TL
İzmir - 40 - 4000 TL
....



HTTP isteği sonucunda aşağıdaki gibi bir sınıfın listesinin JSON formatı dönülebilir.

Örneğin

[
{
"SehirAdi":"Ankara",
"SepetAdet":50,
"ToplamTutar":5400
},
{
"SehirAdi":"İstanbul",
"SepetAdet":45,
"ToplamTutar":4800
},
{
"SehirAdi":"İzmir",
"SepetAdet":40,
"ToplamTutar":4000
}
]
