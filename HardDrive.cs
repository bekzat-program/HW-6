using System;

namespace HW6
{
    class HardDrive : StorageDevice
    {
        // Поле для скорости чтения/записи (в мегабайтах в секунду)
        public int ReadWriteSpeed { get; set; }

        // Реализация метода StoreData для жёсткого диска
        public override void StoreData()
        {
            // Выводим сообщение о сохранении данных с указанием скорости записи
            Console.WriteLine($"Сохранение данных на жёсткий диск со скоростью {ReadWriteSpeed} МБ/с.");
        }
    }
}
