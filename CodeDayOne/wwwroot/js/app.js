function changeChampion(listIndex){
    if (document.getElementById('partyMember1').checked) {
        document.getElementById('championData').value = listIndex;
        console.log("championData's value is = " + document.getElementById('championData').value);
    }
    else if (document.getElementById('partyMember2').checked){
        console.log("Party Member #2 is now " + listIndex.name);
    }
}
