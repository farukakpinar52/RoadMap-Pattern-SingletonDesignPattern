using SDP_Asynchronous;

namespace SDP_Asynchronous
{
   /// <summary>
   /// BU SINIFTA STATİC CONSTRUCTER İLE NESNE ÜRETİMİ YAPILARAK ASYNC SÜREÇLERDE BİRDEN ÇOK NESNE ÜRETİLMESİ ENGELLENDİ.
   /// </summary>
    public class Example
    {
        private Example()
        {
            Console.WriteLine($"{nameof(Example)} object is created.");
        }
        static Example()
        {
            _example = new Example();
        }
        static Example? _example;

        public static Example GetInstance {  
            get {
             
                return _example; 
            } }
    }
}


