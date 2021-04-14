using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace TemplatePattern.Template
{
    abstract class MyCursors
    {
        private void CursorChanging()
        {
            MessageBox.Show("Cursor Değiştiriliyor...");
        }
        protected abstract void ChangeCursor(Border DisplayArea);

        public bool WorkSystem(Border DisplayArea)
        {
            CursorChanging();
            ChangeCursor(DisplayArea);
            WriteScreen();
            if (PreferOfScope())
            {
                ChangeScope(DisplayArea);
                return false;
            }
            return true;
        }

        protected abstract void WriteScreen();

        public abstract void ChangeScope(Border DisplayArea);
        

        protected virtual bool PreferOfScope()
        {
            return false;
        }


    }
}
