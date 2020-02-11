using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.CadastroBase
{
    public class WebBrownser : Base
    {
        public WebBrownser(Guid ID)
            : base(ID)
        {

        }
        

        public String Nome { get;  set; }
    }
}
