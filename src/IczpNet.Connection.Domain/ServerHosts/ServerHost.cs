using IczpNet.Connection.Bases;
using System;

namespace IczpNet.Connection.ServerHosts
{
    public class ServerHost : BaseEntity<string>
    {
        public virtual DateTime? ActiveTime { get; set; }

        public virtual bool IsEnabled { get; set; }
    }
}
