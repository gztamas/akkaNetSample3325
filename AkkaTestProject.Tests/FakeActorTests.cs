using Akka.Actor;
using Akka.TestKit.NUnit3;
using NUnit.Framework;

namespace AkkaTestProject.Tests
{
    [TestFixture]
    public class FakeActorTests : TestKit
    {
        [Test]
        public void FakeActor_FakeRequest()
        {
            // Arrange
            var senderProbe = CreateTestProbe();
            var sut = Sys.ActorOf(Props.Create<FakeActor>());

            // Act
            sut.Tell(new FakeRequest(1), senderProbe.Ref);

            // Assert
            senderProbe.ExpectMsg<FakeResponse>(r => r.RequestId == 1);
        }
    }
}
