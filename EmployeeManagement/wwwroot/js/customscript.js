function confirmDelete(uniqueId, isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).addClass('d-none');
        $('#' + confirmDeleteSpan).removeClass('d-none');
    } else {
        $('#' + deleteSpan).removeClass('d-none');
        $('#' + confirmDeleteSpan).addClass('d-none');
    }
}