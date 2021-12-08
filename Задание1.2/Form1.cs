using AnimateWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            // Скрываем окно
            this.Hide();
            // Запускаем анимацию.
            //Второй параметр в скобках время анимации в
            //миллисекундах

            WinAPICClass.AnimateWindow(this, 3000, WinAPICClass.AnimateWindowFlags.AW_ACTIVATE | WinAPICClass.AnimateWindowFlags.AW_BLEND);
            // Отображаем кнопки после анимации
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPICClass.AnimateWindow(this, 3000, WinAPICClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPICClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
    }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPICClass.AnimateWindow(this, 3000, WinAPICClass.AnimateWindowFlags.AW_CENTER | WinAPICClass.AnimateWindowFlags.AW_SLIDE);
            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCenter_AW_SLIDE.Invalidate();
        }
    }
}
