using System;
using System.Collections.Generic;
using Pong.Models;

namespace Pong.Processors
{
    /// <summary>
    /// Базовый класс обработчика игровой логики
    /// </summary>
    public abstract class GameProcessor
    {
        /// <summary>
        /// Процедура обновления состояния игры
        /// </summary>
        /// <param name="totalTime">Время игры</param>
        /// <param name="elapsedTime">Время прошедшее с последнего кадра</param>
        /// <param name="inputState">Информация о вводе</param>
        /// <param name="components">Игровые компоненты, которые, возможно, будут обновлены</param>
        public abstract void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState, IList<GameComponent> components);
    }
}