function highlightMinion(x) {
    var minions = document.querySelectorAll(".battleMinion");
    console.log = minions.length;
    alert(minionHealth);
    if ($(x).hasClass("targeted")) {
        $(x).removeClass("targeted");
        $(x).removeAttr('id');
        $(x).css("background-color", "#ffffff");
    }
    else {
        for (var i = 0; i < minions.length; i++) {
            minions[i].classList.remove("targeted");
            minions[i].style.backgroundColor = "white";
        }
        $(x).css("background-color", "#fff375");
        $(x).addClass("targeted");
        $(x).attr('id', 'targeted');
    }
}