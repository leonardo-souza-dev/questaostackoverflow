// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#enviarBtn").click(function () {

        var enviarLote = { Ids: [] };

        $("#tablepesquisaclientes tr").each(function (index, el) {
            var $linha = $(el);
            var checked = $linha.find('.checked:checked').length;
            if (checked === 1) {

                var id = $linha.find('td').eq(1).text();
                enviarLote.Ids.push(id);
                console.log($linha.find('td').eq(1).text());
            }
        });

        $.post("/Home/Enviar", enviarLote)
            .done(function (data) {
                console.log('postado a');
                console.log(data);
                console.log('postado b');
            })
            .fail(function (data) {
                console.log(data);
                console.log('erro');
            })
            .always(function (data) {
                console.log(data);
                console.log('fim');
            });
    });
});



