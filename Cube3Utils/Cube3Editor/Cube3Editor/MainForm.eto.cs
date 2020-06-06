using System;
using Eto.Forms;
using Eto.Drawing;

namespace Cube3Editor
{

    public class MyCommand : Command
    {
        public MyCommand()
        {
            MenuText = "C&lick Me, command";
            ToolBarText = "Click Me";
            ToolTip = "This shows a dialog for n reason";
            Shortcut = Application.Instance.CommonModifier | Keys.M;  // control+M or cmd+M
        }

        protected override void OnExecuted(EventArgs e)
        {
            base.OnExecuted(e);

            MessageBox.Show(Application.Instance.MainForm, "You clicked me!", "Tutorial2", MessageBoxButtons.OK);
        }
    }
    partial class MainForm : Form
    {
        void InitializeComponent()
        {
            Title = "Menus and Toolbars";
            ClientSize = new Size(800, 600);
            Padding = 10;

            Menu = new MenuBar
            {
                Items =
                {
                    new ButtonMenuItem
                    {
                        Text = "&File",
                        Items =
                        {
                            new MyCommand(),
                            new ButtonMenuItem { Text = "Click Me, MenuItem"}
                        }
                    }
                },
                QuitItem = new Command((sender, e) => Application.Instance.Quit())
                {
                    MenuText = "Quit",
                    Shortcut = Application.Instance.CommonModifier | Keys.Q
                },
                AboutItem = new Command((sender, e) => new Dialog { Content = new Label { Text = "About my app..." }, ClientSize = new Size(200, 200) }.ShowModal(this))
                {
                    MenuText = "About My App"
                }
            };

            ToolBar = new ToolBar
            {
                Items =
                {
                    new MyCommand(),
                    new SeparatorToolItem(),
                    new ButtonToolItem { Text = "Click me, ToolItem" }
                }
            };

        }
    }
}
