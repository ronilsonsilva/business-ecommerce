
$(document).ready(function () {
    $(".btn_enviar_msg").click(function (item) {
        var idOC = item.currentTarget.attributes.id.nodeValue.split('|')[0];
        var idCliente = item.currentTarget.attributes.id.nodeValue.split('|')[1];
        enviarMensagem(idOC, idCliente);
    });

    $(".msgsOC").click(function (item) {
        $('body').Wload({ text: ' Loading' });
        var IDOC = item.currentTarget.attributes.id.nodeValue;
        setarIdOC(IDOC);
        $('body').Wload('hide', { time: 10 });
    });

    $(".fechar-modal-anexos").click(function () {
        atualizarMensagens();
    });
});

function setarIdOC(IDOC) {
    var Url = "/Home/SetarOCChat";
    var Dados = {
        idOC: IDOC
    };
    $.ajax({
        url: Url,
        type: 'post',
        data: Dados,
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        
    });
}

function atualizarMensagens() {
    var texto = "";
    var Url = "/Admin/Pedidos/EnviarMensagem";
    var Dados = {
        texto: texto,
        idOC: "",
        idEmitente: "",
        carregarMensagens: true
    };
    $.ajax({
        url: Url,
        type: 'post',
        data: Dados,
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            carregarMsgs(result);
        },
    });
}

function enviarMensagem(idOC, idCliente) {
    var texto = $("#txtmsg_" + idOC).val();
    var Url = "/Admin/Pedidos/EnviarMensagem";
    var Dados = {
        texto: texto,
        idOC: idOC,
        idEmitente: idCliente
    };
    $.ajax({
        url: Url,
        type: 'post',
        data: Dados,
        error: function (error) { alert("Não foi possivel a comunicação: " + error) },
        success: function (result) {
            carregarMsgs(result, idOC, idCliente);
        },
    });
}

function carregarMsgs(dados, idOC, idCliente) {
    if (dados != "") {
        //var json = $.parseJSON(dados);
        var msgs = '';
        $.each(dados, function () {
            if (this.idEmitente != idCliente) {
                //var time = this.data.toLocaleTimeString().toLowerCase();
                //var data = this.data.getDate() + " " + month[this.Data.getMonth()] + ", " + this.Data.getFullYear();
                var icone = '';
                if (this.lida == true) {
                    icone += '<i class="fa fa-check" style="color: cornflowerblue"></i>';
                } else {
                    icone += '<i class="fa fa-check"></i>';
                }
                msgs += '<div class="outgoing_msg"><div class="sent_msg"><p>' + this.mensagem + '</p><span class="time_date">' + icone + '</span></div></div>';
            } else {
                //var time = this.Data.toLocaleTimeString().toLowerCase();
                //var data = this.Data.getDate() + " " + month[this.Data.getMonth()] + ", " + this.Data.getFullYear();
                var icone = '';
                if (this.lida == true) {
                    icone += '<i class="fa fa-check" style="color: cornflowerblue"></i>';
                } else {
                    icone += '<i class="fa fa-check"></i>';
                }
                msgs += '<div class="incoming_msg"><div class="received_msg"><div class="received_withd_msg"><p>' + this.mensagem + '</p><span class="time_date">' + icone + '</span></div></div></div>';
            }
        });
        $("#historicomsg").html(msgs);
        $("#txtmsg_" + idOC).val("");
    }
}