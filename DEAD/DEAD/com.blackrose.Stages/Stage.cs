// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Stage class
// Draws the game based on the supplied layout
// and tile values

using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace DEAD.com.blackrose.Stages
{
    public class Stage
    {
        private string[,] tiles; 

        private Vector2 vector;
        private Rectangle rect;
        private Color color = Color.White;

        #region Contructor

        public Stage(string file) {
            loadStage(file); 
        }

        private void loadStage(string file)
        {
            string line; 

            string[] split;

            tiles = new string[globals.LayoutRow, globals.LayoutCol];

            using (StreamReader reader = new StreamReader(globals.LayoutFolder + file + ".txt"))
            {
                int row = 0; 

                while ((line = reader.ReadLine()) != null)
                {
                    split = line.Split(',');

                    for (int col = 0; col < split.Length; col++)
                        tiles[row, col] = split[col]; 

                    row++; 
                }

                reader.Close(); 
            }
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

                    rect = getTile(tiles[n, m]);

                    spriteBatch.Draw(globals.tileset, vector, rect, color);
                }
        }

        #endregion

        #region Tiles

        private Rectangle getTile(string tileVal)
        {
            int x_temp, y_temp;

            x_temp = int.Parse(tileVal[1].ToString()) * globals.spriteSize + globals.spriteOffset;

            y_temp = int.Parse(tileVal[0].ToString()) * globals.spriteSize + globals.spriteOffset; 

            return new Rectangle(x_temp, y_temp, globals.spriteSize, globals.spriteSize);
        }

        #endregion
    }
}
