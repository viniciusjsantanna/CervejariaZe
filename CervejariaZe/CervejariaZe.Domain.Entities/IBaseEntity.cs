using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Entities
{
    public interface IBaseEntity<TId>
        where TId : IComparable<TId>, IEquatable<TId>
    {
        TId Id { get; set; }
    }
}