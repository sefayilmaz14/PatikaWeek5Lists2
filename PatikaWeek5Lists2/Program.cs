
//Liste Tanımlaması yapıldı
List<string> coffee = new List<string>();
Console.WriteLine("Lütfen kahve listenizi oluşturmak için girişi yapınız");

//For Döngüsü ile kullanıcıdan kahve isimleri istendi ve listeye eklendi
for (int i = 0; i < 5 ;i++)
{
    Console.WriteLine($"Kahve {i+1}:");
    coffee.Add(Console.ReadLine());
}

//Foreach döngüsü ile girilen isimler liste olarak kullanıcıya gösterildi.
Console.WriteLine("Girilen Kahve İsimleri:");
foreach (string choice  in coffee)
{

Console.WriteLine(choice); 

}