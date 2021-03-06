﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Entities.Transportadora
{
    public class FaixaDePreco : Base
    {
        public FaixaDePreco(Guid ID)
            : base(ID)
        {

        }
        
        public Guid IdTransportadora { get; set; }
        public Transportadora Transportadora { get;  set; }
        public Decimal Delimitador1 { get;  set; }
        public Decimal Delimitador2 { get;  set; }
    }
}
