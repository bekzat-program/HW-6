using System;

namespace HW6
{
    // Класс для флеш-накопителя, от StorageDevice
    class FlashDrive : StorageDevice
    {
        // Поле для типа USB (например, "USB 2.0" или "USB 3.0")
        public string UsbType { get; set; }

        // Реализация метода StoreData для флеш-накопителя
        public override void StoreData()
        {
            // Выводим сообщение о сохранении данных с указанием типа USB
            Console.WriteLine($"Сохранение данных на флеш-накопитель с типом USB: {UsbType}.");
        }
    }
}
