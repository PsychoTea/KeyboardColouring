using ChromaKey = Corale.Colore.Razer.Keyboard.Key;
using System.Windows.Forms;
using System.Collections;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;

namespace RazerChromaTest
{
    public static class FullKeyMap
    {
        private static readonly Hashtable Mapping = new Hashtable()
        {
            { Keys.A, ChromaKey.A },
            { Keys.Add, ChromaKey.NumAdd },
            { Keys.B, ChromaKey.B },
            { Keys.Back, ChromaKey.Backspace },
            { Keys.C, ChromaKey.C },
            { Keys.CapsLock, ChromaKey.CapsLock },
            { Keys.D, ChromaKey.D },
            { Keys.D0, ChromaKey.D0 },
            { Keys.D1, ChromaKey.D1 },
            { Keys.D2, ChromaKey.D2 },
            { Keys.D3, ChromaKey.D3 },
            { Keys.D4, ChromaKey.D4 },
            { Keys.D5, ChromaKey.D5 },
            { Keys.D6, ChromaKey.D6 },
            { Keys.D7, ChromaKey.D7 },
            { Keys.D8, ChromaKey.D8 },
            { Keys.D9, ChromaKey.D9 },
            { Keys.Decimal, ChromaKey.NumDecimal },
            { Keys.Delete, ChromaKey.Delete },
            { Keys.Divide, ChromaKey.NumDivide },
            { Keys.Down, ChromaKey.Down },
            { Keys.E, ChromaKey.E },
            { Keys.End, ChromaKey.End },
            { Keys.Enter, ChromaKey.Enter },
            { Keys.Escape, ChromaKey.Escape },
            { Keys.F, ChromaKey.F },
            { Keys.F1, ChromaKey.F1 },
            { Keys.F10, ChromaKey.F10 },
            { Keys.F11, ChromaKey.F11 },
            { Keys.F12, ChromaKey.F12 },
            { Keys.F2, ChromaKey.F2 },
            { Keys.F3, ChromaKey.F3 },
            { Keys.F4, ChromaKey.F4 },
            { Keys.F5, ChromaKey.F5 },
            { Keys.F6, ChromaKey.F6 },
            { Keys.F7, ChromaKey.F7 },
            { Keys.F8, ChromaKey.F8 },
            { Keys.F9, ChromaKey.F9 },
            { Keys.G, ChromaKey.G },
            { Keys.H, ChromaKey.H },
            { Keys.Home, ChromaKey.Home },
            { Keys.I, ChromaKey.I },
            { Keys.Insert, ChromaKey.Insert },
            { Keys.J, ChromaKey.J },
            { Keys.K, ChromaKey.K },
            { Keys.L, ChromaKey.L },
            { Keys.Left, ChromaKey.Left },
            { Keys.Alt, ChromaKey.LeftAlt },
            { Keys.LControlKey, ChromaKey.LeftControl },
            { Keys.LShiftKey, ChromaKey.LeftShift },
            { Keys.LWin, ChromaKey.LeftWindows },
            { Keys.M, ChromaKey.M },
            { Keys.Multiply, ChromaKey.NumMultiply },
            { Keys.N, ChromaKey.N },
            { Keys.None, ChromaKey.Invalid },
            { Keys.NumLock, ChromaKey.NumLock },
            { Keys.NumPad0, ChromaKey.Num0 },
            { Keys.NumPad1, ChromaKey.Num1 },
            { Keys.NumPad2, ChromaKey.Num2 },
            { Keys.NumPad3, ChromaKey.Num3 },
            { Keys.NumPad4, ChromaKey.Num4 },
            { Keys.NumPad5, ChromaKey.Num5 },
            { Keys.NumPad6, ChromaKey.Num6 },
            { Keys.NumPad7, ChromaKey.Num7 },
            { Keys.NumPad8, ChromaKey.Num8 },
            { Keys.NumPad9, ChromaKey.Num9 },
            { Keys.O, ChromaKey.O },
            { Keys.OemBackslash, ChromaKey.OemBackslash },
            { Keys.OemCloseBrackets, ChromaKey.OemRightBracket },
            { Keys.Oemcomma, ChromaKey.OemComma },
            { Keys.OemMinus, ChromaKey.OemMinus },
            { Keys.OemOpenBrackets, ChromaKey.OemLeftBracket },
            { Keys.OemPeriod, ChromaKey.OemPeriod },
            { Keys.OemSemicolon, ChromaKey.OemSemicolon },
            { Keys.P, ChromaKey.P },
            { Keys.PageDown, ChromaKey.PageDown },
            { Keys.PageUp, ChromaKey.PageUp },
            { Keys.Pause, ChromaKey.Pause },
            { Keys.Print, ChromaKey.PrintScreen },
            { Keys.PrintScreen, ChromaKey.PrintScreen },
            { Keys.Q, ChromaKey.Q },
            { Keys.R, ChromaKey.R },
            { Keys.Right, ChromaKey.Right },
            { Keys.RControlKey, ChromaKey.RightControl },
            { Keys.RShiftKey, ChromaKey.RightShift },
            { Keys.S, ChromaKey.S },
            { Keys.Scroll, ChromaKey.Scroll },
            { Keys.Space, ChromaKey.Space },
            { Keys.Subtract, ChromaKey.NumSubtract },
            { Keys.T, ChromaKey.T },
            { Keys.Tab, ChromaKey.Tab },
            { Keys.U, ChromaKey.U },
            { Keys.Up, ChromaKey.Up },
            { Keys.V, ChromaKey.V },
            { Keys.W, ChromaKey.W },
            { Keys.X, ChromaKey.X },
            { Keys.Y, ChromaKey.Y },
            { Keys.Z, ChromaKey.Z },
            
            { Keys.Menu, ChromaKey.RightAlt },
            { Keys.Oem5, ChromaKey.EurBackslash },
            { Keys.Apps, ChromaKey.RightMenu },
            { Keys.Oemplus, ChromaKey.OemEquals },

            { Keys.Oemtilde, ChromaKey.OemApostrophe },
            { Keys.Oem8, ChromaKey.OemTilde },
            { Keys.OemQuestion, ChromaKey.OemSlash },
        };

        public static bool Contains(Keys key)
        {
            return Mapping.ContainsKey(key);
        }

        public static ChromaKey Get(Keys keys)
        {
            return (ChromaKey)Mapping[keys];
        }
    }
}
