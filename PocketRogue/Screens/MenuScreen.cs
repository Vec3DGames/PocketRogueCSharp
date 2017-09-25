using MonoGame.Extended.Gui;
using MonoGame.Extended.Gui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRogue.Screens
{
    class MenuScreen : GuiScreen
    {

        private PocketRogue game;

        public MenuScreen(PocketRogue game, GuiSkin skin) : base(skin)
        {
            this.game = game;
        }

        public override void Initialize()
        {
            GuiDialog dialog = Skin.Create<GuiDialog>("dialog");
            dialog.Padding = new MonoGame.Extended.Thickness(30, 20);
            GuiUniformGrid grid = new GuiUniformGrid { Columns = 1 };

            GuiButton playButton = Skin.Create<GuiButton>("white-button", c =>
            {
                c.Text = "Play";
                c.Name = "play_button";
                c.Width = 200;
                c.Margin = new MonoGame.Extended.Thickness(5);
                c.Clicked += GuiButtonClicked;
            });

            GuiButton optionsButton = Skin.Create<GuiButton>("white-button", c =>
            {
                c.Text = "Options";
                c.Name = "options_button";
                c.Width = 200;
                c.Margin = new MonoGame.Extended.Thickness(5);
                c.Clicked += GuiButtonClicked;
            });

            GuiButton quitButton = Skin.Create<GuiButton>("white-button", c =>
            {
                c.Text = "Quit";
                c.Name = "quit_button";
                c.Width = 200;
                c.Margin = new MonoGame.Extended.Thickness(5);
                c.Clicked += GuiButtonClicked;
            });

            grid.Controls.Add(playButton);
            grid.Controls.Add(optionsButton);
            grid.Controls.Add(quitButton);
            dialog.Controls.Add(grid);

            Controls.Add(dialog);
        }

        public void GuiButtonClicked(object sender, EventArgs e)
        {
            GuiButton button = (GuiButton)sender;
            switch (button.Name)
            {
                case "play_button":
                    break;
                case "options_button":
                    break;
                case "quit_button":
                    game.Exit();
                    break;
            }
        }

    }
}
