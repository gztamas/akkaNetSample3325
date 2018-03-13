namespace AkkaTestProject
{
    public class FakeResponse
    {
        public FakeResponse(ulong requestId) { RequestId = requestId; }
        public override string ToString() => $"FakeResponse: {RequestId}";
        public ulong RequestId { get; private set; }
    }
}
