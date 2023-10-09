namespace loops;

class Program
{
    static void Main(string[] args)
    {
        /*int sayac = int.Parse(Console.ReadLine());
        for(int i = 1; i <= sayac;i++){
            if(i % 2 == 1){
                Console.WriteLine(i);
            }
        }*/
        //1 ile 1000 arasındaki tek ve çift sayıların toplamlarını ekrana yazdır
        int tekToplam = 0;
        int ciftToplam = 0;
        for(int i = 0;i <= 1000;i++){
            if(i % 2 == 1){
                tekToplam = tekToplam + i;
            }else{
                ciftToplam = ciftToplam + i;
            }
            
        }

        Console.WriteLine("Tek sayıların toplamı : " + tekToplam);
        Console.WriteLine("cift sayıların toplamı : " + ciftToplam);

        for(int i = 1; i < 10;i++){
            if(i==4)
            break;
            Console.WriteLine(i);
        }



    }
}
