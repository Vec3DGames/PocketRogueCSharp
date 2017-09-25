using Microsoft.Xna.Framework;
using MonoGame.Extended.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketRogue.States
{
    abstract class PocketRogueState
    {
        public GuiSystem guiSystem;

        public virtual void Update(GameTime gameTime)
        {
            guiSystem.Update(gameTime);
        }

        public virtual void Draw(GameTime gameTime)
        {
            guiSystem.Draw(gameTime);
        }
    }
}
