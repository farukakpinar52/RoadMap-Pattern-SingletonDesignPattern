namespace SingletonDesignPattern
{
    /// <summary>
    /// 1.Constructer private olduğu için nesne üretilemez hale geldi. 
    /// 2.Sınıfın static bir REFERANSINI tanımlıyoruz böylece projenin herhangi bir yerinden bu referansa ulaşabiliriz
    /// 3.Sınıfın static bir memberı üzerinden nesneyi talep ediyoruz, sınıfa bu isteği ilettiğimizde eğer referans boş ise kendisi bir nesne üretip onu referansa atıyıp veriyor, eğer daha önceden üretilmiş bir nesne zaten halihazırda var ise yeni bir nesne üretmeden var olan nesneyi bize otomatik olarak dönüyor.
    /// </summary>
    public class SDPExampleWithProp
    {
        private SDPExampleWithProp()
        {
            Console.WriteLine("SDP Prop ile nesne üretildi");
        }

        static SDPExampleWithProp()
        {
            _example = new SDPExampleWithProp();
        }
        
        static SDPExampleWithProp? _example;

        public static SDPExampleWithProp GetInstance
        {
            get
            {
                #region 1.yöntem
                //if (_example == null)
                //    _example = new SDPExampleWithProp();
                //return _example;
                #endregion
                #region 2.yöntem
                //bu yöntemi kullanırken bir 'static ctor' tanımlayarak nesne üretim görevini orada veriyoruz. Bir static member çağırıldığında bir defaya mahsus static ctor tetikleneceği için nesne üretilip bize verilmiş olacak.
                return _example;
                #endregion
            }
        }

    }


}
