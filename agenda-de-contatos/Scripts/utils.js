let telefones = $('#Telefone').val().split(';');
for (var i = 0; i < telefones.length; i++) {
    $('#listaTelefones').append('<li>' + telefones[i] + '</li>');
}
let emails = $('#Email').val().split(';');
for (var i = 0; i < emails.length; i++) {
    $('#listaEmails').append('<li>' + emails[i] + '</li>');
}