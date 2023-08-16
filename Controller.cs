using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit12
{
    public static class Controller
    {
        public static void Greetings(User[] Users){
            for (int i = 0; i < Users.Length; i++){
                Console.WriteLine($"Hello {Users[i].Name}");
                if (!Users[i].IsPremium){
                    ShowAds();
                }
            }

        }

        public static void ShowAds()
        {
	        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
	        // Остановка на 1 с
	        Thread.Sleep(1000);

	        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
	        // Остановка на 2 с
	        Thread.Sleep(2000);

        	Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
	        // Остановка на 3 с
	        Thread.Sleep(3000);
        } 
    }
}