
$(document).ready(function () {
    $(".alterarQtdProduto").click(function (item) {
        $('body').Wload({ text: ' Loading' });
        var idProduto = item.currentTarget.attributes.id.nodeValue.split('_')[1];
        alterarQuantidadeProduto(idProduto);
        $('body').Wload('hide', { time: 10 });
    })
    $(".excluirProduto").click(function (item) {
        $('body').Wload({ text: ' Loading' });
        var idProduto = item.currentTarget.attributes.id.nodeValue.split('_')[1];
        excluirProduto(idProduto);
        $('body').Wload('hide', { time: 10 });
    })


});


function alterarQuantidadeProduto(idProduto) {
    var quantidade = $("#" + idProduto).val();
    if (quantidade != "") {
        var Url = "/Home/AlterarQuantidadeProduto";
        $.ajax({
            url: Url,
            type: 'get',
            data: { idCarrinhoProduto: idProduto, quantidade: quantidade },
            error: function (error) { alert("Não foi possivel a comunicação: " + error) },
            success: function (result) {
                getItensCarrinho();
                $("#subtotal_" + idProduto).html("R$ " + parseInt(quantidade) * parseFloat(result));
            },
        });
    } else {
        
    }
    
}


function excluirProduto(idCarrinhoProduto) {
    var Url = "/Home/ExcluirProduto";
    $.ajax({
        url: Url,
        type: 'get',
        data: { idProduto : idCarrinhoProduto },
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            location.reload(); 
        },
    });
}
