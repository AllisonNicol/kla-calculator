$("button").not(".action,.equals").click(function() {
    $("#Formula").val($("#Formula").val() + this.textContent);
});

$("button:contains('CE')").click(function () {
    $("#Formula").val($("#Formula").val().slice(0,-1));
});

$("button:contains('AC')").click(function () {
    $("#Formula").val("");
    $("#Answer").val("");
});