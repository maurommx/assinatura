using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        private DateTime? _createAt;
        public virtual DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public virtual DateTime? UpdateAt { get; set; }

    }
}
