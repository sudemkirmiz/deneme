using System;
using UnityEngine;

public class temeller : MonoBehaviour
{
    [SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int girilensayi;
    private void Start()
    {
        //Giriþ
        // print("meraha unity hoþgeldiniz");
        //  Debug.Log("bu biraz daha ileri seviye komut bunu kullanalým");

        //deðiþken tanýmlama
        /* int damage = 10;
         Debug.Log("verdiðiniz zarar : " + damage);
        */
        /*  double ondalikliBir = 1 / 3d;
          Debug.Log("Double sonuç : " + ondalikliBir);

          float ondalikliIki = 1 / 3f;
          Debug.Log("Float sonuç : " + ondalikliIki);
        */

        //String Tanýmlama

        /* string adSoyad = "Ali UYSUN";
         string kurum = "ERTEV";
         string sehir = "BURSA";


         Debug.Log("sayýn : " + adSoyad );
         Debug.Log("Kurum : " + kurum);
         Debug.Log("Þehir : " + sehir);
        */

        // char tanýmlama

        /*  char cinsiyet = 'E';
          Debug.Log("Cinsiyetiniz : " + cinsiyet);


          // Boolean Tanýmlama


          isDeath = false;

          Debug.Log("öldü mü ? " +isDeath);
        */

        //Aritmetik operatörler  + , - , /,  *

        //hard code
        /* int sayi1 = 10;
         int sayi2 = 20;
         int toplam=sayi1+ sayi2;
         Debug.Log("SAyýlarýn Toplamý :  " + toplam);

         // dinamik fakat start içinde 
         int toplam2 = say1 + say2;
         Debug.Log("girilen sayýlarýn Toplamý " + toplam2);
        */

        /* int sayi1 = 15;
         int sayi2 = 5;
         int fark = sayi1 - sayi2;
         Debug.Log("sayýlarýn Farký : " + fark);

         int sayi11 = 15;
         int sayi22 = 5;

         int carpim = sayi11 * sayi22;
         Debug.Log("sayýlarýn Çarpýmý : " + carpim);

         int sayim1 = 15;
         int sayim2 = 5;
         float bolme = sayim1 / sayim2;
         Debug.Log("sayýlarýn bolümü : " + bolme);

         // sayýnýn modu    a%b   a'nýn b'ye bölümünden kalan

         int a = 15;
         int b = 10;

         int kalan = a % b;
         Debug.Log(a+" sayýsýn "+b+" sayýsýna bölümünden kalan : " + kalan);
        */
        // Tekli Operatörler  x++,x-- ,++x,--x

        //x++ =     x=x+1  
        //x-- =    x=x-1
        //++x    önce 1 artýr sonra ata

        /*int puan = 10;

        Debug.Log("puan++: " + puan++); 
        Debug.Log("Sonraki puan: " + puan);  

        int puan2 = 10;

        Debug.Log("++puan2: " + ++puan2); 
        Debug.Log("Sonraki puan2: " + puan2);  */

        //iliþkisel operatörler
        /*int sayi1 = 15;
        int sayi2 = 25;
        Debug.Log(sayi1 > sayi2);
        Debug.Log(sayi1 < sayi2);
        Debug.Log(sayi1 >= sayi2);
        Debug.Log(sayi1 <= sayi2); 
        Debug.Log(sayi1 != sayi2); //eþit deðilse T
        Debug.Log(sayi1 == sayi2); //F */

        /* //mantýksal operatörler ve && veya ||
        string kullaniciadi = "ertev";
        string sifre = "12345";
        Debug.Log(kullaniciadi=="ertev" &&  sifre=="12345");

        //tür dönüþümü (casting)
        float ondalikSayi = 10 / 3f;
        Debug.Log(ondalikSayi);
        Debug.Log((int)ondalikSayi); */

        //karar yapýlarý if-else
        /* int yas = 10;
        if(yas >= 10)
        {
            Debug.Log("yetiþkindir");

        }
        else
        {
            Debug.Log("küçüktür");
        } */


        if(girilensayi > 0)
        {
            Debug.Log("sayi pozitiftir");

        }
        else
        {
            Debug.Log("sayi negatif veya sýfýr");
        }


    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.


    }
}
