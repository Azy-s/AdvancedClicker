using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AdvancedClicker
{
    internal class HotKeyManager
    {
        // Константы, используемые для регистрации горячих клавиш
        public const int MOD_ALT = 0x1;
        public const int MOD_CONTROL = 0x2;
        public const int MOD_SHIFT = 0x4;
        public const int MOD_WIN = 0x8;

        public const int WM_HOTKEY = 0x0312;

        // Импорт функций из user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        
    }
}
