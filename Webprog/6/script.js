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

const table = document.querySelector("table")
const canvas = document.querySelector("canvas")
const context = canvas.getContext("2d");

context.lineWidth = 3;
context.strokeStyle = "black";
let prevLocation = {
    x: 0,
    y: 0,
    isClick: false
};

canvas.addEventListener("mousedown", event => {
    prevLocation.x = event.x - canvas.getBoundingClientRect().x;
    prevLocation.y = event.y - canvas.getBoundingClientRect().y;

    prevLocation.isClick = true;
})

canvas.addEventListener("mouseup", event => {
    prevLocation.isClick = false;
})

canvas.addEventListener("mousemove", event => {
    if (!prevLocation.isClick) return;

    const x = event.x - canvas.getBoundingClientRect().x;
    const y = event.y - canvas.getBoundingClientRect().y;

    context.beginPath();
            context.moveTo(prevLocation.x, prevLocation.y);
            context.lineTo(x, y);
    context.stroke();

    prevLocation.x = x;
    prevLocation.y = y;
})

canvas.addEventListener("mouseleave", event => {
    prevLocation.isClick = false;
})

delegate(table, "td", "click", (event, elem) => {
    Array.from(document.querySelectorAll(".selected")).forEach(elem => {
        elem.classList.remove("selected");
    })
    elem.classList.add("selected");

    context.strokeStyle = elem.dataset.color;
})






/*
canvas.addEventListener("click", (event) => {
    if(prevLocation == null){
        prevLocation = {
            x: event.x - canvas.getBoundingClientRect().x,
            y: event.y - canvas.getBoundingClientRect().y
        }
    }
    else{
        context.beginPath();
            context.moveTo(prevLocation.x, prevLocation.y);
            context.lineTo(
                event.x - canvas.getBoundingClientRect().x,
                event.y - canvas.getBoundingClientRect().y);
        context.stroke();

        prevLocation = null;
    }
})



/*
context.strokeStyle = "red";

context.lineWidth = 3;

context.beginPath()
    context.moveTo(0,0)
    context.lineTo(50,60)
context.stroke()

context.beginPath()
    context.moveTo(0,0)
    context.arc(350, 100, 25, 0, 2*Math.PI)
context.stroke()
/*

Szöveg - fillText, strokText
Téglalap - fillRect, strokRect
Kör - ellipse

Kép - drawImage

Törlés - clearRect

*/