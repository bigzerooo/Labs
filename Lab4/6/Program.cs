using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static void room_show()//статический метод для вывода
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }
        static char[][] room;//статическое поле для комнаты
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());//запись целого количества строк
            room = new char[n][];//Комната имеет n строк

            //создание комнаты
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();//ввод в инпут строки комнаты
                room[row] = new char[input.Length];//инициализация
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];//и запись строк в комнату
                }
            }

            char []moves = Console.ReadLine().ToCharArray();//ходы сэма

            //поиск позиции сэма в комнате
            int[] samPosition = new int[2];//массив позиция Сэма
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;//поиск позиции сэма в комнате
                        samPosition[1] = col;//
                    }
                }
            }

            //Основной цикл
            for (int i = 0; i < moves.Length; i++)//прохождение по всем командам
            {
                //Движение противников
                for (int row = 0; row < room.Length; row++)//прохождение по строкам
                {
                    for (int col = 0; col < room[row].Length; col++)//прохождение по столбикам
                    {
                        if (room[row][col] == 'b')//если в комнате есть враг, который смотрит влево?
                        {
                            if (col + 1 >= 0 && col + 1 < room[row].Length)//Если враг не подходит к стене
                            {
                                room[row][col] = '.';
                                room[row][col + 1] = 'b';
                                col++;//то он двигается вправо
                            }
                            else
                            {
                                room[row][col] = 'd';//если подходит к стене, то разварачивается 
                            }
                        }
                        else if (room[row][col] == 'd')//если противник смотрит влево?
                        {
                            if (col - 1 >= 0 && col - 1 < room[row].Length)//если противник не подходит к стене
                            {
                                room[row][col] = '.';//то он двигается влево
                                room[row][col - 1] = 'd';
                            }
                            else//если возле стены, то поворачивается
                            {
                                room[row][col] = 'b';
                            }
                        }
                    }
                }

                //нахождение противника
                int[] getEnemy = new int[2];
                for (int j = 0; j < room[samPosition[0]].Length; j++)
                {
                    if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')//Если на линии сэма противник
                    {
                        getEnemy[0] = samPosition[0];//то этот противник записывается в массив
                        getEnemy[1] = j;
                    }
                }

                //Смерть сэма
                if (((samPosition[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd')||
                    (getEnemy[1] < samPosition[1] && room[getEnemy[0]][getEnemy[1]] == 'b'))&& (getEnemy[0] == samPosition[0]))//если противник на линии
                {                                                                                                   //и смотрит на сэма
                    room[samPosition[0]][samPosition[1]] = 'X';//Сэм умирает
                    Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");//Вывод места смерти
                    room_show();
                    Environment.Exit(0);//выход
                }

                //пермещение сэма
                room[samPosition[0]][samPosition[1]] = '.';
                switch (moves[i])
                {
                    case 'U'://вверх
                        samPosition[0]--;
                        break;
                    case 'D'://вниз
                        samPosition[0]++;
                        break;
                    case 'L'://влево
                        samPosition[1]--;
                        break;
                    case 'R'://вправо
                        samPosition[1]++;
                        break;
                    default:
                        break;
                }
                room[samPosition[0]][samPosition[1]] = 'S';//перемещение на нужную позицию
                
                //убийство николадзе
                for (int j = 0; j < room[samPosition[0]].Length; j++)
                {
                    if (room[samPosition[0]][j] == 'N')//Если николадзе найден, убийство
                    {
                        room[samPosition[0]][j] = 'X';
                        Console.WriteLine("Nikoladze killed!");
                        room_show();                        
                        Environment.Exit(0);
                    }
                }
            }            
        }

    }
}
