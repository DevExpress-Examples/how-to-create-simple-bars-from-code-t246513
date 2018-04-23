using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Bars;

namespace CreateBarsFromCode {
    public partial class MainPage : UserControl {
        public MainPage() {
            ThemeManager.ApplicationThemeName = "Office2007Black";
            InitializeComponent();

            //Create a main menu and add this to the BarManager.Bars collection
            Bar mainMenu = new Bar();
            mainMenu.Name = "mainMenu";
            mainMenu.Caption = "Main Menu";
            mainMenu.IsMainMenu = true;
            mainMenu.DockInfo = new BarDockInfo();
            mainMenu.DockInfo.ContainerType = BarContainerType.Top;
            manager.Bars.Add(mainMenu);

            //Create a bar and add this to the BarManager.Bars collection
            Bar bar = new Bar();
            bar.Name = "bar";
            bar.Caption = "Bar";
            bar.DockInfo = new BarDockInfo();
            bar.DockInfo.ContainerType = BarContainerType.Top;
            manager.Bars.Add(bar);

            //Create a few bar buttons and add this to the BarManager.Items collection
            BarButtonItem barButtonItem1 = new BarButtonItem();
            barButtonItem1.Name = "bt1";
            barButtonItem1.Content = "Button1";
            barButtonItem1.Hint = "This is Bar Button Item 1";
            manager.Items.Add(barButtonItem1);
            BarButtonItem barButtonItem2 = new BarButtonItem();
            barButtonItem2.Name = "bt2";
            barButtonItem2.Content = "Button2";
            barButtonItem2.Hint = "This is Bar Button Item 2";
            manager.Items.Add(barButtonItem2);
            BarSubItem barSubItem1 = new BarSubItem();
            barSubItem1.Name = "sb1";
            barSubItem1.Content = "Menu1";
            barSubItem1.Hint = "This is Bar Sub Item 1";
            manager.Items.Add(barSubItem1);

            //Create links for bar buttons and add this to the BarSubItem.ItemLinks collection
            BarButtonItemLink barButtonItem1LinkForBarSubItem = new BarButtonItemLink();
            barButtonItem1LinkForBarSubItem = (BarButtonItemLink)barButtonItem1.CreateLink();
            barSubItem1.ItemLinks.Add(barButtonItem1LinkForBarSubItem);
            BarButtonItemLink barButtonItem2LinkForBarSubItem = new BarButtonItemLink();
            barButtonItem2LinkForBarSubItem = (BarButtonItemLink)barButtonItem2.CreateLink();
            barSubItem1.ItemLinks.Add(barButtonItem2LinkForBarSubItem);

            //Create links for bar buttons and add this to the Bar.ItemLinks collection
            BarButtonItemLink barButtonItem1LinkForBar = new BarButtonItemLink();
            barButtonItem1LinkForBar = (BarButtonItemLink)barButtonItem1.CreateLink();
            bar.ItemLinks.Add(barButtonItem1LinkForBar);
            BarButtonItemLink barButtonItem2LinkForBar = new BarButtonItemLink();
            barButtonItem2LinkForBar = (BarButtonItemLink)barButtonItem2.CreateLink();
            bar.ItemLinks.Add(barButtonItem2LinkForBar);

            //Create links for bar sub item and add this to the main menu
            BarSubItemLink barSubItemLink = new BarSubItemLink();
            barSubItemLink = (BarSubItemLink)barSubItem1.CreateLink();
            mainMenu.ItemLinks.Add(barSubItemLink);
        }
    }
}
