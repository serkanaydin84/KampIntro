using Lesson_5_GameDemoHomework.Abstract;
using System;

namespace Lesson_5_GameDemoHomework
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " silindi");
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.GameName + " satıldı");
        }
    }
}
