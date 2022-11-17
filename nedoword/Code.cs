using nedoword;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace nedoword
{
    internal class Code
    {
        public void Cod()
        {
            Dannie var1 = new Dannie();
            var1.Name = "Квадрат";
            var1.sirina = 20;
            var1.dlina = 20;
            Dannie var2 = new Dannie();
            var2.Name = "Ромб";
            var2.sirina = 15;
            var2.dlina = 15;
            Dannie var3 = new Dannie();
            var3.Name = "Круг";
            var3.sirina = 18;
            var3.dlina = 18;

            List<Dannie> zapiski = new List<Dannie>();
            zapiski.Add(var1);
            zapiski.Add(var2);
            zapiski.Add(var3);
            Console.WriteLine("Введите адрес вашего файла:");
            string s = Console.ReadLine();

            string text = "\n" + var1.Name + " \n " + var1.sirina + " \n " + var1.dlina + " \n " + var2.Name + " \n " + var2.sirina + " \n " + var2.dlina + "\n" + var3.Name + " \n " + var3.sirina + " \n " + var3.dlina + "\n";
            int q = 0;
            while (q == 0)
            {
                if (s[s.Length - 1] == 't')
                {
                    if (File.Exists(s))
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Enter - сохранение. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else if (clavisha.Key == ConsoleKey.Enter)
                        {
                            File.AppendAllText(s, text);
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                }
                else if (s[s.Length - 1] == 'n')
                {
                    if (File.Exists(s))
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Enter - сохранение. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else if (clavisha.Key == ConsoleKey.Enter)
                        {
                            string json = JsonConvert.SerializeObject(zapiski);
                            File.WriteAllText(s, json);
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                }
                else if (s[s.Length - 1] == 'l')
                {
                    if (File.Exists(s))
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Нажмите Escape - для выхода. Enter - сохранение. Любую клавишу для сброса");
                        foreach (Dannie pos in zapiski)
                        {
                            Console.WriteLine(pos.Name);
                            Console.WriteLine(pos.sirina);
                            Console.WriteLine(pos.dlina);
                        }
                        ConsoleKeyInfo clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            q++;
                        }
                        else if (clavisha.Key == ConsoleKey.Enter)
                        {
                            XmlSerializer xml = new XmlSerializer(typeof(Dannie));
                            using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                            {
                                xml.Serialize(fs, zapiski);
                            }
                            q++;
                        }
                        else
                        {
                            Console.Clear();
                            Cod();
                        }
                    }
                }
            }
        }
    }
}
