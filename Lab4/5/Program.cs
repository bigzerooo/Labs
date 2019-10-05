using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            int vhod = int.Parse(Console.ReadLine());//Запись вместимости мешка
            string[] seif = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Запись вещей из сейфа            
            var torba = new Dictionary<string, Dictionary<string, int>>();//словарь мешка
            //торба - это словарь, который имеет строчное общее название ценности и запись конкретной ценности данной категории
            //с количеством(в виде словаря)
            int zlato = 0;//золото
            int kamuni = 0;//гемы
            int mangizi = 0;//наличка

            for (int i = 0; i < seif.Length; i += 2)//основной цикл
            {
                string name = seif[i]; //Название ценности
                int broika = int.Parse(seif[i + 1]);//Количество ценности

                string kvoE = "";// Строка для группы ценности

                if (name.Length == 3)//если длина названия 3, то это наличка
                {
                    kvoE = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))//если название заканчивается на гем,то это гем
                {
                    kvoE = "Gem";
                }
                else if (name.ToLower() == "gold")//если название голд, то это золото
                {
                    kvoE = "Gold";
                }
                //ниже идет ряд проверок, стоил ли брать ценность
                if (kvoE == "")//если ценность не удалось отнести к группе, то пропустить
                {
                    continue;
                }
                else if (vhod < torba.Values.Select(x => x.Values.Sum()).Sum() + broika)//Если вместимость меньше чем сумма количества ценности 
                {
                    continue;//пропустить
                }
                
                switch (kvoE)//множественный выбор по типу ценности чтобы пропустить не нужные случаи
                {
                    case "Gem"://гем
                        if (!torba.ContainsKey(kvoE))//если мешок не содержит гемов
                        {
                            if (torba.ContainsKey("Gold"))//если мешок содержит золото
                            {
                                if (broika > torba["Gold"].Values.Sum())//если количество ценности больше чем общее количество золота 
                                    continue;//пропустить
                            }
                            else
                                continue; //если не золото, пропустить
                        }
                        else if (torba[kvoE].Values.Sum() + broika > torba["Gold"].Values.Sum())//если сумма данной ценности и ценности конкретной
                            //ценности больше суммы золота в мешке, пропустить
                            continue;
                        break;
                    case "Cash"://наличка
                        if (!torba.ContainsKey(kvoE))//Если в сумке нет данной единицы
                        {
                            if (torba.ContainsKey("Gem"))//Если в сумке есть гем
                            {
                                if (broika > torba["Gem"].Values.Sum())//Если ценность единицы больше суммы ценности всех гемов, пропустить
                                    continue;
                            }
                            else//если в сумке нет гемов, пропустить
                                continue;
                        }
                        else if (torba[kvoE].Values.Sum() + broika > torba["Gem"].Values.Sum())//если в сумма группы ценности и конкретной ценности
                            //больше за сумму гемов в сумке, пропустить
                            continue;
                        break;
                }


                if (!torba.ContainsKey(kvoE))//если нет данной группы ценностей, добавить ее
                    torba[kvoE] = new Dictionary<string, int>();

                if (!torba[kvoE].ContainsKey(name))//если данная группа ценностей не содержит конкретной ценности
                    torba[kvoE][name] = 0;//то сумма ценностей конкретной ценности равна 0


                torba[kvoE][name] += broika;//добавить ценность в мешок
                switch (kvoE)
                {
                    case "Gold":
                        zlato += broika;//если это золото, указать, что золото увеличилось
                        break;
                    case "Gem":
                        kamuni += broika;//если это гем, указать, что гемы увеличились
                        break;
                    case "Cash":
                        mangizi += broika;//если это наличка, указать, что наличка увеличилась
                        break;                
                }
            }

            foreach (var x in torba)//вывод всех данных
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");//Вывод группы ценности и ее количества
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))//Сортировка за условиями задачи
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");//вывод конкретных ценностей группы и их количества
                }
            }
            Console.ReadKey();
        }
    }
}