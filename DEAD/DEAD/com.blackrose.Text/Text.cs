// Jonathan Coty
// 13-Sep-2013
// Black Rose Funeral Home

// Text class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace DEAD.com.blackrose.Text
{
    class Text
    {
        #region Constructor

        public Text()
        {

        }

        #endregion

        #region Draw

        public void Draw(SpriteBatch spriteBatch, string str, int xPos, int yPos, Color color, int space)
        {
            /*for (idx = str.Length; idx > 0; idx--)
            {
                tmpX = xPos - ((str.Length - idx) * space);

                spriteBatch.DrawString(globals.Font, str[idx - 1].ToString(), new Vector2(tmpX, yPos), color);
            }*/
        }

        #endregion
    }
}
