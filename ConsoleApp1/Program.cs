
using SDP_Asynchronous;
using SingletonDesignPattern;

Console.WriteLine("Hello, World!");
/// <summary>
/// new ile üretemiyoruz çünkü ctor'u private yapıldı. bu yüzden static memberlar üzerinden bir instance talebinde bulunmamız gerekiyor.
/// </summary>

//SDPExampleWithProp _sdp = new SDPExampleWithProp();

SDPExampleWithMethod method1 = SDPExampleWithMethod.GetInstance();
SDPExampleWithMethod method2 = SDPExampleWithMethod.GetInstance();
SDPExampleWithMethod method3 = SDPExampleWithMethod.GetInstance();
SDPExampleWithMethod method4 = SDPExampleWithMethod.GetInstance();
SDPExampleWithMethod method5 = SDPExampleWithMethod.GetInstance();

SDPExampleWithProp prop1 = SDPExampleWithProp.GetInstance;
SDPExampleWithProp prop2 = SDPExampleWithProp.GetInstance;
SDPExampleWithProp prop3 = SDPExampleWithProp.GetInstance;
SDPExampleWithProp prop4 = SDPExampleWithProp.GetInstance;
SDPExampleWithProp prop5 = SDPExampleWithProp.GetInstance;

#region Asnyc süreçlerde nesnenin birden çok kez oluşturulma problemini aşma yöntemleri
//1.YÖNTEM
//Lock mekanizması ile SDP uygulanan sınıf içinde static bir nesne tanımlanır ve bu nesne Lock mekanizmasına verilir
// static object _obj = new object();
//lock(_obj)
//if(_example==null)
//  _example=new Example();
//return _example

//2.YÖNTEM *** Bu yöntemi tercih edersek daha basit bir şekilde async süreçleri yönetmiş oluruz.
//Sınıfa bir static constructer verip nesneyi orada ürettirirsek Lock mekanizmasını kullanmaya gerek kalmaz.
List<Task> tasks = new List<Task>();

for (int i = 0; i < 100; i++) //100 kez Task oluşturduk
{
    tasks.Add(Task.Run(() =>
    {
        Example ex = Example.GetInstance;
    }));
}


await Task.WhenAll(tasks); //Tüm Task'ları çalıştırdık ama tek bir nesne üretildiğini gözlemledik.
#endregion



