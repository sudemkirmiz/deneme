using System;
using UnityEngine;

public class temeller : MonoBehaviour
{
    /*[SerializeField] public int puan;
    public bool isDeath;
    [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int girilensayi; */
    [SerializeField] public int s�navnot1;
    [SerializeField] public int s�navnot2;
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
        //Giri�
        // print("meraha unity ho�geldiniz");
        //  Debug.Log("bu biraz daha ileri seviye komut bunu kullanal�m");

        //de�i�ken tan�mlama
        /* int damage = 10;
         Debug.Log("verdi�iniz zarar : " + damage);
        */
        /*  double ondalikliBir = 1 / 3d;
          Debug.Log("Double sonu� : " + ondalikliBir);

          float ondalikliIki = 1 / 3f;
          Debug.Log("Float sonu� : " + ondalikliIki);
        */

        //String Tan�mlama

        /* string adSoyad = "Ali UYSUN";
         string kurum = "ERTEV";
         string sehir = "BURSA";


         Debug.Log("say�n : " + adSoyad );
         Debug.Log("Kurum : " + kurum);
         Debug.Log("�ehir : " + sehir);
        */

        // char tan�mlama

        /*  char cinsiyet = 'E';
          Debug.Log("Cinsiyetiniz : " + cinsiyet);


          // Boolean Tan�mlama


          isDeath = false;

          Debug.Log("�ld� m� ? " +isDeath);
        */

        //Aritmetik operat�rler  + , - , /,  *

        //hard code
        /* int sayi1 = 10;
         int sayi2 = 20;
         int toplam=sayi1+ sayi2;
         Debug.Log("SAy�lar�n Toplam� :  " + toplam);

         // dinamik fakat start i�inde 
         int toplam2 = say1 + say2;
         Debug.Log("girilen say�lar�n Toplam� " + toplam2);
        */

        /* int sayi1 = 15;
         int sayi2 = 5;
         int fark = sayi1 - sayi2;
         Debug.Log("say�lar�n Fark� : " + fark);

         int sayi11 = 15;
         int sayi22 = 5;

         int carpim = sayi11 * sayi22;
         Debug.Log("say�lar�n �arp�m� : " + carpim);

         int sayim1 = 15;
         int sayim2 = 5;
         float bolme = sayim1 / sayim2;
         Debug.Log("say�lar�n bol�m� : " + bolme);

         // say�n�n modu    a%b   a'n�n b'ye b�l�m�nden kalan

         int a = 15;
         int b = 10;

         int kalan = a % b;
         Debug.Log(a+" say�s�n "+b+" say�s�na b�l�m�nden kalan : " + kalan);
        */
        // Tekli Operat�rler  x++,x-- ,++x,--x

        //x++ =     x=x+1  
        //x-- =    x=x-1
        //++x    �nce 1 art�r sonra ata

        /*int puan = 10;

        Debug.Log("puan++: " + puan++); 
        Debug.Log("Sonraki puan: " + puan);  

        int puan2 = 10;

        Debug.Log("++puan2: " + ++puan2); 
        Debug.Log("Sonraki puan2: " + puan2);  */

        //ili�kisel operat�rler
        /*int sayi1 = 15;
        int sayi2 = 25;
        Debug.Log(sayi1 > sayi2);
        Debug.Log(sayi1 < sayi2);
        Debug.Log(sayi1 >= sayi2);
        Debug.Log(sayi1 <= sayi2); 
        Debug.Log(sayi1 != sayi2); //e�it de�ilse T
        Debug.Log(sayi1 == sayi2); //F */

        /* //mant�ksal operat�rler ve && veya ||
        string kullaniciadi = "ertev";
        string sifre = "12345";
        Debug.Log(kullaniciadi=="ertev" &&  sifre=="12345");

        //t�r d�n���m� (casting)
        float ondalikSayi = 10 / 3f;
        Debug.Log(ondalikSayi);
        Debug.Log((int)ondalikSayi); */

        //karar yap�lar� if-else
        /* int yas = 10;
        if(yas >= 10)
        {
            Debug.Log("yeti�kindir");

        }
        else
        {
            Debug.Log("k���kt�r");
        } */


        /* if(girilensayi > 0)
         {
             Debug.Log("sayi pozitiftir");

         }
         else
         {
             Debug.Log("sayi negatif veya s�f�r");
         }*/

        //kullan�c�dan 2 s�nav ve bir performans notu girmesi Girilen 3 notun ortalamas� 50 ve daha b�y�kse �Ba�ar�l��; de�ilse �Ba�ar�s�z� ��kt�lar� veren kodu yaz�n�z.
        /*
        int deger=(s�navnot1+s�navnot2+perfnot)/3;
        if (deger >= 50)
        {
            Debug.Log("ba�ar�l�");
        }
        else
        {
            Debug.Log("ba�ar�s�z");
        }

        //��gen i� a�� sorusu
        int acilartop = aci1 + aci2 + aci3;
        if(acilartop == 180)
        {
            Debug.Log("bu bir ��gendir");
        }
        else
        {
            Debug.Log("��gen de�il");
        }

        //havaalan�
        if (bagajhakki <= 20)
        {
            Debug.Log("herhangi bir �cret �denmez");

        }
        else {
            int fazlalik = bagajhakki - 20;
            Debug.Log("Fazla bagaj i�in"+ fazlalik*10 +"TL �demelisiniz.");
            
        }

        //�deme miktar�
        double toplam = urun1 + urun2;
        if(toplam <= 200)
        {
            Debug.Log("�denecek miktar" + toplam);
        }
        else
        {
            double indirim = (toplam * 25)/ 100;
            double toplamtutar = toplam - indirim;
            Debug.Log("�denecek miktar, indirimden sonra" + toplamtutar + "TL�dir.");
        } */

        //switch-case
        //girilen iki say�y� 4 i�lemi yapt�ral�m
        /* switch (secim)
        {
            case 1:
                Debug.Log("pzt");
                break;
            case 2:
                Debug.Log("sal�");
                break;
            case 3:
                Debug.Log("�ar�");
                break;
            case 4:
                Debug.Log("per�");
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
                Debug.Log("g�n yok");
                break;
        }
        //string sorular�
        //bir string aras�nda bir bo�luk olacak �ekilde yazd�r hardcode
        string kurum = "ERTEV";
        string sonuc = "";

        foreach (char item in kurum)
        {
            sonuc += item + " ";
        }

        Debug.Log(sonuc); */

        //for d�ng�s�
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
