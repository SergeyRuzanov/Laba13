using Laba10;
using System;

namespace Laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewSortedDictionary<string, Person> myNewSortedDictionary_1 = new MyNewSortedDictionary<string, Person>("Первая коллекция");
            myNewSortedDictionary_1.Add("ИвинаАлена", new Administration("Алена", "Ивина", Gender.Female, 2));
            myNewSortedDictionary_1.Add("БетевИван", new Administration("Иван", "Бетев", Gender.Male, 5));
            myNewSortedDictionary_1.Add("ГаукДана", new Working("Дана", "Гаук", Gender.Female, Category.Middle));
            myNewSortedDictionary_1.Add("ИвановАндрей", new Engineer("Андрей", "Иванов", Gender.Male, Category.God));

            MyNewSortedDictionary<string, Person> myNewSortedDictionary_2 = new MyNewSortedDictionary<string, Person>("Вторая коллекция");
            myNewSortedDictionary_2.Add("ТучинСергей", new Administration("Сергей", "Тучин", Gender.Female, 2));
            myNewSortedDictionary_2.Add("ИвинСергей", new Administration("Сергей", "Ивин", Gender.Male, 5));
            myNewSortedDictionary_2.Add("ФиллиповаНастя", new Working("Настя", "Филлипова", Gender.Female, Category.Middle));
            myNewSortedDictionary_2.Add("КраснюковаКатя", new Engineer("Катя", "Краснюкова", Gender.Male, Category.God));

            Journal journal_1 = new Journal();
            myNewSortedDictionary_1.CollectionCountChanged += journal_1.AddEntry;
            myNewSortedDictionary_1.CollectionReferenceChanged += journal_1.AddEntry;

            Journal journal_2 = new Journal();
            myNewSortedDictionary_1.CollectionReferenceChanged += journal_2.AddEntry;
            myNewSortedDictionary_2.CollectionReferenceChanged += journal_2.AddEntry;

            myNewSortedDictionary_1.Add("ЯрыжновМаксим", new Administration("Максим", "Ярыжнов", Gender.Male, 5));
            myNewSortedDictionary_2.Add("БызоваНастя", new Working("Настя", "Бызова", Gender.Female, Category.Middle));

            myNewSortedDictionary_1.Remove(2);
            myNewSortedDictionary_2.Remove(3);

            myNewSortedDictionary_1[1] = ("ВасилюкАнтон", new Engineer("Антон", "Василюк", Gender.Male, Category.God));
            myNewSortedDictionary_2[3] = ("ГатауллинаЭля", new Engineer("Эля", "Гатауллина", Gender.Male, Category.God));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("journal_1:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(journal_1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("journal_2:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(journal_2);

            Console.ReadKey();
        }
    }
}
