using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SpaceBattlesGraphics;

namespace SpaceBattlesGame.GameEngines
{
    public class PlayingGameEngine : GameEngine
    {
        private readonly PlayingGameRenderer _playingGameRenderer;
        private int _screenWidth = 0;
        private int _screenHeight = 0;

        public PlayingGameEngine(int screenWidth, int screenHeight)
        {
            _screenWidth = screenWidth;
            _screenHeight = screenHeight;
            SetScreenSize(screenWidth, screenHeight);

            _playingGameRenderer = new PlayingGameRenderer();
        }

        public override void Draw(GraphicsEngine _graphicsEngine)
        {
            _playingGameRenderer.Draw(_graphicsEngine.Context);
        }

        public override void SetScreenSize(int screenWidth, int screenHeight)
        {
            _screenWidth = screenWidth;
            _screenHeight = screenHeight;
            _playingGameRenderer.Resize(_screenWidth, _screenHeight);
        }

        public override void Update(GameTime gameTime, ref GameState _gameState)
        {
            throw new NotImplementedException();
        }
    }
}