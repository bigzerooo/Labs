using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            string start = Console.ReadLine();//Запись начальной строки
            string[] startA = start.Split(" ", StringSplitOptions.RemoveEmptyEntries);//Запись массива слов из строки в массив
                                                                                      //С удаление пустых значений            
            short x = Convert.ToInt16(startA[0]);//Запись координат x
            short y = Convert.ToInt16(startA[1]);//y
            int[,] matrix = new int[x, y];//Инициализация матрицы звёзд галактики

            int value = 0; //счётчик
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value; //Запись значений в матрицу звёзд
                    value++;
                }
            
            long sum = 0;//Переменная отвечающая за общую сумму звезд ИВО
            while (true)//Основной цикл
            {
                string command = Console.ReadLine();//Чтение начальной комманды
                if (command == "Let the Force be with you")//Если команда последняя, то выйти из цикла
                    break;
                else { //В противоположном случае сделать следующее   

                    startA = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);//Запись с строки начальных координат со строки ИВО
                    short xI =Convert.ToInt16(startA[0]);                        
                    int yI = Convert.ToInt32(startA[1]);

                    command = Console.ReadLine();
                    startA = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);//Запись с строки начальных координат со строки ЗЛА
                    short xE =Convert.ToInt16(startA[0]);
                    int yE =Convert.ToInt32(startA[1]);
                                    
                    while (xE >= 0 && yE >= 0)
                    {
                        if (xE < x && yE < y)
                            matrix[xE, yE] = 0;//Прохождение ЗЛОМ по своей диагонали с занулением значений звёзд
                        xE--;
                        yE--;
                    }

                    while (xI >= 0 && yI < y)
                    {
                        if (xI < x && yI >= 0)
                            sum += matrix[xI, yI];//Прохождение ИВО по своей диагонали с занулением значений звёзд
                        yI++;
                        xI--;
                    }
            }
            }
            Console.WriteLine(sum);//Вывод суммы ИВО
            Console.ReadKey();
        }
    }
}