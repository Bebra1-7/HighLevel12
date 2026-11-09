
// // === Часть 1. Enum ===
// Weather weather = Weather.Sunny;
// Console.WriteLine(weather);
// Console.WriteLine((int)Weather.Sunny);



// // Ответьте письменно в комментарии: какое число получил каждый из четырёх вариантов Weather и откуда оно взялось, если вы его нигде не писали?
// // Sunny = 0, Cloudy = 1, Rainy = 2, Snowy = 3.
// // Числа взялись по умолчанию: в C# элементы enum автоматически нумеруются целыми числами по порядку, начиная с 0.

// === Часть 2. Enum + switch ===
// switch (weather)
// {
//     case Weather.Sunny:
//         Console.WriteLine("Возьми СПФ");
//         break;
//     case Weather.Cloudy:
//         Console.WriteLine("Можно взять зонтик");
//         break;
//     case Weather.Rainy:
//         Console.WriteLine("Возьми зонтик");
//         break;
//     case Weather.Snowy:
//         Console.WriteLine("Оденься по теплее");
//         break;
// }

// === Часть 3. Nullable ===

// int? age = null;
// double? temperature = null;

// Console.WriteLine($"{age.HasValue} \n{temperature.HasValue}");

// (age, temperature) = (18, 25.5);
// Console.WriteLine($"{age.HasValue}: {age.Value} \n{temperature.HasValue}: {temperature.Value}");

// (age, temperature) = (null, null);
// Console.WriteLine($"{age ?? 17} \n{temperature ?? 20}");

// string ageInInt = Console.ReadLine();
// if (int.TryParse(ageInInt, out int g))
// {
//     age = g;
// }
// else
// {
//     Console.WriteLine("Input incorrect age");
// }

// === Часть 4. Enum + пользовательский ввод ===
// string difficult = Console.ReadLine();
// if (Enum.TryParse<Difficulty>(difficult, true, out Difficulty difficul))
// {
//     Console.WriteLine($"Select: {difficul}");
// }
// else
// {
//     Console.WriteLine("Input incorrect");
// }

// === Итоговая задача. Параметры персонажа ===
// int? age = null;
// double? bonus = null;
// int? wins = null;

// Console.Write("Имя: ");
// string nameCharacter = Console.ReadLine();

// Console.Write("Класс (Warrior/Mage/Archer): ");
// string classInput = Console.ReadLine();

// CharacterClass cls;
// if (Enum.TryParse(classInput, true, out cls))
// {
//
// }
// else
// {
//     Console.WriteLine("Неверный ввод класса, будет использовано значение по умолчанию (Warrior).");
//     cls = CharacterClass.Warrior;
// }

// Console.Write("Возраст: ");
// string hasAge = Console.ReadLine();
// if (int.TryParse(hasAge, out int a))
//     age = a;

// Console.Write("Победы: ");
// string hasWins = Console.ReadLine();
// if (int.TryParse(hasWins, out int w))
//     wins = w;


// //bonus = 2.5;
// bonus = null;  

// Console.WriteLine();
// Console.WriteLine("=== Персонаж ===");
// Console.WriteLine($"Имя: {nameCharacter}");
// Console.WriteLine($"Класс: {cls}");
// Console.WriteLine($"Описание: {GetClassDescription(cls)}");
// Console.WriteLine($"Возраст: {age?.ToString() ?? "не указан"}");
// Console.WriteLine($"Побед: {wins ?? 0}");

// if (bonus is not null)
//     Console.WriteLine($"Доп. бонус: {bonus}");
// else
//     Console.WriteLine("Доп. бонус: не указан");

// static string GetClassDescription(CharacterClass characterClass)
// {
//     switch (characterClass)
//     {
//         case CharacterClass.Warrior:
//             return "Использует меч";
//         case CharacterClass.Mage:
//             return "Использует магию";
//         case CharacterClass.Archer:
//             return "Использует стрелы";
//         default:
//             return "Неизвестный класс";
//     }
// }

// enum CharacterClass
// {
//     Warrior,
//     Mage,
//     Archer
// }


//★ Enum
// Console.WriteLine(Traffic(TrafficLight.Red));
// Console.WriteLine(Traffic(TrafficLight.Yellow));
// Console.WriteLine(Traffic(TrafficLight.Green));

// static string Traffic(TrafficLight state)
// {
//     switch (state)
//     {
//         case TrafficLight.Red:
//             return "Стоп";
//         case TrafficLight.Yellow:
//             return "Внимание";
//         case TrafficLight.Green:
//             return "Можно идти";
//         default:
//             return "Неизвестное состояние";
//     }
// }

// enum TrafficLight
// {
//     Red,
//     Yellow,
//     Green
// }

//★★ Nullable

// Console.WriteLine(GetSum(4, 7));        // Сумма: 10      (оба числа)
// Console.WriteLine(GetSum(6, null));     // одно число
// Console.WriteLine(GetSum(null, null));  // оба null


// static string GetSum(int? x, int? y)
// {
//     if (x == null || y == null)
//     {
//         return "Сумма не может быть вычислена: одно из чисел не задано.";
//     }
//     return $"Сумма: {x + y}";
// }

//★★★ Комбинированная задача(game)
int? quantityPlayers = null;
Console.WriteLine("Input quantity players");
string Players = Console.ReadLine();
if (int.TryParse(Players, out int g))
{
    quantityPlayers = g;
}

int? quantityGame = null;
Console.Write("Введите кол-во сыгранных партиц в игре: ");
string Game = Console.ReadLine();
if (int.TryParse(Game, out int a))
{
    quantityGame = a;
}
nameGame name;
if (Enum.TryParse<nameGame>(Console.ReadLine(), true, out name))
{

}
switch (name)
{
    case nameGame.Догонялки:
        Console.WriteLine("Play in Догонялки");
        break;
    case nameGame.Салки:
        Console.WriteLine("Play in Салки");
        break;
    case nameGame.Прятки:
        Console.WriteLine("Play in Прятки");
        break;
}
Console.WriteLine($"Вас играет: {quantityPlayers} \nИ вы сыграли {quantityGame} партий");

enum nameGame
{
    Салки,
    Догонялки,
    Прятки
}
//Кратко в комментариях объясните, **почему выбранные данные действительно могут отсутствовать** и **почему здесь удобнее `enum`, а не строка**.
//Потом что он его набор позиций фиксирован и в нём нельзя допускать опечатки 

// Нужные нам enum для практики

enum Weather
{
    Sunny,
    Cloudy,
    Rainy,
    Snowy
}

enum Difficulty
{
    Easy,
    Normal,
    Hard
}