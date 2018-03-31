function highlightMinion(x) {
    var div = document.getElementById("battleDialogue"); // div to show battle dialogue
    var minions = document.querySelectorAll(".battleMinion"); // get all live minions

    // can't target dead minion
    if ($(x).hasClass('dead')) {
        div.innerHTML = "Minion is dead and cannot be targeted. <br>" + div.innerHTML;
    }
    else {
        // if minion is already targeted, this removes target class
        if ($(x).hasClass("targeted")) {
            $(x).removeClass("targeted");
            $(x).css("background-color", "#ffffff");
        }
        else {
            // removes targeted class from all other minions
            for (var i = 0; i < minions.length; i++) {
                minions[i].classList.remove("targeted");
                minions[i].style.backgroundColor = "white";
            }     
            $(x).css("background-color", "#fff375"); // highlights newly targeted minion
            $(x).addClass("targeted"); // adds targeted class to clicked minion
        }
    }    
}