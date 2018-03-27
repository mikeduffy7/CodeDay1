function attack() {
    var div = document.getElementById("battleDialogue");
    div.innerHTML += "Champion used basic attack against minion.";
}

function highlightMinion(x) {
    var minions = document.querySelectorAll(".battleMinion");
    console.log = minions.length;
    if ($(x).hasClass("targeted")) {
        $(x).removeClass("targeted");
        $(x).css("background-color", "#ffffff");
    }
    else {
        for (var i = 0; i < minions.length; i++) {
            minions[i].classList.remove("targeted");
            minions[i].style.backgroundColor = "white";
        }
        $(x).css("background-color", "#fff375");
        $(x).addClass("targeted");
    }
    $("#battleDialogue").text("Targeted a minion!");
}