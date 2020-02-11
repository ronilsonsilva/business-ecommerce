using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Web.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.Web.Areas.Admin.ViewModels
{
    public class ContatoTelefoneViewModel : BaseViewModels
    {
        [Display(Name = "Descrção")]
        public String Descricao { get; set; }

        [Display(Name = "DDD")]
        public int CodigoLocal { get; set; }

        [Display(Name = "DDI")]
        public int CodigoNacional { get; set; }

        [Display(Name = "Operadora")]
        public String Operadora { get; set; }

        [Display(Name = "Número")]
        public String Numero { get; set; }

        [Display(Name = "Tipo de Contato")]
        public Domain.Enum.ContatoTelefone TipoContato { get; set; }

        public static ContatoTelefoneViewModel Mapear(ContatoTelefone contatoTelefone)
        {
            var saida = new ContatoTelefoneViewModel();
            if (contatoTelefone != null)
            {
                saida = new ContatoTelefoneViewModel()
                {
                    CodigoLocal = contatoTelefone.CodigoLocal,
                    CodigoNacional = contatoTelefone.CodigoNacional,
                    Descricao = contatoTelefone.Descricao,
                    ID = contatoTelefone.ID,
                    Numero = contatoTelefone.Numero,
                    Operadora = contatoTelefone.Operadora,
                    TipoContato = contatoTelefone.TipoContato
                };
            }
           
            return saida;
        }

        public static ICollection<ContatoTelefoneViewModel> Mapear(ICollection<ContatoTelefone> contatoTelefones)
        {
            var saida = new Collection<ContatoTelefoneViewModel>();
            if (contatoTelefones != null)
            {
                foreach (var item in contatoTelefones)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }

        public static ContatoTelefone Mapear(ContatoTelefoneViewModel contatoTelefone)
        {
            var saida = new ContatoTelefone(Guid.Empty);
            if (contatoTelefone != null)
            {
                saida = new ContatoTelefone(Guid.Empty)
                {
                    CodigoLocal = contatoTelefone.CodigoLocal,
                    CodigoNacional = contatoTelefone.CodigoNacional,
                    Descricao = contatoTelefone.Descricao,
                    ID = contatoTelefone.ID != null && contatoTelefone.ID != Guid.Empty ? contatoTelefone.ID : Guid.NewGuid(),
                    Numero = contatoTelefone.Numero,
                    Operadora = contatoTelefone.Operadora,
                    TipoContato = contatoTelefone.TipoContato
                };
            }

            return saida;
        }

        public static ICollection<ContatoTelefone> Mapear(ICollection<ContatoTelefoneViewModel> contatoTelefones)
        {
            var saida = new Collection<ContatoTelefone>();
            if (contatoTelefones != null)
            {
                foreach (var item in contatoTelefones)
                {
                    saida.Add(Mapear(item));
                }
            }
            return saida;
        }
    }
}
