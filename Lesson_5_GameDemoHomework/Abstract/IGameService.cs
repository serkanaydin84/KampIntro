using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5_GameDemoHomework.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Sale(Game game);
        void Delete(Game game);
    }
}
