using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //sort
        int [] sayiDizisi = {23,12,4,86,72,3,11,17};
        Console.WriteLine("****Sirasiz dizi****");
        foreach (var sayi in sayiDizisi)
        Console.WriteLine(sayi);
  
         Console.WriteLine("****Sirali dizi****");
         Array.Sort(sayiDizisi);
 
         foreach (var sayi in sayiDizisi)
        Console.WriteLine(sayi);       
        //Clear
        Console.WriteLine("****Array Clear****");
        //SayiDizisi elemanlarını kullanarak 2. index ten itaberen 2 tane elamanı 1 lar
        Array.Clear(sayiDizisi,2,2);

        foreach( var sayi in sayiDizisi )
        Console.WriteLine(sayi);

        //Reverse
        Console.WriteLine("*****Array reverse****");
        Array.Reverse(sayiDizisi);
 
        foreach( var sayi in sayiDizisi )
          Console.WriteLine(sayi);    
          
          //indexof 
          Console.WriteLine("*****Array Indexof****");
         sayiDizisi[8] = 99;
          Console.WriteLine(Array.IndexOf(sayiDizisi,99));
         
            foreach( var sayi in sayiDizisi )
          Console.WriteLine(sayi);  
          


    }
}