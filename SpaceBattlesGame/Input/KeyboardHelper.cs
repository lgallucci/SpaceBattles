using Microsoft.Xna.Framework.Input;

namespace SpaceBattlesGame.Input
{
    public class KeyboardHelper
    {
        private static KeyboardState _currentKeyState;
        private static KeyboardState _previousKeyState;

        public static bool IsKeyPressed(Keys key, bool oneShot)
        {
            if (!oneShot) return _currentKeyState.IsKeyDown(key);
            return _currentKeyState.IsKeyDown(key) && !_previousKeyState.IsKeyDown(key);
        }

        internal static void Update()
        {
            _previousKeyState = _currentKeyState;
            _currentKeyState = Keyboard.GetState();
        }
    }
}