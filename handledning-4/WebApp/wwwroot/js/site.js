function getFileName(e) {
    var fileName = e.target.files[0].name;
    document.getElementById('fileName').innerHTML = fileName;
}

function validateRequired(e) {
    validationfield = document.querySelector(`[data-valmsg-for="${e.target.id}"]`)

    if (e.target.value.length >= 1)
        validationfield.innerHTML = ""
    else
        validationfield.innerHTML = e.target.dataset.valRequired
}
