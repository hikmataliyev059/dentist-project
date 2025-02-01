using Dentist.Core.Common;

namespace Dentist.Core;

public class Agent : BasEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int PositionId {get; set;}
    public Position Position { get; set; }  
}