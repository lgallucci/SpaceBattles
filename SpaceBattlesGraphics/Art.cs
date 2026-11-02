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

    public static class Theme
    {
        //button colors
        public static Color ButtonHoverBorder { get; internal set; } = Color.DeepPink;
        public static Color ButtonBorder { get; internal set; } = Color.MintCream;
        public static Color ButtonText { get; internal set; } = Color.White;
        public static Color ButtonHoverBackground { get; internal set; } = new Color(60, 120, 90);
        public static Color ButtonBackground { get; internal set; } = new Color(26, 50, 38);
        internal static Color Panel { get; private set; } = Color.MintCream;


        internal static Color Background { get; private set; } = Color.Black;
        internal static Color Foreground { get; private set; } = Color.White;
    }
}