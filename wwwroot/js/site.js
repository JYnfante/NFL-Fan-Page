
// This function is used to set the stats for new Player objects.
function Player(name, number, position, stat1, stat2, stat3, stat4) {
    this.name = name;
    this.number = number;
    this.position = position;
    this.stat1 = stat1;
    this.stat2 = stat2;
    this.stat3 = stat3;
    this.stat4 = stat4;
}

// Here we are creating new player objects with their stats.
let russell = new Player("Russell Wilson", 3, "Quarterback", "4,212", 40, 13, 73.5);
let geno = new Player("Geno Smith", 7, "Quarterback", 33, 0, 0, 5.2);
let tyler = new Player("Tyler Lockett", 16, "Wide Receiver", 100, "1,054", 10, 10.5);
let dk = new Player("DK Metcalf", 14, "Wide Receiver", 83, "1,303", 10, 15.7);
let aaron = new Player("Aaron Fuller", 17, "Wide Receiver", "DNP", "DNP", "DNP", "DNP");
let freddie = new Player("Freddie Swain", 18, "Wide Receiver", 13, 159, 2, 12.2);
let chris = new Player("Chris Carson", 32, "Running Back", 141, 681, 5, 4.8);
let travis = new Player("Travis Homer", 25, "Running Back", 25, 88, 0, 3.5);
let deejay = new Player("Deejay Dallas", 31, "Running Back", 34, 108, 2, 3.2);
let alex = new Player("Alex Collins", 41, "Running Back", 18, 77, 2, 4.3);
let will = new Player("Will Dissly", 89, "Tight End", 24, 251, 2, 10.5);
let gerald = new Player("Gerald Everett", 81, "Tight End", 41, 417, 1, 10.2);

// Put the players into an array by position
var quarterbacksArray = [russell, geno];
var runningBacksArray = [chris, travis, deejay, alex];
var wideReceiversArray = [tyler, dk, aaron, freddie];
var tightEndsArray = [will, gerald];


// This function will display the player stats in HTML.
function DisplayStats(player) {
    
    let getImg = document.querySelector(".player-img");
    let getStats1 = document.querySelector(".stats1");
    let getStats2 = document.querySelector(".stats2");

    getImg.innerHTML = "<img src=\'/images/player_images/" + player.name + ".png\' class=\'img-fluid\'>";
    getStats1.innerHTML = "<div class=\'text-center text-wrap text-uppercase fs-3\'>" + player.name + "</div><div class=\'text-center text-wrap\'>Seattle Seahawks  #" + player.number + "  " + player.position + "</div>";

    // Here, we check the position of the player.
    // Different positions will show different stats.
    switch (player.position) {

        // Display stats for Quarterback
        case "Quarterback": getStats2.innerHTML = `<table id="player-stats"><tr><th colspan="4" style="top: 0px;">2020 SEASON STATS</th></tr><tr><td>YDS</td><td>TD</td><td>INT</td><td>QBR</td></tr><tr><td>` + player.stat1 + `</td><td>` + player.stat2 + `</td><td>` + player.stat3 + `</td><td>` + player.stat4 + `</td></tr></table>`;
            break;

        // Display stats for Running Back
        case "Running Back": getStats2.innerHTML = `<table id="player-stats"><tr><th colspan="4">2020 SEASON STATS</th></tr><tr><td>ATT</td><td>YDS</td><td>TD</td><td>AVG</td></tr><tr><td>` + player.stat1 + `</td><td>` + player.stat2 + `</td><td>` + player.stat3 + `</td><td>` + player.stat4 + `</td></tr></table>`;
            break;

        // Display all other position stats
        default: getStats2.innerHTML = `<table id="player-stats"><tr><th colspan="4">2020 SEASON STATS</th></tr><tr><td>REC</td><td>YDS</td><td>TD</td><td>AVG</td></tr><tr><td>` + player.stat1 + `</td><td>` + player.stat2 + `</td><td>` + player.stat3 + `</td><td>` + player.stat4 + `</td></tr></table>`;
            break;
    }
}



// This function loads the player thumbnails into the html
function loadPlayerThumbnails(player) {

    var getThumbnails = document.getElementById("player-thumbnails");
    let newThumbnail = document.createElement('div');
    newThumbnail.classList.add("col");


    // Truncate player name so we can use it when we call DisplayStats()
    var tempName = player.name.substring(0, player.name.indexOf(' ')).toLowerCase();


    newThumbnail.innerHTML = `<div class=card id=playerPreview><a href=# onclick=DisplayStats(`+ tempName +`)><div class=row><div class=col-4><img src="/images/player_images/` + player.name + `.png\" /></div><div class=col-8><div class=fw-bold>` + player.name + `</div><div class=fw-light>#` + player.number + `</div></div></div></a></div>`;

    // Append the new element, player thumbnail
    getThumbnails.appendChild(newThumbnail);
}



// This function will change player thumbnails when a position
// from the dropdown menu is selected.
function togglePlayerThumbnails(positionArray) {

    var getThumbnails = document.getElementById("player-thumbnails");
    getThumbnails.innerHTML = "";

    for (let i = 0; i < positionArray.length; i++) {
        loadPlayerThumbnails(positionArray[i]);
    }
}



// On Home screen, load default stat card and thumbnails
DisplayStats(russell);
togglePlayerThumbnails(quarterbacksArray);