//loopok
arrays = [1, 2, 3, 4, 5];
for (let index = 0; index < arrays.length; index++) {
    console.log(arrays[index]);
}

for(const key in arrays) {
    console.log(arrays[key]);
}

for(const key of arrays){
    console.log(key);
}

condition = false

do{

} while (condition);

while(condition){}

//objects

const obj = {
    prop1 : 15,
    prop2 : 15 + 5,
    "prop3" : [1, "asd", true],
}

obj["prop4"] = "Laci"

console.log(obj)
console.log(typeof obj)

for(const key in obj){
    console.log(obj[key])
}

function my_fn(param1, param2){
    console.log("Hello from function"); 
    let a = 5;

    let sum = param1 + param2
    return sum
}

const result = my_fn(1,2);
console.log(result)


const arrow_fn = (param1, param2, /*...*/) => {
    console.log("Hello from function"); 
    let a = 5;

    let sum = param1 + param2
    return sum
}

arrow_fn()

const sum_fn = (a, b) => {
    return a + b
}

const sum_fn_turbo = (a,b) => a + b

const is_even = (a) => a % 2 == 0

console.log(typeof my_fn, typeof arrow_fn)

console.log(is_even(3),is_even(4))

const swap = (a,b) =>{
    let tmp = b
    b = a
    a = tmp
}

var first = 1
var second = 2

console.log(first, second)
swap(first, second)
console.log(first, second)

const addParam = (my_obj) =>{
    my_obj[age] = 25
}

const my_obj = {
    name: "Laci",
    isMinor : (age) => age <= 18
}

console.log(my_obj)
addParam
console.log(my_obj)


// Arrays

let array = [1,2,3,4,5]
array.forEach((value,index,array) => {
    console.log(value,index,array)
}
)

array = [1,2,3,4,5,66,67,0,-2,-5]
const is_negative = (a) => a < 0

console.log(array.every((value) => value % 2 == 0),
    array.every(is_even),
    array.some(is_even),
    array.find(is_negative),
    array.findIndex(is_negative))

array.push(25)
array.pop()
array.shift()
array.unshift(25)

//Tömbfüggvények

const person = {
    name: "Fanni",
    favourite_colour : "yellow",
    pets: ["snake","dog","cat"],
    lottery_numbers : [40, 43, 22, 2, 9]
}

const kivalogat = (arr) => {
    const result = []
    for (const elem of arr){
        if (elem % 2 == 0){
            result.push(elem)
        }
    }

    return result
}

const kivalogat2 = (arr, predicate) => {
    const result = []
    for (const elem of arr){
        if (predicate(elem)){
            result.push(elem)
        }
    }

    return result
}


console.log(
    kivalogat(person.lottery_numbers),
    kivalogat2(person.lottery_numbers, is_even),
    person.lottery_numbers.filter(is_even))


/*
some (eldöntés): [a, a, a...] --> bool
every (optimista eldöntés): [a, a, a...] --> bool
map (másolás): [a, a, a...] --> [b, b, b...]
filter (kiválogatás): [a, a, a...] --> [a, a, a]
reduce (összegzés): [a, a, a...] --> y
find (keresés): [a, a, a...] --> a | undefined (ha nincs feltételnek megfelelő érték)
findIndex (keresés): [a, a, a...] --> y | -1 (ha nincs feltételnek megfelelő érték)
*/
console.log(
    Math.min( ...[1,2,3,4,5]),
    Math.max( ...[1,2,3,4,5])
)

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


const minors = data.filter(person => person.age < 18)
console.log(minors, minors.length)

const blues = data.filter( person => person.favorite_color == "blue")
console.log(blues, blues.length)

const people_with_a = data.filter(person => person.name.includes('a') || person.name.includes('A'))
const people_names_with_a = people_with_a.map( person => person.name)

console.log(people_names_with_a)

const res =
data
    .filter(person => person.favorite_color != "blue")
    .filter(person => person.visited_countries.includes("Italy"))

console.log(res)