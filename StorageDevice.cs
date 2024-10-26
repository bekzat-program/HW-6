using System;

namespace HW6
{
    abstract class StorageDevice
    {
        // Поле для ёмкости устройства (в гигабайтах)
        public int Capacity { get; set; }

        // Абстрактный метод для сохранения данных
        public abstract void StoreData();
    }
}
