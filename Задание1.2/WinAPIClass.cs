using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace AnimateWindow

{
    public class WinAPICClass
    {
        #region Анимация окна
        /// <summary>
        /// Тип анимации окна. Перечисление возвращает тип int
        /// после приведения.Каждому элементу присвоено
        /// свое значение типа int.
        /// </summary>>
        [Flags]
        public enum AnimateWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65636,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288,
        };
        ///<summery>
        ///Анимация окна.
        ///</summery>>
        ///param name= "hwnd">Окно.</param>
        ///param name="dwTime">Время.</param>
        ///param name= "dwFlags">Тип анимации.Если в 
        ///неуправляемом коде используется перечисление ,то его
        ///нужно конвертировать в тип данных int
        ///<returns></returns>
        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        ///<summary>
        ///Анимация окна
        ///</summary>
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion

    }
}
