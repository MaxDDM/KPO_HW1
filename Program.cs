using HW1.AnimalsClasses;
using HW1.EntitiesForAccounting;
using HW1.Interfaces;
using HW1.ThingsClasses;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.Clinic = new Clinic(new DI());
            String? input = "";

            do
            {
                Console.WriteLine("Если хотите добавить объект, введите 1\n" +
                    "Если хотите удалить объект, введите 2\n" +
                    "Если хотите получить информацию об объектах зоопарка, введите 3\n" +
                    "Если хотите получить информацию о животных для контактного зоопарка, введите 4\n" +
                    "Если хотите получить информацию о необходимом количестве еды, введите 5\n" +
                    "Если хотите закончить, введите 0\n");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        break;
                    case "1":
                        Console.WriteLine("Введите тип объекта:\n");
                        String type = Console.ReadLine();
                        Console.WriteLine("Если объект - животное, введите количество еды" +
                            " иначе введите любой неподходящий набор символов:\n");
                        int food = -1;
                        int.TryParse(Console.ReadLine(), out food);
                        Console.WriteLine("Если объект - травоядное животное, введите его уровень " +
                            "доброты, иначе введите любую неподходящую послеовательность символов:\n");
                        int kindnessLevel = -1;
                        int.TryParse(Console.ReadLine(), out kindnessLevel);
                        bool flag = false;
                        try
                        {
                            switch (type)
                            {
                                case "Animal":
                                    flag = !zoo.AddObject<IAnimal>(new Animal(food), typeof(Animal));
                                    break;
                                case "Herbo":
                                    flag = !zoo.AddObject<IAnimal>(new Herbo(food, kindnessLevel), typeof(Herbo));
                                    break;
                                case "Predator":
                                    flag = !zoo.AddObject<IAnimal>(new Predator(food), typeof(Predator));
                                    break;
                                case "Monkey":
                                    flag = !zoo.AddObject<IAnimal>(new Monkey(food, kindnessLevel), typeof(Monkey));
                                    break;
                                case "Rabbit":
                                    flag = !zoo.AddObject<IAnimal>(new Rabbit(food, kindnessLevel), typeof(Rabbit));
                                    break;
                                case "Tiger":
                                    flag = !zoo.AddObject<IAnimal>(new Tiger(food), typeof(Tiger));
                                    break;
                                case "Wolf":
                                    flag = !zoo.AddObject<IAnimal>(new Wolf(food), typeof(Wolf));
                                    break;
                                case "Thing":
                                    zoo.AddObject<IThing>(new Thing(), typeof(Thing));
                                    break;
                                case "Table":
                                    zoo.AddObject<IThing>(new Table(), typeof(Table));
                                    break;
                                case "Computer":
                                    zoo.AddObject<IThing>(new Computer(), typeof(Computer));
                                    break;
                                case "Employee":
                                    zoo.AddObject<IEmployee>(new Employee(), typeof(Employee));
                                    break;
                                default:
                                    Console.WriteLine("Такой объект невозможно добавить");
                                    break;
                            }
                        } 
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Подано некорректное значение для еды или уровня доброты\n");
                            continue;
                        }
                        if (flag)
                        {
                            Console.WriteLine("Животное нельзя добавить из-за его состояния здоровья");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Введите один из трёх типов удаляемого объекта: Animal, Thing или Employee:\n");
                        String typeToDelete = Console.ReadLine();
                        Console.WriteLine("Введите индекс удаляемого объекта:\n");
                        int index = -1;
                        int.TryParse(Console.ReadLine(), out index);
                        try
                        {
                            switch (typeToDelete)
                            {
                                case "Animal":
                                    zoo.DeleteObject<IAnimal>(index);
                                    break;
                                case "Thing":
                                    zoo.DeleteObject<IThing>(index);
                                    break;
                                case "Employee":
                                    zoo.DeleteObject<IEmployee>(index);
                                    break;
                                default:
                                    Console.WriteLine("Введён некорректный тип\n");
                                    continue;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Передан некорректный индекс\n");
                            continue;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Введите один из трёх типов объектов," +
                            "о которых хотите получить информацию: Animal, Thing или Employee:\n");
                        String infoType = Console.ReadLine();
                        switch (infoType)
                        {
                            case "Animal":
                                List<IAnimal> listAnimal = zoo.GetInfo<IAnimal>();
                                for (int i = 0; i < listAnimal.Count(); ++i)
                                {
                                    Console.WriteLine(listAnimal[i]);
                                }
                                break;
                            case "Thing":
                                List<IThing> listThing = zoo.GetInfo<IThing>();
                                for (int i = 0; i < listThing.Count(); ++i)
                                {
                                    Console.WriteLine(listThing[i]);
                                }
                                break;
                            case "Employee":
                                List<IEmployee> listEmployee = zoo.GetInfo<IEmployee>();
                                for (int i = 0; i < listEmployee.Count(); ++i)
                                {
                                    Console.WriteLine(listEmployee[i]);
                                }
                                break;
                            default:
                                Console.WriteLine("Введён некорректный тип\n");
                                continue;
                        }
                        break;
                    case "4":
                        List<IAnimal> list = zoo.ContactZooList();
                        for (int i = 0; i < list.Count(); ++i)
                        {
                            Console.WriteLine(list[i]);
                        }
                        break;
                    case "5":
                        Console.WriteLine(zoo.Food + "\n");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверный набор символов, попробуйте ещё раз\n");
                        continue;
                }

            } while (input != "0");
        }
    }
}