using Microsoft.Xna.Framework;
using SpaceBattlesGame.Input;
using SpaceBattlesGraphics;

namespace SpaceBattlesGame.GameEngines
{
    public class OpeningScreenEngine : GameEngine
    {
        public override void Update(GameTime gameTime, ref GameState _gameState)
        {
            KeyboardHelper.Update();
        }

        public override void SetScreenSize(int screenWidth, int screenHeight)
        {
        }

        public override void Draw(GraphicsEngine _graphicsEngine)
        {
        }
    }
}