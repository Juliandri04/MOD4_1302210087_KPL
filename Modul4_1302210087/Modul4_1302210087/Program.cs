using System;
using System.Xml.Serialization;

class KodeBuah
{
    public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};
    public static string getKodeBuah(Buah buah)
    {
        string[] kode_buah = {"A00", "BOO", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kode_buah[(int)buah];
    }
}

class posisiKarakterGame
{
    public enum StatKey {Tengkurep, Jongkok, Berdiri, Terbang}
}

public class main
{
    static void Main(string[] args)
    {
        KodeBuah.Buah buah = KodeBuah.Buah.Durian;
        string kode_buah = KodeBuah.getKodeBuah(buah);
        Console.WriteLine("Kode Buah "+ buah +": " + kode_buah+"\n");

        string sesuatu = Console.ReadLine();
        posisiKarakterGame.StatKey declare = posisiKarakterGame.StatKey.Tengkurep;
        if((declare == posisiKarakterGame.StatKey.Tengkurep || declare == posisiKarakterGame.StatKey.Jongkok || declare == posisiKarakterGame.StatKey.Berdiri || declare == posisiKarakterGame.StatKey.Terbang) && sesuatu !=null && sesuatu == "TombolS")
        {
            Console.WriteLine("Tombol arah bawah ditekan");

        }
    }
}