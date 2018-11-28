using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Entities
{
    public class BaseEntity<TId> : IBaseEntity<TId>
        where TId : IComparable<TId>, IEquatable<TId>
    {
        public TId Id { get; set; }
    }
}