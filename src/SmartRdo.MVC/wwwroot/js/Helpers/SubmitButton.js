var divSubmit = document.getElementById('smart-rdo-submit');
divSubmit.className = "d-flex justify-content-center mb-2";
var inputHidden = document.getElementById('text-button');
var textButton = inputHidden.value;
inputHidden.remove();
var loadingComponent = getLoadingComponent();
divSubmit.appendChild(loadingComponent);
window.addEventListener("load", function () {
    var buttonSubmit = getButtonSubmit(textButton, loadingComponent);
    loadingComponent.hidden = true;
    divSubmit.appendChild(buttonSubmit);
});
function getLoadingComponent() {
    var divLoading = document.createElement('div');
    divLoading.className = "spinner-border text-success";
    return divLoading;
}
function getButtonSubmit(textButton, loadingComponent) {
    var input = document.createElement('input');
    input.className = "btn btn-block btn-success";
    input.type = "submit";
    input.value = textButton;
    input.onclick = () => {
        input.hidden = true;
        loadingComponent.hidden = false;
        input.form.submit();
    };
    return input;
}
//# sourceMappingURL=SubmitButton.js.map