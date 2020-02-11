using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SCommerce.Domain.Entities
{
    public abstract class Base
    {
        //public Base()
        //{
        //    this.ID = Guid.NewGuid();
        //}

        protected Base(Guid ID)
        {
            this.ID = ID;
        }

        [Key]
        public virtual Guid ID { get; set; }
    }
}
