using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.Now;
        }

        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
