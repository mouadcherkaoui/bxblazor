window.initDualListbox = function (name) {
    $(`select[name="${name}"]`).bootstrapDualListbox({
        nonSelectedListLabel: 'Non-selected',
        selectedListLabel: 'Selected',
        preserveSelectionOnMove: 'moved',
        moveOnSelect: false,
        nonSelectedFilter: ''//'ion ([7-9]|[1][0-2])'
    });
};