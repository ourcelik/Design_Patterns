using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TemplatePattern.Template
{
    class Custom : MyCursors
    {
        string Name;
        protected override void ChangeCursor(Border DisplayArea)
        {
            DisplayArea.Cursor= new Cursor(Directory.GetCurrentDirectory() +
                                       @"\" +
                                       "CustomCursor.cur");
            Name = DisplayArea.Cursor.GetType().Name;
        }

        protected override void WriteScreen()
        {
            MessageBox.Show($"Güncel Cursor'ınız Default {Name} olarak düzenlendi");
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
                    return false;
                case MessageBoxResult.No:
                    return true;
                case MessageBoxResult.Cancel:
                    return true;

            }
            return true;
        }

    }
}
