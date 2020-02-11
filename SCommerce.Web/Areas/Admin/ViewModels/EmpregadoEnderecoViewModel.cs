﻿using SCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class EmpregadoEnderecoViewModel : BaseViewModels
    {
        [Display(Name = "Empregado")]
        public Guid EmpregadoId { get; set; }

        [Display(Name = "Endereco")]
        public Guid EnderecoId { get; set; }

        public EmpregadoViewModel Empregado { get; set; }
        public EnderecoViewModel Endereco { get; set; }
    }
}
