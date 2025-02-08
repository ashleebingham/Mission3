$(document).ready(function () {
    $("#calculate").click(function () {
        let hours = parseFloat($("#hours").val());
        let rate = parseFloat($("#rate").text());

        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid number of hours.");
            return;
        }

        let total = hours * rate;
        $("#total").text(`$${total.toFixed(2)}`);
    });
});
