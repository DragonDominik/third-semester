var a1 = 123 //
let a2 = 5; // egysoros comment
const a3 = "asd";

/*
    többsoros comment
*/

console.log('asd',"dssadsad ", `a1 is ${a1}`)

console.log(5 + 7)
console.log(5 + "alma")
console.log(5 + "5")
console.log("5" + 12)
console.log(5 - "2")
console.log("45" - 5)
console.log("adad" + "dada")
console.log("adad" - "dada")
console.log(5 / 0)
console.log(5 * "alma")
console.log( 5 * "2")
console.log(Boolean())
console.log(true && false)
console.log(true || false)

console.log(true && Boolean("alma"))
console.log("alma" && true)
console.log(false && "alma")

if("alma"){
    console.log("alma if")
}

if (0){
    console.log("0 if")
}

if ("0"){
    console.log("'0' if")
}

console.log(null)
console.log(undefined)
console.log(null == undefined)
console.log(null && undefined)
console.log(null && true)


console.log(null == undefined)
console.log(undefined == null)

if(null || undefined){
    console.log("null || undefined if") 
}

console.log(undefined + "5")
console.log(undefined - "5")
console.log(5 / undefined)
console.log(5 / null)
console.log(5 + null)
console.log(5 - null)

let arr = [5, "alma", true, null, undefined, [1,2,3], {a:5, b:"dada"}, false || true]

console.log(arr)
console.log(arr[2])

for(let i = 0; i < arr.length; i++){
    console.log(arr[i])
}

for(let i in arr){
    console.log(arr[i])
}

for(let i of arr){
    console.log(i)
}