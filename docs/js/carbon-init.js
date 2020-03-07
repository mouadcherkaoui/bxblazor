window.leftPanelFocus = function () {
    var panel = document.getElementById("navigation-menu");
    panel.focus();
};

window.initDataTable = function (id) {
    var elem = document.getElementById(id);
    var table = CarbonComponents.DataTableV2.create(elem, {});
};


window.setClassForTag = function (tag, _class) {
    var elements = document.getElementsByTagName(tag);
    for (var i = 0; i < elements.length; i++) {
        elements.item(i).classList.add(_class);
    }
};

window.removeClassFromTag = function (tag, _class) {
    var elements = document.getElementsByTagName(tag);
    for (var i = 0; i < elements.length; i++) {
        elements.item(i).classList.remove(_class);
    }
};

window.setClassForId = function (id, _class) {
    var element = document.getElementById(id);
    element.classList.add(_class);
};

window.removeClassFromId = function (id, _class) {
    var element = document.getElementById(id);
    element.classList.remove(_class);
};

window.bxTab_Init = function () {
    CarbonComponents.Tab.init();
};

window.bxAccordion_Init = function () {
    CarbonComponents.Accordion.init();
};

window.bxModal_Init = function () {
    CarbonComponents.Modal.init();
};

window.bxStructuredList_Init = function () {
    CarbonComponents.StructuredList.init();
};

window.bxOverflowMenu_Init = function () {
    CarbonComponents.OverflowMenu.init();
};

window.bxDataTable_Init = function () {
    CarbonComponents.DataTable.init();
};

window.bxHeaderNav_Init = function () {
    CarbonComponents.HeaderNav.init();
};

window.bxTile_Init = function () {
    CarbonComponents.Tile.init();
};

window.bxToolBar_Init = function () {
    CarbonComponents.Toolbar.init();
};

window.bxTooltip_Init = function () {
    CarbonComponents.Tooltip.init();
};

window.bxNavigationMenu_Init = function () {
    CarbonComponents.NavigationMenu.init();
};

window.bxNotification_Init = function () {
    CarbonComponents.Notification.init();
};

window.bxCodeSnippet_Init = function () {
    CarbonComponents.CodeSnippet.init();
};

window.bxPagination_Init = function () {
    CarbonComponents.Pagination.init();
};

window.bxModal_show = function (id) {
    var element = document.getElementById(id);
    window.modal = CarbonComponents.Modal.create(element);
    window.modal.show();
};

window.bxNotification_show = function (id) {    
    var element = document.getElementById(id);
    element.classList.add("show");
    this.setTimeout(() => element.classList.remove("show"), 3000);    
};