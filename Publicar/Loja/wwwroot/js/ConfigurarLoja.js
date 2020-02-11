
$(document).ready(function () {
    $('body').Wload({ text: ' Loading' });
    getClienteLogado();
    getItensCarrinho();
    $('body').Wload('hide', { time: 10 });
});

function getItensCarrinho() {
    var URL = "/Cliente/GetItensCarrinho";
    $.ajax({
        url: URL,
        type: 'get',
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            carregarCarrinho(result);
        },
    });
}

function getClienteLogado() {
    var URL = "/Cliente/GetClienteSession";
    $.ajax({
        url: URL,
        type: 'get',
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            carregarClienteLogado(result);
        },
    });
}

function carregarCarrinho(dados) {
    if (dados != "") {
        var json = $.parseJSON(dados);
        var itensCarrinho = '';
        var total = 0;
        $.each(json.CarrinhoProdutos, function () {
            itensCarrinho += '<div class="header-chart-dropdown-list"><div class="dropdown-chart-left floatleft"><a href="/Home/Produto&idProduto=' + this.IdProduto + '"><img width="70" height="83" src="data:' + this.Produto.imagens[0].Formato + ';base64,' + this.Produto.imagens[0].Arquivo + '" alt="list"></a></div><div class="dropdown-chart-right"><h2><a href="/Home/Produto?idProduto=' + this.IdProduto + '">' + this.Produto.NomeExibicao + '</a></h2><h3>Quantidade: ' + this.Quantidade + '</h3><h4> R$' + this.Produto.Preco + '</h4></div></div>';
            total += (this.Produto.Preco * this.Quantidade);
        });
        $("#itensCarrinho").html(itensCarrinho);
        $("#subtotalCarrinho").html("R$ " + total);
        $("#vlrTotalCarrinho").html("R$ " + total);
    }
}

function carregarClienteLogado(cliente) {
    if (cliente != "") {
        $("#linkMinhaConta").show();
        $("#sairCliente").show();
        $("#liNomeCliente").show();
        $("#loginCliente").hide();
        $("#registrarCliente").hide();
        $("#nomeCliente").html(cliente.nome);
    } else {
        $("#linkMinhaConta").hide();
        $("#sairCliente").hide();
        $("#liNomeCliente").hide();
        $("#loginCliente").show();
        $("#registrarCliente").show();
    }
}