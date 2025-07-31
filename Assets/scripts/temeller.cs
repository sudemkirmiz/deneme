using System;
using UnityEngine;

public class temeller : MonoBehaviour
{
    /*[SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int girilensayi; */
    [SerializeField] public int sýnavnot1;
    [SerializeField] public int sýnavnot2;
    [SerializeField] public int perfnot;

    [SerializeField] public int aci1;
    [SerializeField] public int aci2;
    [SerializeField] public int aci3;

    [SerializeField] public int bagajhakki;

    [SerializeField] public double urun1;
    [SerializeField] public double urun2;

    [SerializeField] public int secim;

    [SerializeField] public int baslangic;
    [SerializeField] public int bitis;

  
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


        /* if(girilensayi > 0)
         {
             Debug.Log("sayi pozitiftir");

         }
         else
         {
             Debug.Log("sayi negatif veya sýfýr");
         }*/

        //kullanýcýdan 2 sýnav ve bir performans notu girmesi Girilen 3 notun ortalamasý 50 ve daha büyükse “Baþarýlý”; deðilse “Baþarýsýz” çýktýlarý veren kodu yazýnýz.
        /*
        int deger=(sýnavnot1+sýnavnot2+perfnot)/3;
        if (deger >= 50)
        {
            Debug.Log("baþarýlý");
        }
        else
        {
            Debug.Log("baþarýsýz");
        }

        //üçgen iç açý sorusu
        int acilartop = aci1 + aci2 + aci3;
        if(acilartop == 180)
        {
            Debug.Log("bu bir üçgendir");
        }
        else
        {
            Debug.Log("üçgen deðil");
        }

        //havaalaný
        if (bagajhakki <= 20)
        {
            Debug.Log("herhangi bir ücret ödenmez");

        }
        else {
            int fazlalik = bagajhakki - 20;
            Debug.Log("Fazla bagaj için"+ fazlalik*10 +"TL ödemelisiniz.");
            
        }

        //ödeme miktarý
        double toplam = urun1 + urun2;
        if(toplam <= 200)
        {
            Debug.Log("ödenecek miktar" + toplam);
        }
        else
        {
            double indirim = (toplam * 25)/ 100;
            double toplamtutar = toplam - indirim;
            Debug.Log("Ödenecek miktar, indirimden sonra" + toplamtutar + "TL’dir.");
        } */

        //switch-case
        //girilen iki sayýyý 4 iþlemi yaptýralým
        /* switch (secim)
        {
            case 1:
                Debug.Log("pzt");
                break;
            case 2:
                Debug.Log("salý");
                break;
            case 3:
                Debug.Log("çarþ");
                break;
            case 4:
                Debug.Log("perþ");
                break;
            case 5:
                Debug.Log("cum");
                break;
            case 6:
                Debug.Log("cmt");
                break;
            case 7:
                Debug.Log("pazar");
                break;
            default:
                Debug.Log("gün yok");
                break;
        }
        //string sorularý
        //bir string arasýnda bir boþluk olacak þekilde yazdýr hardcode
        string kurum = "ERTEV";
        string sonuc = "";

        foreach (char item in kurum)
        {
            sonuc += item + " ";
        }

        Debug.Log(sonuc); */

        //for döngüsü
        int deger = 0;
        for(int i = baslangic ; i < bitis; i++)
        {
            int n = (bitis - baslangic);
            deger = (n * (n + 1)) / 2;

        }
        Debug.Log(deger);
        
        

}
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.


    }
}
