// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// D.E.A.D
// Dubious Engine for Among the Dead

using System;

namespace DEAD.com.blackrose.Main
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}

