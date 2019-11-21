using System;
using Akka.Actor;

namespace WinTail
{
    #region Program
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args)
        {
            // initialize MyActorSystem
            // YOU NEED TO FILL IN HERE
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            //PrintInstructions();

            // time to make your first actors!
            var writerActor = MyActorSystem.ActorOf(Props.Create(() => new ConsoleWriterActor()));
            var validateActor = MyActorSystem.ActorOf(Props.Create(() => new ValidationActor(writerActor)));
            var readerActor = MyActorSystem.ActorOf(Props.Create(() => new ConsoleReaderActor(writerActor)));

            // tell console reader to begin
            //YOU NEED TO FILL IN HERE
            readerActor.Tell(ConsoleReaderActor.StartCommand);
            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.WhenTerminated.Wait();
        }
    }
    #endregion
}
