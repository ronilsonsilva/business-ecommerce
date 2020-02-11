﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.b2SalesFashion.ViewModels
{
    public class ClienteGrupoViewModel : BaseViewModels
    {
        [Display(Name = "Nome Cliente")]
        public Guid ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }

        [Display(Name = "Nome Cliente")]
        public Guid GrupoId { get; set; }


        public GrupoViewModel Grupo { get; set; }
    }
}
