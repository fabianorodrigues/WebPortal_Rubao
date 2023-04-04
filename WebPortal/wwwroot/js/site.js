Webcam.set({
    width: 385,
    height: 280,
    image_format: 'jpeg',
    jpeg_quality: 100
});
Webcam.attach('#mac_camera');

function tira_foto() {

    if ($("#Nome").val() === '' || $("#Nome").val() === null || $("#CPF").val() === '' || $("#CPF").val() === nul) {
        alert('Insira o nome e o CPF para realizar a captura da imagem.');
        $('#fechar_modal').click();
    }

    // tira a foto e obtem os dados da imagem
    Webcam.snap(function (data_uri) {
        // exibe o resultado da captura
        document.getElementById('resultado').style.display = "block";
        document.getElementById('resultado').innerHTML = '<img src="' + data_uri + '"/>';
        // oculta a leitura da camera
        document.getElementById('mac_camera').style.display = "none";

        localStorage.setItem('foto_tecnico', JSON.stringify(data_uri))
    });
}

function salvar_foto() {

    var data_uri = localStorage.getItem('foto_tecnico');

    $("#Nome").prop('readonly', true);
    $("#CPF").prop('readonly', true);

    Webcam.upload(JSON.parse(data_uri), '/Camera/CapturaImagem', function (code, text) {
        alert('Imagem salva com sucesso.');
        habilitar_camera();
    });
}

function habilitar_camera() {
    // oculta o resultado da captura
    document.getElementById('resultado').style.display = "none";
    // exibe a leitura da camera
    document.getElementById('mac_camera').style.display = "block";
}