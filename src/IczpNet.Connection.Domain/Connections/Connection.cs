using IczpNet.Connection.Bases;
using IczpNet.Connection.ServerHosts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Connection.Connections
{
    public class Connection : BaseEntity<string>
    {
        [Key]
        [StringLength(64)]
        public override string Id { get; protected set; }

        public virtual string ServerHostId { get; set; }

        [ForeignKey(nameof(ServerHostId))]
        public virtual ServerHost ServerHost { get; set; }

        public virtual Guid? AppUserId { get; set; }

        public virtual Guid? ChatObjectId { get; set; }

        [StringLength(50)]
        public virtual string DeviceId { get; set; }

        [StringLength(36)]
        public virtual string IpAddress { get; set; }

        [StringLength(300)]
        public virtual string BrowserInfo { get; set; }

        public virtual DateTime ActiveTime { get; private set; } = DateTime.Now;

        protected Connection() { }

        public Connection(string id) : base(id)
        {

        }

        internal void SetActiveTime(DateTime activeTime)
        {
            ActiveTime = activeTime;
        }

        public void SetConnectionId(string id)
        {
            Id = id.ToLower();
        }
    }
}
