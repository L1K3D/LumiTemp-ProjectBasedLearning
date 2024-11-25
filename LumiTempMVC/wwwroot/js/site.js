function buscaCEP() {
    var cep = document.getElementById("cep_empr").value;
    cep = cep.replace('-', ''); // removemos o traço do CEP
    if (cep.length > 0) {
        var linkAPI = 'https://viacep.com.br/ws/' + cep + '/json/';
        $.ajax({
            url: linkAPI,
            beforeSend: function () {
                document.getElementById("log_empr").value = '...';
                document.getElementById("bairro_empr").value = '...';
                document.getElementById("cidade_empr").value = '...';
                document.getElementById("estado_empr").value = '...';
            },
            success: function (dados) {
                if (dados.erro != undefined) // quando o CEP não existe...
                {
                    alert('CEP não localizado...');
                    document.getElementById("log_empr").value = '';
                    document.getElementById("bairro_empr").value = '';
                    document.getElementById("cidade_empr").value = '';
                    document.getElementById("estado_empr").value = '';
                }
                else // quando o CEP existe
                {
                    document.getElementById("log_empr").value = dados.logradouro;
                    document.getElementById("bairro_empr").value = dados.bairro;
                    document.getElementById("cidade_empr").value = dados.localidade;
                    document.getElementById("estado_empr").value = dados.uf;
                }
            }
        });
    }
} 
function aplicaFiltroConsultaAvancada() {
    var vDescricao = document.getElementById('descricao').value;
    var vDataInicial = document.getElementById('dataInicial').value;
    var vDataFinal = document.getElementById('dataFinal').value;
    $.ajax({
        url: "/funcionario/ObtemDadosConsultaAvancada",
        data: { descricao: vDescricao, dataInicial: vDataInicial, dataFinal: vDataFinal },
        success: function (dados) {
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultadoConsulta').innerHTML = dados;
            }
        },
    });

} 
function aplicaFiltroConsultaAvancada2() {
    var vDescricao = document.getElementById('descricao').value;
    var vEmpresa = document.getElementById('empresa').value;
    var vDataInicial = document.getElementById('dataInicial').value;
    var vDataFinal = document.getElementById('dataFinal').value;
    $.ajax({
        url: "/sensor/ObtemDadosConsultaAvancada2",
        data: { descricao: vDescricao, empresa: vEmpresa, dataInicial: vDataInicial, dataFinal: vDataFinal },
        success: function (dados) {
            if (dados.erro != undefined) {
                alert(dados.msg);
            }
            else {
                document.getElementById('resultadoConsulta').innerHTML = dados;
            }
        },
    });

} 
