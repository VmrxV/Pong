using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pong.Models;

namespace Pong
{
    /// <summary>
    /// Представление игры
    /// </summary>
    public partial class PongControl : UserControl
    {
        public PongControl()
        {
            InitializeComponent();                                                          
        }

        private readonly Timer _timer = new Timer();
        private DateTime _beginTime;
        private TimeSpan _elapsedTime;            
        private TimeSpan _totalTime;

        private PongGame _game;

        private readonly List<Keys> _pressedKeys = new List<Keys>();        

        protected override void OnLoad(EventArgs e)
        {
            DoubleBuffered = true;

            base.OnLoad(e);

            _game = new PongGame();

            // настройка игрового таймера
            _timer.Interval = 1; // По факту будет около 15 мс
            _timer.Tick += (s, a) =>
            {
                var prevTotalTime = _totalTime;
                // общее время игры
                _totalTime = DateTime.Now - _beginTime;
                // время прошедшее с последнего кадра
                _elapsedTime = _totalTime - prevTotalTime;

                // вызов OnPaint (новый кадр)
                Invalidate();
            };
            _beginTime = DateTime.Now;

            // поехали!
            _timer.Start();            
        }       

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // первый кадр пропускается, иначе анимированные значения 
            // могут "испортится" (применяется анимация основанная на времени,
            // при делении на 0 возникают бесконечные значения)
            if (_elapsedTime <= TimeSpan.Zero) return;

            // обновление игрового состояния
            _game.Update(_totalTime, _elapsedTime, new InputState
            {
                PressedKeys = _pressedKeys.ToArray()
            });

            // отрисовка игрового состояния
            _game.Draw(_totalTime, _elapsedTime, e.Graphics);
        }
        
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            if (!_pressedKeys.Contains(e.KeyCode))
                _pressedKeys.Add(e.KeyCode);                     
            base.OnPreviewKeyDown(e);
        }
        
        protected override void OnKeyUp(KeyEventArgs e)
        {
            _pressedKeys.Remove(e.KeyCode);            
            base.OnKeyUp(e);
        }

		private void PongControl_Load(object sender, EventArgs e)
		{

		}
	}
}
