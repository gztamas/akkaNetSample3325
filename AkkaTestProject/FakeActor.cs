using Akka.Actor;
using Akka.Persistence;

namespace AkkaTestProject
{
    public class FakeActor : ReceivePersistentActor
    {
        public override string PersistenceId { get; } = "HashCoded";

        public FakeActor()
        {
            Command<FakeRequest>(request => Sender.Tell(new FakeResponse(requestId: request.RequestId)));
        }
    }
}
