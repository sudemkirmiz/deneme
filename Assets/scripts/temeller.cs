using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class temeller : MonoBehaviour
{
    //hem parametre alan hem de�er d�nd�ren
    int topla(int n, int m)
    {
        return n + m;
    }
    int cikar(int n, int m)
    {
        return n - m;
    }
    int carp(int n, int m)
    {
        return n * m;
    }
    int b�l(int n, int m)
    {
        return n / m;
    }

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

    [SerializeField] public int sayi;


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
        /* int toplam = 0;
         for(int i = baslangic ; i < bitis; i++)
         {
             toplam += i;

         }
         Debug.Log(toplam); */

        /*int sayac = 0;
        int toplam = 0;
        for (int i = baslangic; i <= bitis; i++)
        {
            sayac++;
            Debug.Log(i);
            toplam += i;
     
        }
        Debug.Log("aral�ktaki say�lar�n toplam�"+toplam);
        Debug.Log("aral�ktaki say�lar�n ortalamas�" + toplam/sayac);

        //girilen sayilarin faktoriyeli for d�ng�s� ile
        int factorial = 1;
        for(int i=1; i<=sayi; i++)
        {
            factorial *= i;
        }
        Debug.Log(sayi+"! = "+factorial); */
        //while ile faktoriyel ��z�mleme
        /* int factorial = 1;
        int i = 1;
        while (i <= sayi)
        {
            factorial *= i;
            i++;
        }
        Debug.Log(sayi + "! =" + factorial); */

        //diziler->birden fazla ayn� t�rde veri olmas� durumu

        string[] isimler = new string[12];
        isimler[0] = "sudem";
        isimler[1] = "k�bra";
        isimler[2] = "beyza";
        isimler[3] = "melis";
        isimler[4] = "selin";

        Debug.Log(isimler[5]);
        for(int i = 0; i <= isimler.Length - 1; i++)
        {
            Debug.Log(isimler[i]);
        }
        //diziden rastgele bir eleman se�elim
        string[] names = { "Ali", "veli", "hasan", "h�seyin" };
        int randomIndex =UnityEngine.Random.Range(0, names.Length);

        string randomName = names[randomIndex];

        Debug.Log(randomName);
        
        int[] sayilar = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < sayilar.Length; i++)
        {

            Debug.Log(sayilar[i]);
        }
        List<string> list = new List<string>();
        list.Add("hira");
        list.Add("elif");
        list.Add("sudem");
        list.Add("k�bra");

        foreach (string s in list)
        {
            Debug.Log(s);
        }
        list.Remove("hira");

        foreach (string m in list)
        {
            print(m);

        }
        list.Insert(0, "neslihan");
        foreach (string n in list)
        {
            print(n);

        }
        if (list.Contains("neslihan"))
        {
            Debug.Log("Ali Bulundu");
        }
        else
        {
            Debug.Log("Ali Bulunamad�");
        }

        list.Clear();//listeyi temizledik.
        foreach (string k in list)
        {
            Debug.Log(k);
        }
        //metotlar fonksiyonlar
        //parametre alan de�er d�nd�rmeyen fonksiyon kullanarak 4 i�lemi ger�ekle�tiren fonks yaz�n�z
        /*void topla(int n,int m)
        {
            int sayi = n + m;
            Debug.Log(sayi);
        }
        void cikar(int n, int m)
        {
            int sayi = n - m;
            Debug.Log(sayi);
        }
        void carp(int n, int m)
        {
            int sayi = n * m;
            Debug.Log(sayi);
        }
        void b�l(int n, int m)
        {
            int sayi = n / m;
            Debug.Log(sayi);
        }
        int sayi1 = 20;
        int sayi2 = 40;
        topla(sayi1, sayi2);
        cikar(sayi1, sayi2);
        carp(sayi1, sayi2);
        b�l(sayi1, sayi2); */

        int sayi1 = topla(7,8);
        Debug.Log(sayi1);
        int sayi2 = cikar(17, 2);
        Debug.Log(sayi2);
        int sayi3 = carp(12, 4);
        Debug.Log(sayi3);
        int sayi4 = b�l(40, 8);
        Debug.Log(sayi4);



    }
    private void Update()
    {
        // Debug.Log("Puan : " + puan);// konsola mesaj verdiriyoruz.



    }
}
