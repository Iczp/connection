using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace IczpNet.Connection.Bases
{
    public abstract class BaseEntity<TKey> : FullAuditedAggregateRoot<TKey>
    {

        protected BaseEntity() { }

        protected BaseEntity(TKey id) : base(id) { }
    }

    public abstract class BaseEntity : Entity
    {
    }
}
