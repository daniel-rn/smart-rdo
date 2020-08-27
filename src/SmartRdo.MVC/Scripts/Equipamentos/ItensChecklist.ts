function addRow() {
    var index = document.getElementById("itemChecklist").getElementsByTagName("div").length;
    var inputItem = obterInputChecklist(index);
    var botaoRemover = obterBotaoRemoverItem(index)

    var divItem = document.createElement("div");
    divItem.className = "row mb-2";
    divItem.id = "item_" + index;
    divItem.appendChild(inputItem);
    divItem.appendChild(botaoRemover);

    document.getElementById("itemChecklist").appendChild(divItem);
}

function obterInputChecklist(index: number): HTMLInputElement {
    var inputItem = document.createElement("input");
    inputItem.className = "form-control col-xs-11 col-sm-11 col-md-11 col-lg-11 item-checklist";
    inputItem.name = "ItensChecklist[" + index + "].Descricao";
    inputItem.type = "text";
    inputItem.value = "";

    return inputItem;
}

function obterBotaoRemoverItem(index: number): HTMLButtonElement {
    var botaoRemover = document.createElement("input");
    botaoRemover.className = "btn btn-danger col-xs-1 col-sm-1 col-md-1 col-lg-1";
    botaoRemover.type = "button";
    botaoRemover.value = "X";
    botaoRemover.onclick = () => {
        removeRow(index);
    }

    return botaoRemover;
}


function removeRow(id) {
    var controlToBeRemoved = "item_" + id;
    document.getElementById(controlToBeRemoved).remove();

    document.querySelectorAll('.item-checklist').forEach((item: HTMLInputElement, index) => {
        item.name = "ItensChecklist[" + (index + 1) + "].Descricao";
    });
}