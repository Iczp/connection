using IczpNet.Connection.Bases;
using System;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.Connection.ServerHosts
{
    public class ServerHost : BaseEntity<string>
    {
        //[Key]
        //[StringLength(128)]
        //public override string Id { get; protected set; }

        public virtual DateTime? ActiveTime { get; set; }

        public virtual bool IsEnabled { get; set; }

        protected ServerHost() { }

        public ServerHost(string id) : base(id)
        {
            Id = id;
        }
    }
}
