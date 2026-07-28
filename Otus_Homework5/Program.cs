using Otus_Homework5.Models.Animals;

namespace Otus_Homework5
{
    class Program
    {
        static void Main()
        {
            // Создаём оригинальный объект
            var original = new Labrador("Canis lupus", 3, true, "Labrador", "Golden");

            // Клонируем через IMyCloneable<Labrador>
            var clone = original.Clone();

            // Также можно клонировать через ICloneable (возвращает object)
            var cloneViaICloneable = ((ICloneable)original).Clone() as Labrador;

            // Изменяем оригинал, чтобы проверить независимость
            original.Age = 5;
            original.Color = "Chocolate";

            // Вывод
            Console.WriteLine("Оригинал: Возраст = {0}, Цвет = {1}", original.Age, original.Color);
            Console.WriteLine("Клон (IMyCloneable): Возраст = {0}, Цвет = {1}", clone.Age, clone.Color);
            Console.WriteLine("Клон (ICloneable): Возраст = {0}, Цвет = {1}", cloneViaICloneable.Age, cloneViaICloneable.Color);
            Console.WriteLine("Объекты разные: {0}", ReferenceEquals(original, clone) ? "Нет" : "Да");
        }
    }
}
