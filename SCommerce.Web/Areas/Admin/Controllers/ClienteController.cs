using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SCommerce.Domain.Entities.Cliente;
using SCommerce.Domain.Interfaces.Repositories.CadastroBase;
using SCommerce.Domain.Interfaces.Repositories.Cliente;
using SCommerce.Web.Areas.Admin.ViewModels;

namespace SCommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClienteController : BaseController
    {
        ILojaRepository _lojaRepository;
        IClienteRepository _clienteRepository;
        IPaisRepository _paisRepository;
        IContatoTelefoneRepository _contatoTelefoneRepository;
        IEnderecoRepository _enderecoRepository;
        ICidadeRepository _cidadeRepository;
        IMapper _mapper;

        public ClienteController(ILojaRepository lojaRepository, IClienteRepository clienteRepository, IPaisRepository paisRepository, IContatoTelefoneRepository contatoTelefoneRepository, IEnderecoRepository enderecoRepository, ICidadeRepository cidadeRepository, IMapper mapper)
        {
            _lojaRepository = lojaRepository;
            _clienteRepository = clienteRepository;
            _paisRepository = paisRepository;
            _contatoTelefoneRepository = contatoTelefoneRepository;
            _enderecoRepository = enderecoRepository;
            _cidadeRepository = cidadeRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            if (GetEmpregado() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            var clientes = _clienteRepository.GetAll();
            if (clientes != null)
            {
                ICollection<ClienteViewModel> clienteViewModels = ClienteViewModel.Mapear(clientes.ToList());
                return View(clienteViewModels);
            }
            return View();
        }

        public void ConfigEditCreate(ClienteViewModel clienteViewModel)
        {
            try
            {
                ViewBag.Paises = new SelectList(_paisRepository.GetAll(), "ID", "Nome");
                ViewBag.TipoContato = new SelectList(Utils.GetEnum.TipoTelefones(), "Valor", "Exibir",clienteViewModel?.ContatoTelefoneViewModel?.TipoContato);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                ClienteViewModel clienteViewModel = new ClienteViewModel();
                this.ConfigEditCreate(clienteViewModel);
                return View(clienteViewModel);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var error = new List<String>();
                if (clienteViewModel != null)
                {
                    if (clienteViewModel.Senha != clienteViewModel.Senha1)
                    {
                        error.Add("Senhas não coincidem.");
                        this.ConfigEditCreate(clienteViewModel);
                    }
                    if (_clienteRepository.ExisteEmail(clienteViewModel.Email))
                    {
                        error.Add("E-mail informado já está em uso.");
                    }
                    if (_clienteRepository.ExisteUsuario(clienteViewModel.Usuario))
                    {
                        error.Add("Usuário informado já está em uso");
                    }
                    if (error.Count == 0)
                    {
                        var clienteEnntity = ClienteViewModel.Mapear(clienteViewModel);
                        clienteEnntity.Senha = Utils.StringExtension.ConvertToMD5(clienteEnntity.Senha);
                        clienteEnntity.Cadastro = DateTime.Now;
                        clienteEnntity.Atualizado = DateTime.Now;
                        var contatoTelefone = ContatoTelefoneViewModel.Mapear(clienteViewModel.ContatoTelefoneViewModel);
                        contatoTelefone.IdCliente = clienteEnntity.ID;

                        var endereco = EnderecoViewModel.Mapear(clienteViewModel.EnderecoViewModel);
                        endereco.IdCliente = clienteEnntity.ID;
                        endereco.Cidade = null;
                        endereco.Cadastro = DateTime.Now;
                        endereco.Atualizado = DateTime.Now;
                        clienteEnntity.ContatoTelefones.Add(contatoTelefone);
                        clienteEnntity.Enderecos.Add(endereco);
                        _clienteRepository.Add(clienteEnntity);
                        return RedirectToAction("Index");
                    }
                    
                }
                ViewBag.Error = error;
                this.ConfigEditCreate(clienteViewModel);
                return View(clienteViewModel);
            }
            catch (Exception erro)
            {
                this.ConfigEditCreate(clienteViewModel);
                return View(clienteViewModel);
            }
        }

        public IActionResult Edit(Guid idCliente)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCliente != null && idCliente != Guid.Empty)
                {
                    var clienteEntity = _clienteRepository.GetCliente(idCliente);
                    if (clienteEntity != null)
                    {
                        ClienteViewModel clienteViewModel = ClienteViewModel.Mapear(clienteEntity);
                        this.ConfigEditCreate(clienteViewModel);
                        return View(clienteViewModel);
                    }
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var erro = new List<String>();
                if (clienteViewModel.submit != null && clienteViewModel.submit.Equals("add_endereco"))
                {
                    var enderecoEntity = EnderecoViewModel.Mapear(clienteViewModel.EnderecoViewModel);
                    enderecoEntity.IdCliente = clienteViewModel.ID;
                    enderecoEntity.Atualizado = DateTime.Now;
                    enderecoEntity.Cadastro = DateTime.Now;
                    enderecoEntity.Cidade = null;
                    _enderecoRepository.Add(enderecoEntity);
                    this.ConfigEditCreate(clienteViewModel);
                    clienteViewModel.EnderecoViewModel = null;
                    clienteViewModel.Enderecos = EnderecoViewModel.Mapear(_enderecoRepository.GetEnderecosCliente(clienteViewModel.ID).ToList());
                    clienteViewModel.ContatoTelefones = ContatoTelefoneViewModel.Mapear(_contatoTelefoneRepository.GetContatoTelefonesCliente(clienteViewModel.ID));
                    return RedirectToAction("Edit", new { idCliente = clienteViewModel.ID });
                }
                else if (clienteViewModel.submit != null && clienteViewModel.submit.Equals("add_telefone"))
                {
                    var contatoTelefone = ContatoTelefoneViewModel.Mapear(clienteViewModel.ContatoTelefoneViewModel);
                    contatoTelefone.IdCliente = clienteViewModel.ID;
                    _contatoTelefoneRepository.Add(contatoTelefone);
                    this.ConfigEditCreate(clienteViewModel);
                    clienteViewModel.ContatoTelefoneViewModel = null;
                    clienteViewModel.Enderecos = EnderecoViewModel.Mapear(_enderecoRepository.GetEnderecosCliente(clienteViewModel.ID).ToList());
                    clienteViewModel.ContatoTelefones = ContatoTelefoneViewModel.Mapear(_contatoTelefoneRepository.GetContatoTelefonesCliente(clienteViewModel.ID));
                    return RedirectToAction("Edit", new { idCliente = clienteViewModel.ID});
                }
                else if (clienteViewModel.submit != null && clienteViewModel.submit.StartsWith("excluirEndereco_"))
                {
                    var idEndereco = Guid.Parse(clienteViewModel.submit.Split('_')[1]);
                    var endereco = _enderecoRepository.GetById(idEndereco);
                    if (endereco != null)
                    {
                        _enderecoRepository.Remove(endereco);
                    }
                    return RedirectToAction("Edit", new { idCliente = clienteViewModel.ID });
                }
                else if (clienteViewModel.submit != null && clienteViewModel.submit.StartsWith("excluirTelefone_"))
                {
                    var idContatoTelefone = Guid.Parse(clienteViewModel.submit.Split('_')[1]);
                    var contatoTelefone = _contatoTelefoneRepository.GetById(idContatoTelefone);
                    if (contatoTelefone != null)
                    {
                        _contatoTelefoneRepository.Remove(contatoTelefone);
                    }
                    return RedirectToAction("Edit", new { idCliente = clienteViewModel.ID });
                }
                else if (clienteViewModel != null)
                {
                    if (String.IsNullOrEmpty(clienteViewModel.Senha) || String.IsNullOrEmpty(clienteViewModel.Senha1))
                    {
                        erro.Add("Digite a senha.");
                    }
                    if (clienteViewModel.Senha != clienteViewModel.Senha1)
                    {
                        erro.Add("Senhas não coincidem.");
                    }
                    if (erro.Count == 0)
                    {
                        var clienteEntity = ClienteViewModel.Mapear(clienteViewModel);
                        clienteEntity.Enderecos = null;
                        clienteEntity.ContatoTelefones = null;
                        clienteEntity.OCs = null;
                        clienteEntity.Carrinhos = null;
                        clienteEntity.ClienteProcessos = null;
                        clienteEntity.Atualizado = DateTime.Now;
                        _clienteRepository.Update(clienteEntity);
                    }
                    else
                    {
                        ViewBag.Error = erro;
                        return View(clienteViewModel);
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                this.ConfigEditCreate(clienteViewModel);
                return View(clienteViewModel);
            }
        }

        public IActionResult Delete(Guid idCliente)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCliente != null && idCliente != Guid.Empty)
                {
                    var clienteEntity = _clienteRepository.GetById(idCliente);
                    if (clienteEntity != null)
                    {
                        ClienteViewModel clienteViewModel = ClienteViewModel.Mapear(clienteEntity);
                        return View(clienteViewModel);
                    }
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ClienteViewModel clienteViewModel)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                var clienteEntity = _clienteRepository.GetById(clienteViewModel.ID);
                if (clienteEntity != null)
                {
                    clienteViewModel = ClienteViewModel.Mapear(clienteEntity);
                    _clienteRepository.Remove(clienteEntity);
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                ViewBag.error = "Não foi possivel excluir o registro.";
                return View(clienteViewModel);
            }
        }

        public IActionResult Details(Guid idCliente)
        {
            try
            {
                if (GetEmpregado() == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                if (idCliente != null && idCliente != Guid.Empty)
                {
                    var clienteEntity = _clienteRepository.GetById(idCliente);
                    if (clienteEntity != null)
                    {
                        ClienteViewModel clienteViewModel = ClienteViewModel.Mapear(clienteEntity);
                        return View(clienteViewModel);
                    }
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return NotFound();
            }
        }
    }
}