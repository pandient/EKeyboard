using System;
using EyeTrackingKeyBoard;

namespace InteractiveKeyboard2010
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (InteractiveKeyboard game = new EyeTrackingKeyBoard.InteractiveKeyboard())
            {
                game.Run();
            }
        }
    }
#endif
}

