using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace pong.Sprites
{
    public class Ball : Sprite
    {
        private float _timer = 0f; // incrementing the speed over time
        private Vector2? _startPosition = null; // "?" means it's nullable
        private float? _startSpeed;
        private bool _isPlaying;

        public Score Score;
        public int SpeedIncrementSpan = 10; // how often the speed will increment

        public Ball(Texture2D texture) 
            : base(texture)
        {
            Speed = 3f;
        }

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            if(_startPosition == null)
            {
                _startPosition = Position;
                _startSpeed = Speed;
            }
        }
    }
}
