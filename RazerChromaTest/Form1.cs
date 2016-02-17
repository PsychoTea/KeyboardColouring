using System.Data;
using System.Linq;
using System.Windows.Forms;
using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;

namespace RazerChromaTest
{
    public partial class Form1 : Form
    {
        public class KeyValue
        {
            public Key keyRz { get; set; }
            public Keys keySys { get; set; }
            public Color color { get; set; }
        }

        Color currentColour = new Color();

        private static KeyValue[] GetKeyList()
        {
            return new KeyValue[]
                {
                    new KeyValue { keyRz = Key.Num7, keySys = Keys.NumPad7, color = Color.Red },
                    new KeyValue { keyRz = Key.Num8, keySys = Keys.NumPad8, color = Color.Blue },
                    new KeyValue { keyRz = Key.Num9, keySys = Keys.NumPad9, color = Color.Green },
                    new KeyValue { keyRz = Key.Num4, keySys = Keys.NumPad4, color = Color.Orange },
                    new KeyValue { keyRz = Key.Num5, keySys = Keys.NumPad5, color = Color.Yellow },
                    new KeyValue { keyRz = Key.Num6, keySys = Keys.NumPad6, color = Color.Pink },
                    new KeyValue { keyRz = Key.Num1, keySys = Keys.NumPad1, color = Color.HotPink },
                    new KeyValue { keyRz = Key.Num2, keySys = Keys.NumPad2, color = Color.Purple },
                    new KeyValue { keyRz = Key.Num3, keySys = Keys.NumPad3, color = Color.White },
                    new KeyValue { keyRz = Key.Num0, keySys = Keys.NumPad0, color = Color.Black },
                };
        }

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            Default();
        }

        private void Default()
        {
            keyboard.SetAll(Color.Black);
            foreach (KeyValue value in GetKeyList())
            {
                keyboard.SetKey(value.keyRz, value.color);
            }
            SetColour(currentColour);
        }

        private IKeyboard keyboard = Keyboard.Instance;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (new Keys[] { Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.NumPad0 }.Contains(e.KeyCode))
            {
                SetColour(
                    (from key in GetKeyList()
                     where key.keySys == e.KeyCode
                     select key.color).First());
            }

            if (!(new Keys[] { Keys.NumLock, Keys.Divide, Keys.Multiply, Keys.Subtract, Keys.Add, Keys.Decimal }.Contains(e.KeyCode)))
            {
                if (e.KeyCode == Keys.OemQuestion) keyboard.SetPosition(4, 12, currentColour);
                if (e.KeyCode == Keys.Oem7) keyboard.SetPosition(3, 13, currentColour);

                    if (FullKeyMap.Contains(e.KeyCode)) keyboard.SetKey(FullKeyMap.Get(e.KeyCode), currentColour);
            };

            if (e.KeyCode == Keys.Enter) Default();
        }

        void SetColour(Color colour)
        {
            currentColour = colour;

            keyboard.SetKeys(currentColour, Key.NumLock, Key.NumDivide, Key.NumMultiply, Key.NumSubtract, Key.NumAdd, Key.NumDecimal);
        }
    }
}
