using System;

namespace IczpNet.Connection.Dtos
{
    public class ConnectionCreateInput
    {
        public virtual string Id { get; set; }
        public virtual string ServerHostId { get; set; }

        public virtual Guid? AppUserId { get; set; }

        public virtual Guid? ChatObjectId { get; set; }

        public virtual string DeviceId { get; set; }

        public virtual string IpAddress { get; set; }

        public virtual string BrowserInfo { get; set; }

        public virtual DateTime ActiveTime { get; private set; } = DateTime.Now;
    }
}
