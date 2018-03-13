namespace AkkaTestProject
{
    public class FakeRequest
    {
        public FakeRequest(ulong requestId) { RequestId = requestId; }
        public override string ToString() => $"FakeRequest: {RequestId}";
        public ulong RequestId { get; }
    }
}
