// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Stage class
// Draws the game based on the supplied layout
// and tile values

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace DEAD.com.blackrose.Stages
{
    public class Stage
    {
        private Vector2 vector;
        private Rectangle rect;
        private Color color = Color.White;

        #region Contructor

        public Stage() {

        }

        #endregion

        #region Draw

        public void Draw(SpriteBatch spriteBatch)
        {
            float tempX, tempY;

            for (int n = 0; n < globals.LayoutRow; n++)
                for (int m = 0; m < globals.LayoutCol; m++)
                {
                    tempX = (float)m * globals.spriteSize;

                    tempY = (float)(n * globals.spriteSize) + globals.YOffset;

                    vector = new Vector2(tempX, tempY);

                    rect = tileRect(globals.Layout[n, m]);

                    spriteBatch.Draw(globals.tileset, vector, rect, color);
                }
        }

        #endregion

        #region Tiles

        private Rectangle tileRect(int tileVal)
        {

            int x_temp, y_temp;
            Rectangle temp;

            switch (tileVal)
            {
                case 1:
                    x_temp = 1;
                    y_temp = 18;
                    break;

                case 2:
                    x_temp = 1;
                    y_temp = 1;
                    break;

                case 3:
                    x_temp = 1;
                    y_temp = 35;
                    break;

                case 4:
                    x_temp = 35;
                    y_temp = 1;
                    break;

                case 5:
                    x_temp = 69;
                    y_temp = 1;
                    break;

                case 6:
                    x_temp = 35;
                    y_temp = 18;
                    break;

                case 7:
                    x_temp = 52;
                    y_temp = 18;
                    break;

                case 8:
                    x_temp = 52;
                    y_temp = 1;
                    break;

                case 9:
                    x_temp = 35;
                    y_temp = 35;
                    break;

                case 10:
                    x_temp = 69;
                    y_temp = 18;
                    break;

                case 11:
                    x_temp = 52;
                    y_temp = 35;
                    break;

                case 12:
                    x_temp = 35;
                    y_temp = 52;
                    break;

                case 13:
                    x_temp = 52;
                    y_temp = 52;
                    break;

                case 14:
                    x_temp = 35;
                    y_temp = 69;
                    break;

                case 15:
                    x_temp = 52;
                    y_temp = 69;
                    break;

                case 16:
                    x_temp = 1;
                    y_temp = 52;
                    break;

                case 17:
                    x_temp = 18;
                    y_temp = 52;
                    break;

                case 18:
                    x_temp = 1;
                    y_temp = 69;
                    break;

                case 19:
                    x_temp = 18;
                    y_temp = 69;
                    break;

                case 20:
                    x_temp = 1;
                    y_temp = 86;
                    break;

                case 21:
                    x_temp = 35;
                    y_temp = 86;
                    break;

                case 22:
                    x_temp = 18;
                    y_temp = 86;
                    break;

                case 23:
                    x_temp = 52;
                    y_temp = 86;
                    break;

                default:
                    x_temp = 18;
                    y_temp = 35;
                    break;

            }

            temp = new Rectangle(x_temp, y_temp, globals.spriteSize, globals.spriteSize);

            return temp;
        }

        #endregion
    }
}
