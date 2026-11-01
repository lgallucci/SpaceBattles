
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceBattlesGame.GameEngines;
using SpaceBattlesGraphics;

namespace SpaceBattlesGame
{
    public class SpaceBattles : Game
    {
        int _screenWidth = 1200;
        int _screenHeight = 800;
        
        int framesPerSecond = 0;
        int frameCount = 0;
        TimeSpan frameTimer = new TimeSpan(0);
        
        private GraphicsEngine _graphicsEngine;
        private GameEngine _gameEngine;
        private GameState _gameState;

        public SpaceBattles()
        {            
            _graphicsEngine = new GraphicsEngine(this);

            Content.RootDirectory = "Content";

            //this.IsFixedTimeStep = false;
            //this.TargetElapsedTime = TimeSpan.FromSeconds(1d / 120d); //60);
            this.IsMouseVisible = true;
            Window.AllowUserResizing = true;
            Window.ClientSizeChanged += Window_ClientSizeChanged;
        }
                
        protected override void Initialize()
        {
            base.Initialize();
        }

        private void Window_ClientSizeChanged(object sender, EventArgs e)
        {
            _screenWidth = Window.ClientBounds.Width;
            _screenHeight = Window.ClientBounds.Height;

            SetWindowSize();
        }

        private void SetWindowSize()
        {
            _graphicsEngine.SetScreenSize(_screenWidth, _screenHeight);
        }        
        
        protected override void LoadContent()
        {
            _gameEngine = new OpeningScreenEngine();
            SetWindowSize();
            _graphicsEngine.Load(GraphicsDevice, Content);
        }

        protected override void OnExiting(object sender, EventArgs args)
        {
            base.OnExiting(sender, args);
        }

        protected override void UnloadContent()
        {
            _graphicsEngine.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            if (IsActive)
                _gameEngine.Update(gameTime, ref _gameState);
            else
                _gameEngine.UpdateInactive(gameTime, ref _gameState);

            base.Update(gameTime);
        }
                
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(53, 101, 77));
            _graphicsEngine.BeginSprites();

            _graphicsEngine.BloomEnabled = true;
            _gameEngine.Draw(_graphicsEngine);

            //_graphicsEngine.DrawFps(framesPerSecond);

            _graphicsEngine.EndSprites();

            CalculateFps(gameTime);

            base.Draw(gameTime);
        }

        private void CalculateFps(GameTime gameTime)
        {
            frameTimer += gameTime.ElapsedGameTime;
            frameCount++;
            if (frameTimer > TimeSpan.FromSeconds(1))
            {
                framesPerSecond = frameCount;
                frameCount = 0;
                frameTimer = new TimeSpan(0);
            }
        }
    }
}