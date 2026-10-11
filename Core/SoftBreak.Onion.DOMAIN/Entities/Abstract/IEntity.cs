using SoftBreak.Onion.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DataStatus Status { get; set; }
    }
}
