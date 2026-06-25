using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfoSystem
{
    public class Car: IVehicle
    {
        // FIELD — arabanın ham verileri, arabanın marka ve renk bilgisini tutar, direkt dışarıdan erişilmez
        private string _brand;
        private string _color;

        // PROPERTY — fielda kontrollü erişim sağlar
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // METOT — arabanın yapabilecekleri
        public void Start()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_brand))

                    throw new Exception("Marka bilgisi boş olamaz."); //throw çalışınca hemen catch'e atlar, altındaki hiçbir satır çalışmaz.

                Console.WriteLine($"{_brand} çalıştı."); //if'e girmezse burası çalışır,catch'e  gitmez.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

        }

        public void Stop()
        {
            Console.WriteLine($"{_brand} durdu.");
        }
    }
}
