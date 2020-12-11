using Helloworld;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Greeter
{
  [Keyless]
  [AdaptTo("[name]Dto")]
  public class Entity
  {
    public HelloRequest Request { get; set; }
    public HelloReply Reply { get; set; }
  }
}
