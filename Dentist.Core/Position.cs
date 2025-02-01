using Dentist.Core.Common;

namespace Dentist.Core;

public class Position : BasEntity
{
    public string Name { get; set; }
    public ICollection<Agent> Agents { get; set; }
}