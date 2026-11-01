using System.IO;
using FontStashSharp;
using FontStashSharp.Interfaces;

namespace SpaceBattlesGraphics
{
    internal class Art
    {
        //Dark Tiles
        internal static Texture2D SpaceShip { get; private set; }
        internal static Texture2D Pixel { get; private set; }

        //Fonts
        internal static DynamicSpriteFont NameFont { get; private set; }
        internal static DynamicSpriteFont ChatFont { get; private set; }

        internal static void Load(ContentManager content, GraphicsDevice graphicsDevice)
        {
            // Load font system
            var superSoftFont = FontSystemFactory.Create(graphicsDevice, 1024, 1024);
            superSoftFont.AddFont(File.ReadAllBytes("Content/fonts/supersoft.ttf"));

            var robotoFont = FontSystemFactory.Create(graphicsDevice, 1024, 1024);
            robotoFont.AddFont(File.ReadAllBytes("Content/fonts/roboto.ttf"));

            // Create a dynamic font size
            ChatFont = robotoFont.GetFont(16);
            NameFont = superSoftFont.GetFont(28);

            SpaceShip = Texture2D.FromFile(graphicsDevice, "Content/img/spaceship.png");

            Pixel = new Texture2D(graphicsDevice, 1, 1);
            Pixel.SetData(new[] { Color.White });
        }
    }
}