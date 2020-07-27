using System;

namespace opentoolkit_dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            using( MainWindow Game = new MainWindow())
            {
                //Game.Run(60.0, 60.0); //doesn't work in pre-release
                Game.Run();
            }
        }
    }
}
