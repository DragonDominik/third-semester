function delegate(parent, child, when, what) {
    function eventHandlerFunction(event) {
      let eventTarget = event.target;
      let eventHandler = this;
      let closestChild = eventTarget.closest(child);
 
      if (eventHandler.contains(closestChild)) {
        what(event, closestChild);
      }
    }
 
    parent.addEventListener(when, eventHandlerFunction);
}


const button = document.querySelector("#hellobtn")
const nameInput = document.querySelector("#name")

button.addEventListener('click', greet)
nameInput.addEventListener('input', greet)

function greet(){
    const targetSpan = document.querySelector("#targetSpan")
    const nameInput = document.querySelector("#name")


    targetSpan.innerHTML = `Hello ${nameInput.value}`;
}

//1. feladat

const data = [
  {
    "name": "Emily",
    "age": 22,
    "favorite_color": "blue",
    "visited_countries": ["Germany", "France", "Italy"]
  },
  {
    "name": "Jack",
    "age": 35,
    "favorite_color": "red",
    "visited_countries": [
      "Spain",
      "Portugal",
      "France",
      "Germany",
      "Austria",
      "Switzerland",
      "Italy"
    ]
  },
  {
    "name": "Sophia",
    "age": 17,
    "favorite_color": "pink",
    "visited_countries": []
  },
  {
    "name": "Liam",
    "age": 29,
    "favorite_color": "green",
    "visited_countries": ["Norway", "Sweden"]
  },
  {
    "name": "Olivia",
    "age": 41,
    "favorite_color": "purple",
    "visited_countries": ["Italy", "Greece", "Croatia", "Slovenia"]
  },
  {
    "name": "Noah",
    "age": 19,
    "favorite_color": "white",
    "visited_countries": []
  },
  {
    "name": "Ava",
    "age": 27,
    "favorite_color": "blue",
    "visited_countries": ["France", "Belgium", "Luxembourg"]
  },
  {
    "name": "Ethan",
    "age": 36,
    "favorite_color": "green",
    "visited_countries": ["Denmark"]
  },
  {
    "name": "Mia",
    "age": 15,
    "favorite_color": "pink",
    "visited_countries": ["Hungary", "Slovakia", "Poland"]
  },
  {
    "name": "Lucas",
    "age": 24,
    "favorite_color": "red",
    "visited_countries": ["Czech Republic", "Austria"]
  }
]

//step 1
const peopleTable = document.querySelector("#people tbody")

//step 2: generate data
for (const person of data){
    const trElem = document.createElement('tr')

    for (const key in person){
        const tdElem = document.createElement("td")
        
        if (Array.isArray(person[key])){
            const ulElem = document.createElement("ul")

            for(const country of person[key]){
                const listElem = document.createElement("li")

                listElem.innerText = country

                ulElem.appendChild(listElem)
            }

            tdElem.appendChild(ulElem)
        }
        else{
            tdElem.innerText = person[key]
        }

        trElem.appendChild(tdElem)
    }




    peopleTable.appendChild(trElem)
}


const chessBoard = document.querySelector("#chess")

for (let row = 0; row < 8; row++){
    const trElem = document.createElement("tr");

    for (let col = 0; col < 8; col++){
        const tdElem = document.createElement("td")
        if ((row + col) % 2 == 0){
            tdElem.classList.add('black')
        }

        tdElem.dataset.row = row;
        tdElem.dataset.col = col;
        tdElem.addEventListener('click', () =>{
            console.log(tdElem.dataset,

            )
        })

        trElem.appendChild(tdElem)
    }

    chessBoard.appendChild(trElem)
}

delegate(chessBoard, "td.black", "click", (event, elem) => {
    console.log("delegaltam")
    console.log(event, elem)
    console.log(elem.dataset.row, elem.dataset.col)
})