using System;

namespace IczpNet.Connection.Dtos
{
    public class ConnectionDto
    {
        public virtual string Id { get; set; }

        public virtual Guid? AppUserId { get; set; }

        public virtual Guid? ChatObjectId { get; set; }

        public virtual string Server { get; set; }

        public virtual string DeviceId { get; set; }

        public virtual string Ip { get; set; }

        public virtual string Agent { get; set; }

        public virtual DateTime ActiveTime { get; private set; } = DateTime.Now;
    }
}
