// Pages
const main_page = document.getElementById("main_page");
const game_page = document.getElementById("game_page");
const results_page = document.getElementById("results_page");

// Components
const start_button = document.getElementById("start");

function displayPage(page) {
    main_page.style.display = "none";
    game_page.style.display = "none";
    results_page.style.display = "none";

    if(page != null) {
        page.style.display = "block";
    }
}

// Event listener for start button
start_button.addEventListener("click", function() {
    displayPage(game_page);
});

// Initially show main page
displayPage(main_page);