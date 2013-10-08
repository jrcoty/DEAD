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

using DEAD.com.blackrose.Main;

namespace DEAD.com.blackrose.Stages
{
    public class Stage
    {
        private string[,] tiles; 

        private Vector2 vector;
        private Rectangle rect;
        private Color color = Color.White;

        #region Contructor

        public Stage() {

        }

        public void loadStage(string file)
        {
            string line; 

            string[] split;

            tiles = new string[Globals.Layout.Rows, Globals.Layout.Columns];

            using (StreamReader reader = new StreamReader(Globals.Layout.FolderLocation + file + ".txt"))
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

        public void Draw(SpriteBatch spriteBatch, Texture2D tileset)
        {
            float tempX, tempY;

            for (int n = 0; n < Globals.Layout.Rows; n++)
                for (int m = 0; m < Globals.Layout.Columns; m++)
                {
                    tempX = (float)m * Globals.Tiles.Size;

                    tempY = (float)(n * Globals.Tiles.Size + Globals.Screen.YOffset);

                    vector = new Vector2(tempX, tempY);

                    rect = getTile(tiles[n, m]);

                    spriteBatch.Draw(tileset, vector, rect, color);
                }
        }

        #endregion

        #region Tiles

        private Rectangle getTile(string tileVal)
        {
            int x_temp, y_temp;

            x_temp = int.Parse(tileVal[1].ToString()) * Globals.Tiles.Size + Globals.Tiles.Offset;

            y_temp = int.Parse(tileVal[0].ToString()) * Globals.Tiles.Size + Globals.Tiles.Offset;

            return new Rectangle(x_temp, y_temp, Globals.Tiles.Size, Globals.Tiles.Size);
        }

        #endregion
    }
}
