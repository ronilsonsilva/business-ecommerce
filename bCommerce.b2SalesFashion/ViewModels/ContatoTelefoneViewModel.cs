
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SCommerce.b2SalesFashion.ViewModels
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


        public static ContatoTelefoneViewModel Mapear(SCommerce.Domain.Entities.CadastroBase.ContatoTelefone contatoTelefone)
        {
            try
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
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static ICollection<ContatoTelefoneViewModel> Mapear(ICollection<SCommerce.Domain.Entities.CadastroBase.ContatoTelefone> contatoTelefones)
        {
            try
            {
                Collection<ContatoTelefoneViewModel> saida = new Collection<ContatoTelefoneViewModel>();
                if (contatoTelefones != null)
                {
                    foreach (var item in contatoTelefones)
                    {
                        var contatoTelefone = Mapear(item);
                        saida.Add(contatoTelefone);
                    }
                }
                return saida;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
