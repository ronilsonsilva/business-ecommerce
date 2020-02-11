function carregarProvincias(idSelect, idPais) {
    var Url = "/Admin/Compartilhado/GetProvincias";
    $.ajax({
        url: Url,
        type: 'post',
        data: { idPais: idPais },
        success: function (dados) {
            carregarHtmlProvincia(dados, idSelect);
        }
    });
}

function carregarHtmlProvincia(dados, idSelect) {
    var select = '<option disabled selected>---- Selecione ----</option>';
    $.each(dados, function () {
        select += '<option value="' + this.id + '">' + this.nome + '</option>';
    });
    $("#" + idSelect).html(select);
}

function carregarCidades(idSelect,idProvincia) {
    var Url = "/Admin/Compartilhado/GetCidades";
    $.ajax({
        url: Url,
        type: 'post',
        data: { idProvincia: idProvincia },
        success: function (dados) {
            carregarHtmlCidades(dados, idSelect);
        }
    });
}

function carregarHtmlCidades(dados, idSelect) {
    var select = '<option disabled selected>---- Selecione ----</option>';
    $.each(dados, function () {
        select += '<option value="' + this.id + '">' + this.nome + '</option>';
    });
    $("#" + idSelect).html(select);
}