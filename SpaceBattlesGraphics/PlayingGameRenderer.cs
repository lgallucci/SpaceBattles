using System;
using SpaceBattlesGraphics.GameAssetsDraw;

namespace SpaceBattlesGraphics
{
    public sealed class PlayingGameRenderer
    {
        private readonly SpaceshipGraphics _spaceshipGraphics = new SpaceshipGraphics();
        
        public void Draw(RenderContext context)
        {
            BindContext(context);
            
            _spaceshipGraphics.Draw();
        }

        public void Resize(int screenWidth, int screenHeight)
        {
            throw new NotImplementedException();
        }

        private void BindContext(RenderContext context)
        {
            _spaceshipGraphics.Bind(context);
        }
    }
}