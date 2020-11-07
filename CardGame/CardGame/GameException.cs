using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// We can add various implementation to hide the internal and return a top level exception.
    /// We can also add different adding platforms here(Kibana or sentry or lightstep etc).
    /// </summary>
    public class GameException
    {
        public static void Throw(Exception exception)
        {
            Console.WriteLine("An error occoured while trying to process the operation : " + exception.Message);
        }
    }
}
