var addTab = function (MenuPanel, tabPanel, id, url, titulo) {
    var tab = tabPanel.getComponent(id);

    if (!tab) {
        tab = tabPanel.add({
            id: id,
            title: titulo,
            closable: true,
            autoLoad: {
                showMask: true,
                url: url,
                mode: "iframe",
                maskMsg: "Cargando " + titulo + "...",
            }
        });

        tab.on("activate", function () {
            var item = MenuPanel.menu.items.get(id + "_item");

            if (item) {
                MenuPanel.setSelection(item);
            }
        }, this);
    }

    tabPanel.setActiveTab(tab);
}

