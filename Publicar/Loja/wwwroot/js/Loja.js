
$(document).ready(function () {
    $(".link-add-produto-carrinho").click(function (item) {
        $('body').Wload({ text: ' Loading' });
        var idProduto = item.currentTarget.attributes.id.nodeValue.split('_')[1];
        adicionarProdutoCarrinho(idProduto);
        $('body').Wload('hide', { time: 10 });
    });
});

function adicionarProdutoCarrinho(idProduto) {
    var Url = "/Home/AdicionarProdutoCarrinho";
    $.ajax({
        url: Url,
        type: 'post',
        data: { idProduto: idProduto },
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            if (result == "") {
                getItensCarrinho();
            } else if (result == "Usuário deve acessar sua conta") {
                window.location.href = "/Cliente";
            }
        },
    });
}