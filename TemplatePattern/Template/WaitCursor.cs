using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TemplatePattern.Template
{
    class WaitCursor : MyCursors
    {
        protected override void ChangeCursor(Border DisplayArea)
        {
            DisplayArea.Cursor = Cursors.Wait;
        }

        protected override void WriteScreen()
        {
            MessageBox.Show($"Güncel Cursor'ınız {this.GetType().Name} olarak düzenlendi");
        }
        public override void ChangeScope(Border DisplayArea)
        {
            Mouse.OverrideCursor = DisplayArea.Cursor;
        }

        protected override bool PreferOfScope()
        {
            string sMessageBoxText = "Do you want to make Scope Universel";
            string sCaption = "My Test Application";

            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    return true;
                case MessageBoxResult.No:
                    return false;
                case MessageBoxResult.Cancel:
                    return false;

            }
            return false;
        }

    }
}
