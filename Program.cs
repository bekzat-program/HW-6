using System;

namespace HW6
{
    class Program
    {
        static void Main()
        {
            // Создаём объект класса HardDrive
            HardDrive hardDrive = new HardDrive
            {
                Capacity = 512,          // Устанавливаем ёмкость в 512 ГБ
                ReadWriteSpeed = 150      // Устанавливаем скорость записи в 150 МБ/с
            };

            // Вызываем метод StoreData для объекта HardDrive
            hardDrive.StoreData();

            // Создаём объект класса FlashDrive
            FlashDrive flashDrive = new FlashDrive
            {
                Capacity = 64,            // Устанавливаем ёмкость в 64 ГБ
                UsbType = "USB 3.0"       // Устанавливаем тип USB в "USB 3.0"
            };

            // Вызываем метод StoreData для объекта FlashDrive
            flashDrive.StoreData();
        }
    }
}
