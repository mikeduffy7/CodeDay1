function highlightMinion(x) {
    var minions = document.querySelectorAll(".battleMinion");
    console.log = minions.length;
    if ($(x).hasClass('targeted')) {
        $(x).removeClass('targeted');
        $(x).css('background-color', '#ffffff');
    }
    else {
        for (var i = 0; i < minions.length; i++) {
            minions[i].classList.remove('targeted');
            minions[i].style.backgroundColor = "white";
        }
        $(x).css('background-color', '#fff375');
        $(x).addClass('targeted');
    }
}

function createMinionHorde() {
    var redHorde = redMinionHorde();
    var hordeSize = randomNumberOfMinions();
    console.log("The horde is red: " + redHorde);
    console.log("Number of minions in horde: " + hordeSize);
}

//returns a bool to determine if the minions will be blue or red
function redMinionHorde() {
    var coinFlip = Math.floor(Math.random() * 2);
    if (coinFlip === 0)
        return true;
    else
        return false;
}

//determines number of minions created; between 2 and 5
function randomNumberOfMinions() {
    var numberOfMinions = Math.floor((Math.random() * 4) + 2);
    return numberOfMinions;
}

function refreshMinionList(num) {
    document.getElementById('battleMinionList').innerHTML = "";
    
}