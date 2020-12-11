using Helloworld;

namespace Greeter
{
    public partial class EntityDto
    {
        public HelloRequest Request { get; set; }
        public HelloReply Reply { get; set; }
    }
}