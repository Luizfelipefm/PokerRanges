function SubmitForm() {

    let Cartas = $('#idCartas').val();
    let Blinds= $('#idBlinds').val();
    let Posicao= $('#idPosicao').val();

    $.ajax({
        url: "/Search/" + Cartas + '/' + Blinds + '/' + Posicao,
        type: 'GET',
        data: null,//JSON.stringify({ pCodTituloCapa: pCodTituloCapa, pIdAtendimentoInteracao: IdAtendimentoInteracao }),
        contentType: "application/json",
        success: function (data) {
            if (data) {
                $('#Result').html(data);
            }
            else {
                $('#Result').html('<div class="alert alert-danger">Erro</div>');
            }
        },
        error: function (requestObject, error, errorThrown) {
            $('#Result').html('<div class="alert alert-danger">Erro</div>');
        }
    });
}
