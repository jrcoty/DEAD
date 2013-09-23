// Jonathan Coty
// 19-Sep-2013
// Black Rose Funeral Home

// Global variables and functions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEAD.com.blackrose.Main
{
    public static class Globals
    {
        public static class Screen
        {
            public const int Width = 864;
            public const int Height = 720;
            public const float XScale = 3f;
            public const float YScale = 3f;
            public const float ZScale = 1f;
            public const float YOffset = 48f;
            public const int SFactor = 3;
        }

        public static class Layout
        {
            public const string FolderLocation = "Content/Stages/";
            public const int Columns = 18;
            public const int Rows = 12; 
        }

        public static class Tiles
        {
            public const string Asset_Tiles = "tileset";
            public const string Asset_Title = "title";
            public const int Size = 16;
            public const int Offset = 1; 
        }

        public static class Font
        {
            public static string Name = "GnG";
            public static Color Red = new Color(204, 0, 0);
            public static Color LightRed = new Color(255, 0, 102);
            public static Color Gold = new Color(238, 238, 221);
            public static Color OffWhite = new Color(238, 238, 221);
            public static Color LightBlue = new Color(136, 255, 255);
            public static Color Green = new Color(34, 68, 17);
        }

        public static class Text
        {
            public static void Draw(SpriteBatch spriteBatch, SpriteFont font, string str, int xPos, int yPos, Color color, int space)
            {
                int idx, tmpX; 

                for (idx = str.Length; idx > 0; idx--)
                {
                    tmpX = xPos - ((str.Length - idx) * space);

                    spriteBatch.DrawString(font, str[idx - 1].ToString(), new Vector2(tmpX, yPos), color);
                }
            }
        }
    }
}
