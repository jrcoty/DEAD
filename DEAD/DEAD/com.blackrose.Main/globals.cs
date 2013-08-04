// Jonathan Coty
// 3-aug-2013
// Black Rose Funeral Home

// Global variables for Among the Dead

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace DEAD
{
    static class globals
    {
        // Global Screen Variables
        private static int screenWidth = 864; //576;
        private static int screenHeight = 720; //480;
        private static float scaleX = 3f;
        private static float scaleY = 3f;
        private const float scaleZ = 1f;
        private const float yOffset = 48f;
        private const int sFact = 3; 
        private static Boolean screenReg = true;
        private static Boolean showDebug = false;

        // Global Sprite variables
        private const string asstTiles = "tile_set";
        private const string asstTitle = "title"; 
        private static Texture2D mTexture, title, background; 
        private const int sSize = 16;

        // Global State Variables
        private static Boolean keyDown = false;

        // Global Display Variables
        private static SpriteFont font;
        private static int colorVal;
        private static Color red = new Color(204, 0, 0);
        private static Color lRed = new Color(255, 0, 102);
        private static Color gold = new Color(238, 204, 0);
        private static Color oWhite = new Color(238, 238, 221);
        private static Color lBlue = new Color(136, 255, 255);
        private static Color green = new Color(34, 68, 17);

        // Global layout
        private static int layoutCol = 18;
        private static int layoutRow = 12;

        private static int[,] layout = new int[,] {{4, 9, 8, 9, 9, 8, 9, 8, 9, 9, 8, 9, 8, 9, 9, 8, 9, 5},
                                                   {11,2,12,13, 2,12,13, 2, 3, 3, 2,12,13, 2,12,13, 2,11},
                                                   {10,0,14,15, 1,14,15, 1, 0, 0, 1,14,15, 1,14,15, 0,10},
                                                   {11,0, 0, 0, 0, 0, 0, 0,16,17, 0, 0, 0, 0, 0, 0, 0,11},
                                                   {10,0, 2, 2, 2, 2, 2, 0,18,19, 0, 2, 2, 2, 2, 2, 0,10},
                                                   {11,0, 1, 1, 1, 1, 1, 0,21,23, 0, 1, 1, 1, 1, 1, 0,11},
                                                   {10,0, 2, 2, 2, 0, 2, 2, 0, 0, 2, 2, 0, 2, 2, 2, 0,10},
                                                   {11,0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0,11},
                                                   {10,0, 2, 0, 2, 2, 2, 0, 2, 2, 0, 2, 2, 2, 0, 2, 0,10},
                                                   {11,0, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0,11},
                                                   {6, 9, 8, 9, 9, 8, 9, 8, 0, 0, 8, 9, 8, 9, 9, 8, 9, 7},
                                                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

        // Alternate layout optimized for 288x224
        private static int[,] altLayout = new int[,] {{4, 9, 8, 9, 9, 8, 9, 8, 9, 9, 8, 9, 8, 9, 9, 8, 9, 5},
                                                   {11,12,13,2, 2, 3, 2, 2, 3, 3, 2, 2, 3, 2, 2,12,13,11},
                                                   {10,14,15,1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1,14,15,10},
                                                   {11,0, 0, 0, 2, 2, 2, 0,16,17, 0, 2, 2, 2, 0, 0, 0,11},
                                                   {10,0, 0, 0, 1, 1, 1, 0,18,19, 0, 1, 1, 1, 0, 0, 0,10},
                                                   {11,2, 0, 2, 2, 0, 2, 2,21,23, 2, 2, 0, 2, 2, 0, 2,11},
                                                   {10,1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1,10},
                                                   {11,2, 0, 2, 2, 2, 2, 0, 2, 2, 0, 2, 2, 2, 2, 0, 2,11},
                                                   {10,1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1,10},
                                                   {6, 9, 8, 9, 9, 8, 9, 8, 0, 0, 8, 9, 8, 9, 9, 8, 9, 7},
                                                   {11,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,11},
                                                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};

        #region Screen Variables

        // Screen Width Get/Set
        public static int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }

        // Screen Height Get/Set
        public static int ScreenHeight
        {
            get { return screenHeight; }
            set { screenHeight = value; }
        }

        // X Scale Get/Set
        public static float xScale
        {
            get { return scaleX; }
            set { scaleX = value; }
        }

        // Y Scale Get/Set
        public static float yScale
        {
            get { return scaleY; }
            set { scaleY = value; }
        }

        // Z Scale Get
        public static float zScale {
            get { return scaleZ; }
        }

        // Y Offset
        public static float YOffset {
            get { return yOffset; }
        }

        // Scaling Factor
        public static int sFactor {
            get { return sFact; }
        }

        // Screen Regular Get/Set
        public static Boolean ScreenRegular
        {
            get { return screenReg; }
            set { screenReg = value; }
        }

        // Show Debug Get/Set
        public static Boolean ShowDebug
        {
            get { return showDebug; }
            set { showDebug = value; }
        }

        #endregion

        #region Sprite Variables

        public static string Asset {
            get { return asstTiles; }
        }

        public static string AssetTitle
        {
            get { return asstTitle; }
        }

        public static Texture2D tileset
        {
            set { mTexture = value; }
            get { return mTexture; }
        }

        public static Texture2D Title
        {
            set { title = value; }
            get { return title; }
        }

        // Sprite Size Get
        public static int spriteSize {
            get { return sSize; }
        }

        #endregion

        #region State Variables

        // Is Key Down Get/Set
        public static Boolean isKeyDown
        {
            get { return keyDown; }
            set { keyDown = value; }
        }

        #endregion

        #region Display Variables

        // Font Get/Set
        public static SpriteFont Font
        {
            get { return font; }
            set { font = value; }
        }

        // Color Value Get/Set
        public static int Color_value
        {
            get { return colorVal; }
            set { colorVal = value; }
        }

        // Red Color Get
        public static Color Red  {
            get { return red; }
        }

        // Light Red Color Get
        public static Color LRed {
            get { return lRed; }
        }

        // Gold Color Get
        public static Color Gold {
            get { return gold; }
        }

        // Off White Color Get
        public static Color OWhite {
            get { return oWhite; }
        }

        // Light Blue Color Get
        public static Color LBlue  {
            get { return lBlue; }
        }

        // Green Color Get
        public static Color Green {
            get { return green; }
        }

        #endregion

        #region Layout

        public static int[,] Layout {
            get { return layout; }
        }

        public static int LayoutCol {
            get { return layoutCol; }
        }

        public static int LayoutRow {
            get { return layoutRow; }
        }

        #endregion
    }
}
