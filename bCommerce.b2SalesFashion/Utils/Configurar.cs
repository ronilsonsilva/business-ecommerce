using SCommerce.b2SalesFashion.ViewModels;
using SCommerce.Domain.Entities.Produto;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Entities.CMS;
using SCommerce.Domain.Entities.CadastroBase;
using SCommerce.Domain.Entities.Carrinho;
using Microsoft.AspNetCore.Mvc;

namespace bCommerce.b2SalesFashion.Utils
{
    public static class Configurar
    {
        public static List<Categoria> GetCategorias()
        {
            try
            {
                ScContext scContext = new ScContext();
                return scContext.Categoria.Where(x => x.Root == true && x.Ativo == true).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<Categoria> GetFilhosDaCategorias(Guid idCategoria)
        {
            try
            {
                ScContext scContext = new ScContext();
                return scContext.Categoria.Where(x => x.IDCategoriaPai == idCategoria && x.Ativo == true).ToList();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<CMSSlidePrincipal> GetSlidePrincipals()
        {
            try
            {
                ScContext scContext = new ScContext();
                var slides = scContext.CMSSlidePrincipals.ToList();
                return slides;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static String GetWhatsApp()
        {
            try
            {
                ScContext scContext = new ScContext();
                var cms = scContext.CMSWhatsApps.FirstOrDefault();
                if (cms != null)
                {
                    var cntLoja = scContext.ContatoLojaTelefone.Find(cms?.IDContatoLojaTelefone);
                    var whatsApp = scContext.ContatoTelefone.Find(cntLoja?.IdContatoTelefone);
                    if (whatsApp != null)
                    {
                        return ("+" + whatsApp?.CodigoNacional + whatsApp?.CodigoLocal + whatsApp?.Numero);
                    }
                }
                return "";
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<Endereco> GetEnderecos()
        {
            try
            {
                ScContext scContext = new ScContext();
                var contatoLojaEndereco = scContext.ContatoLojaEndereco.ToList();
                List<Endereco> enderecos = new List<Endereco>();
                foreach (var item in contatoLojaEndereco)
                {
                    if (item.IdEndereco != null)
                    {
                        item.Endereco = scContext.Endereco.Find(item.IdEndereco);
                        if (item.Endereco != null)
                        {
                            item.Endereco.Cidade = scContext.Cidade.Find(item.Endereco.IdCidade);
                        }
                        if (item.Endereco.Cidade != null)
                        {
                            item.Endereco.Cidade.Provincia = scContext.Provincia.Find(item.Endereco.Cidade.IdProvincia);
                        }
                        if (item.Endereco.Cidade.Provincia != null)
                        {
                            item.Endereco.Cidade.Provincia.Pais = scContext.Pais.Find(item.Endereco.Cidade.Provincia.IdPais);
                        }
                        enderecos.Add(item.Endereco);
                    }

                }
                return enderecos;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<ContatoTelefone> GetTelefones()
        {
            try
            {
                ScContext scContext = new ScContext();
                var contatoLojaTelefone = scContext.ContatoLojaTelefone.ToList();
                List<ContatoTelefone> telefones = new List<ContatoTelefone>();
                foreach (var item in contatoLojaTelefone)
                {
                    item.ContatoTelefone = scContext.ContatoTelefone.Find(item.IdContatoTelefone);
                    telefones.Add(item.ContatoTelefone);
                }
                return telefones;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static List<ContatoEmail> GetEmails()
        {
            try
            {
                ScContext scContext = new ScContext();
                var contatoLojaEmail = scContext.ContatoLojaEmail.ToList();
                List<ContatoEmail> contatoEmails = new List<ContatoEmail>();
                foreach (var item in contatoLojaEmail)
                {
                    item.ContatoEmail = scContext.ContatoEmails.Find(item.IdContatoEmail);
                    contatoEmails.Add(item.ContatoEmail);
                }
                return contatoEmails;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public static List<CMSRedeSocial> GetRedeSocials()
        {
            try
            {
                ScContext scContext = new ScContext();
                var contatoLoja = scContext.CMSRedeSocials.ToList();

                return contatoLoja;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static Loja GetLoja()
        {
            try
            {
                ScContext scContext = new ScContext();
                return scContext.Loja.FirstOrDefault();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static CMSLoja GetCMSLoja()
        {
            try
            {
                ScContext scContext = new ScContext();
                return scContext.CMSLoja.FirstOrDefault();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public static Carrinho GetCarrinho()
        {
            try
            {

                ScContext scContext = new ScContext();

                return scContext.Carrinho.Where(x => x.GerarOC == false).FirstOrDefault();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
    
}
