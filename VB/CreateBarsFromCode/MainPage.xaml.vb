Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Bars

Namespace CreateBarsFromCode
    Partial Public Class MainPage
        Inherits UserControl

        Public Sub New()
            ThemeManager.ApplicationThemeName = "Office2007Black"
            InitializeComponent()

            'Create a main menu and add this to the BarManager.Bars collection
            Dim mainMenu As New Bar()
            mainMenu.Name = "mainMenu"
            mainMenu.Caption = "Main Menu"
            mainMenu.IsMainMenu = True
            mainMenu.DockInfo = New BarDockInfo()
            mainMenu.DockInfo.ContainerType = BarContainerType.Top
            manager.Bars.Add(mainMenu)

            'Create a bar and add this to the BarManager.Bars collection
            Dim bar As New Bar()
            bar.Name = "bar"
            bar.Caption = "Bar"
            bar.DockInfo = New BarDockInfo()
            bar.DockInfo.ContainerType = BarContainerType.Top
            manager.Bars.Add(bar)

            'Create a few bar buttons and add this to the BarManager.Items collection
            Dim barButtonItem1 As New BarButtonItem()
            barButtonItem1.Name = "bt1"
            barButtonItem1.Content = "Button1"
            barButtonItem1.Hint = "This is Bar Button Item 1"
            manager.Items.Add(barButtonItem1)
            Dim barButtonItem2 As New BarButtonItem()
            barButtonItem2.Name = "bt2"
            barButtonItem2.Content = "Button2"
            barButtonItem2.Hint = "This is Bar Button Item 2"
            manager.Items.Add(barButtonItem2)
            Dim barSubItem1 As New BarSubItem()
            barSubItem1.Name = "sb1"
            barSubItem1.Content = "Menu1"
            barSubItem1.Hint = "This is Bar Sub Item 1"
            manager.Items.Add(barSubItem1)

            'Create links for bar buttons and add this to the BarSubItem.ItemLinks collection
            Dim barButtonItem1LinkForBarSubItem As New BarButtonItemLink()
            barButtonItem1LinkForBarSubItem = CType(barButtonItem1.CreateLink(), BarButtonItemLink)
            barSubItem1.ItemLinks.Add(barButtonItem1LinkForBarSubItem)
            Dim barButtonItem2LinkForBarSubItem As New BarButtonItemLink()
            barButtonItem2LinkForBarSubItem = CType(barButtonItem2.CreateLink(), BarButtonItemLink)
            barSubItem1.ItemLinks.Add(barButtonItem2LinkForBarSubItem)

            'Create links for bar buttons and add this to the Bar.ItemLinks collection
            Dim barButtonItem1LinkForBar As New BarButtonItemLink()
            barButtonItem1LinkForBar = CType(barButtonItem1.CreateLink(), BarButtonItemLink)
            bar.ItemLinks.Add(barButtonItem1LinkForBar)
            Dim barButtonItem2LinkForBar As New BarButtonItemLink()
            barButtonItem2LinkForBar = CType(barButtonItem2.CreateLink(), BarButtonItemLink)
            bar.ItemLinks.Add(barButtonItem2LinkForBar)

            'Create links for bar sub item and add this to the main menu
            Dim barSubItemLink As New BarSubItemLink()
            barSubItemLink = CType(barSubItem1.CreateLink(), BarSubItemLink)
            mainMenu.ItemLinks.Add(barSubItemLink)
        End Sub
    End Class
End Namespace
