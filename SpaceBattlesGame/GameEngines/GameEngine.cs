using Microsoft.Xna.Framework;
using SpaceBattlesGraphics;

namespace SpaceBattlesGame.GameEngines
{
    public abstract class GameEngine
    {
        public abstract void Update(GameTime gameTime, ref GameState _gameState);

        // Called instead of Update while the window is unfocused (multiplayer only): no input handling.
        public virtual void UpdateInactive(GameTime gameTime, ref GameState _gameState) { }

        public abstract void SetScreenSize(int screenWidth, int screenHeight);

        public abstract void Draw(GraphicsEngine _graphicsEngine);
    }
}