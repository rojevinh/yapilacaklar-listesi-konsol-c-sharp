using System;
using System.Collections.Generic;

class TodoList
{
    private List<string> gorevler = new List<string>(); // Yapılacak görevleri saklamak için bir liste

    public void GorevListele()
    {
        if (gorevler.Count == 0)
        {
            Console.WriteLine("Yapılacak görev bulunamadı.");
        }
        else
        {
            Console.WriteLine("\nYapılacak Görevler:");
            for (int i = 0; i < gorevler.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, gorevler[i]);
            }
        }
    }

    public void GorevEkle()
    {
        Console.Write("Eklemek istediğiniz görevi giriniz: ");
        string yeniGorev = Console.ReadLine();
        gorevler.Add(yeniGorev);
        Console.WriteLine("{0} başarıyla eklendi!", yeniGorev);
    }

    public void GorevSil()
    {
        if (gorevler.Count == 0)
        {
            Console.WriteLine("Silinecek görev bulunamadı.");
            return;
        }

        GorevListele(); // Silinecek görevi seçmeden önce listeyi gösterir

        Console.Write("Silmek istediğiniz görevin numarasını giriniz: ");
        int secilenGoravNo = int.Parse(Console.ReadLine());

        if (secilenGoravNo > 0 && secilenGoravNo <= gorevler.Count)
        {
            string silinenGorev = gorevler[secilenGoravNo - 1];
            gorevler.RemoveAt(secilenGoravNo - 1);
            Console.WriteLine("{0} başarıyla silindi!", silinenGorev);
        }
        else
        {
            Console.WriteLine("Geçersiz görev numarası!");
        }
    }

    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();

        while (true)
        {
            Console.WriteLine("\nSeçiminiz:");
            Console.WriteLine("1. Görev Listele");
            Console.WriteLine("2. Görev Ekle");
            Console.WriteLine("3. Görev Sil");
            Console.WriteLine("4. Çıkış");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    todoList.GorevListele();
                    break;
                case 2:
                    todoList.GorevEkle();
                    break;
                case 3:
                    todoList.GorevSil();
                    break;
                case 4:
                    Environment.Exit(0); // Uygulamadan çıkış
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}

