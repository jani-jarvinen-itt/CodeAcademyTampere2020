$("#laskeNappi").click(function () {

    const luku1 = $("#luku1").val();
    const luku2 = $("#luku2").val();
    console.log("Syötetyt luvut: " + luku1 + " ja " + luku2 + ".");

    const url = "/api/laskin/summa/" + luku1 + "/" + luku2;
    fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: null,
    })
    .then(response => response.json())
    .then(tulos => {
        console.log("Tulos: ", tulos);

        $("#laskennanTulos").text(tulos);
        $("#tulosAlue").css("display", "block");
    });
    console.log("HTTP-pyyntö lähetetty.");
});
