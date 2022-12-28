// See https://aka.ms/new-console-template for more information

string sicilnumarasi;
double calisma_saati;
double saatlik_ücreti;
double maas_hesabi;

Console.WriteLine("Sicil Numaranızı giriniz : ");
sicilnumarasi = Convert.ToString(Console.ReadLine());

Console.WriteLine("Çalışma saatinizi giriniz : ");
calisma_saati=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Saatlik ücretinizi giriniz : ");
saatlik_ücreti = Convert.ToDouble(Console.ReadLine());

//maaş hesabı çalışma sati ile saatlik ücretinin çarpılması
maas_hesabi =Convert.ToDouble(calisma_saati*saatlik_ücreti);
Console.WriteLine("Alacağınız ücret : " + maas_hesabi);

