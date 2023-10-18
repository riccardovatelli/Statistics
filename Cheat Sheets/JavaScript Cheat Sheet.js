


/// LOOPS


// for (array, string, ... )

for (expression 1; expression 2; expression 3) {
  // code block to be executed
}

const cars = ["BMW", "Volvo", "Mini"];
let text = "";
for (let x of cars) {
  text += x;
}

let language = "JavaScript";
let text = "";
for (let x of language) {
text += x;
}



// for in (object)

for (key in object) {
  // code block to be executed
}

const person = {fname:"John", lname:"Doe", age:25};

let text = "";
for (let x in person) {
  text += person[x];
} 




// for in (array)

for (variable in array) {
  code
}

const numbers = [45, 4, 9, 16, 25];

let txt = "";
for (let x in numbers) {
  txt += numbers[x];
}





// forEach (chiama funzione su ogni elemento dell'array)

const numbers = [45, 4, 9, 16, 25];

let txt = "";
numbers.forEach(myFunction);

function myFunction(value, index, array) {
  txt += value;
}




// for of
//variabile - Per ogni iterazione, il valore della proprietà successiva viene assegnato alla variabile. 
  //La variabile può essere dichiarata con const, let o var.
//iterabile - Un oggetto che ha proprietà iterabili.

for (variable of iterable) {
  // code block to be executed
}





// while

while (condition) {
  // code block to be executed
}

while (i < 10) {
  text += "The number is " + i;
  i++;
}





// do while

do {
  // code block to be executed
}
while (condition);


do {
  text += "The number is " + i;
  i++;
}
while (i < 10); 




// break

for (let i = 0; i < 10; i++) {
  if (i === 3) { break; }
  text += "The number is " + i + "<br>";
} 



// continue

for (let i = 0; i < 10; i++) {
  if (i === 3) { continue; }
  text += "The number is " + i + "<br>";
}




//  L'istruzione continue (con o senza riferimento all'etichetta) può essere utilizzata solo per saltare un'iterazione del ciclo.
// L'istruzione break, senza un riferimento all'etichetta, può essere usata solo per saltare fuori da un ciclo o da uno switch.
// Con un riferimento all'etichetta, l'istruzione break può essere usata per saltare fuori da qualsiasi blocco di codice: 

const cars = ["BMW", "Volvo", "Saab", "Ford"];
list: {
  text += cars[0] + "<br>";
  text += cars[1] + "<br>";
  break list;
  text += cars[2] + "<br>";
  text += cars[3] + "<br>";
} 










// ARRAY

/// --- Creation ---
1)  const array_name = [item1, item2, ...];    

2)  const days = [];
    cars[0]= "Monday";
    cars[1]= "Tuesday";
    cars[2]= "Wednesday";
... 

3)  const cars = new Array("Mercedes", "Volvo", "BMW");

/// ---> N.B.:
// Create an array with one element:
const points = [40];
// Create an array with 40 undefined elements:
const points = new Array(40);


/// --- Methods ---

// Array to string
const fruits = ["Banana", "Orange", "Apple", "Mango"];
document.getElementById("demo").innerHTML = fruits.toString();

// Length
let fLen = fruits.length;

// For Loop
let text = "<ul>";
for (let i = 0; i < fLen; i++) {
  text += "<li>" + fruits[i] + "</li>";
}
text += "</ul>";

// forEach()

let text = "<ul>";
fruits.forEach(myFunction);
text += "</ul>";

function myFunction(value) {
  text += "<li>" + value + "</li>";
} 

// type
let type = typeof fruits;

// pop (rimuove elemento in testa)
array_name.pop()

// push (aggiunge elemento in coda)
array_name.push()

// shift (rimuove elemento in testa e sposta gli altri ad un indice inferiore di 1)
array_name.shift()

// unshift (rimuove elemento in testa e sposta gli altri ad un indice inferiore di 1)
array_name.shift()

// concat
const arr1 = ["Cecilie", "Lone"];
const arr2 = ["Emil", "Tobias", "Linus"];
const arr3 = ["Robin", "Morgan"];
const myChildren = arr1.concat(arr2, arr3);

// flat (crea nuovo array concatenando sotto-array fino ad una specifica profondità)
const myArr = [[1,2],[3,4],[5,6]];
const newArr = myArr.flat();

// splice (1o parametro indica posizione del nuovo elemento; 2o parametro indica quanti elementi vanno rimossi)
const fruits = ["Banana", "Orange", "Apple", "Mango"];
fruits.splice(2, 0, "Lemon", "Kiwi");


// sort (default ritorna valori come stringhe ordinate in ordine alfabetico)
array_name.sort()

// sort numerico ascendente
const points = [40, 100, 1, 5, 25, 10];
points.sort(function(a, b){return a - b});

// sort numerico discendente
const points = [40, 100, 1, 5, 25, 10];
points.sort(function(a, b){return b - a});

// sort numerico random
const points = [40, 100, 1, 5, 25, 10];
points.sort(function(){return 0.5 - Math.random()});

// sort Fisher Yates
const points = [40, 100, 1, 5, 25, 10];
for (let i = points.length -1; i > 0; i--) {
  let j = Math.floor(Math.random() * (i+1));
  let k = points[i];
  points[i] = points[j];
  points[j] = k;
}

// reverse
array_name.reverse()

// find Max (built-in)
function myArrayMax(arr) {
  return Math.max.apply(null, arr);
}

// find Max (loop)
function myArrayMax(arr) {
  let len = arr.length;
  let max = -Infinity;
  while (len--) {
    if (arr[len] > max) {
      max = arr[len];
    }
  }
  return max;
} 


// find Min (built-in)
function myArrayMin(arr) {
  return Math.min.apply(null, arr);
}

// find Min (loop)
function myArrayMin(arr) {
  let len = arr.length;
  let min = Infinity;
  while (len--) {
    if (arr[len] < min) {
      min = arr[len];
    }
  }
  return min;
} 


// map
//Il metodo map() crea un nuovo array eseguendo una funzione su ciascun elemento dell'array.
//Il metodo map() non esegue la funzione per gli elementi dell'array senza valori.
//Il metodo map() non modifica l'array originale.
const numbers1 = [45, 4, 9, 16, 25];
const numbers2 = numbers1.map(myFunction);
function myFunction(value, index, array) {
  return value * 2;
}


// flatMap
// Il metodo flatMap() mappa prima tutti gli elementi di un array e poi crea un nuovo array, appiattendolo.
const myArr = [1, 2, 3, 4, 5, 6];
const newArr = myArr.flatMap((x) => x * 2);


// filter
// Il metodo filter() crea un nuovo array con gli elementi dell'array che superano un test.
const numbers = [45, 4, 9, 16, 25];
const over18 = numbers.filter(myFunction);
function myFunction(value, index, array) {
  return value > 18;
} 










// LIST

// creazione e accesso
1) 
  var list = [
  { date: '12/1/2011', reading: 3, id: 20055 },
  { date: '13/1/2011', reading: 5, id: 20053 },
  { date: '14/1/2011', reading: 6, id: 45652 }
  ];

  alert(list[1].date);


2) 
  var listOfObjects = [];
  var a = ["car", "bike", "scooter"];
  a.forEach(function(entry) {
    var singleObj = {};
    singleObj['type'] = 'vehicle';
    singleObj['value'] = entry;
    listOfObjects.push(singleObj);
  });

3)
list = new Array()
var text = list.forEach(function(currentValue, currentIndex, listObj) {
  if(currentValue.text !== undefined)
  {list.push(currentValue.text)}
  });




// DICTIONARY

/// --- Creation --- 
const person = {
  firstName: "John",
  lastName: "Doe",
  age: 50,
  status: "marketing contact"
  };
  /* ritorna John */
  person["firstName"];
  person.firstName;


// For loop
for (const key of Object.keys(person)) {
  console.log(key + ":" + person[key])
  };




// Maps

/*Add key-value pairs*/
person.set("id", 123)
person.set("registered", true)
let name = {firstName: "Anj"}

/*Add keys of different types*/
/*Creates an integer key = (1) with an array value = ([1, 2, 3, 5])*/
person.set(1, [1, 2, 3, 5])
/*Creates a object key = (name) with a string value = ("available")*/
person.set(name, "available")


// Check existence
person.has("dog") /*false*/
person.has("id") /*true*/

// Delete
person.delete(name) /*true*/

// Check size
person.size /*returns the number of keys*/

// Useful Iterations
/*Best for accessing both keys and their values*/
for (const [key, value] of person.entries()) {
  console.log(key + ": " + value)
  }
  /*Best for accessing only the keys*/
  for (const key of person.keys()) {
  console.log(key)
  }
  /*Best for accessing only the values*/
  for (const value of person.values()) {
  console.log(value)
  };


// compareValues:  Useful dynamic sorting (list of Objects)
const singers = [
  { name: 'Steven Tyler', band: 'Aerosmith', born: 1948 },
  { name: 'Karen Carpenter', band: 'The Carpenters', born: 1950 },
  { name: 'Kurt Cobain', band: 'Nirvana', born: 1967 },
  { name: 'Stevie Nicks', band: 'Fleetwood Mac', born: 1948 },
];

function compareValues(key, order = 'asc') {
  return function innerSort(a, b) {
    if (!a.hasOwnProperty(key) || !b.hasOwnProperty(key)) {
      // property doesn't exist on either object
      return 0;
    }

    const varA = (typeof a[key] === 'string')
      ? a[key].toUpperCase() : a[key];
    const varB = (typeof b[key] === 'string')
      ? b[key].toUpperCase() : b[key];

    let comparison = 0;
    if (varA > varB) {
      comparison = 1;
    } else if (varA < varB) {
      comparison = -1;
    }
    return (
      (order === 'desc') ? (comparison * -1) : comparison
    );
  };
}


function compareDates(a, b) {
  return Date.parse(new Date(a.birthdate)) - Date.parse(new Date(b.birthdate))
}



/// HASHSET

// --- Creation ---
const s = new Set();
s.add("q");
s.add("x");
s.add("c");
s.add("q"); // duplicate
for (const v of s) {
  console.log(v); // q, x, c -- insertion order
}

// Add
let set = new Set(); 
set.add(1)

// Check existence
set.has(value)

// Delete 
mySet.delete('x')


// values()
// Il metodo values() restituisce un oggetto Iterator contenente tutti i valori di un insieme:

// Create an Iterator
const myIterator = letters.values();

// List all Values
let text = "";
for (const entry of myIterator) {
  text += entry;
}




/// LINKED LIST

// --- Creation --- 

1)
const list = {
  head: {
      value: 6
      next: {
          value: 10                                             
          next: {
              value: 12
              next: {
                  value: 3
                  next: null	
                  }
              }
          }
      }
  }
};


2) 
class ListNode {
  constructor(data) {
      this.data = data
      this.next = null                
  }
}
let node1 = new ListNode(2)
let node2 = new ListNode(5)
node1.next = node2

console.log(list.head.next.data) //Disply output: returns 5


3)
class LinkedList {
  constructor(head = null) {
      this.head = head
  }
}



// size

size() {
  let count = 0; 
  let node = this.head;
  while (node) {
      count++;
      node = node.next
  }
  return count;
}



// clear

clear() {
  this.head = null;
}


// getLast (ottiene coda)
getLast() {
  let lastNode = this.head;
  if (lastNode) {
      while (lastNode.next) {
          lastNode = lastNode.next
      }
  }
  return lastNode
}


// getFirst (ottiene testa)
getFirst() {
  return this.head;
}







/// QUEUE

class Queue {
  constructor() {
    this.elements = {};
    this.head = 0;
    this.tail = 0;
  }
  enqueue(element) {
    this.elements[this.tail] = element;
    this.tail++;
  }
  dequeue() {
    const item = this.elements[this.head];
    delete this.elements[this.head];
    this.head++;
    return item;
  }
  peek() {
    return this.elements[this.head];
  }
  get length() {
    return this.tail - this.head;
  }
  get isEmpty() {
    return this.length === 0;
  }
}






/// STACK

class Stack {
  constructor() {
      this.stkArr = [];
  }
  // add element to the stack
  add(element) {
      return this.stkArr.push(element);
  }
  // remove element from the stack
  remove() {
      if (this.stkArr.length > 0) {
        document.write("<br>");
        return "The Popped element is : " + this.stkArr.pop();
      }
  }
  // view the last element
  peek() {
      document.write("<br>");
      return (
        "The Peek element of the stack is : " +
        this.stkArr[this.stkArr.length - 1]
      );
  }
  // check if the stack is empty
  isEmpty() {
      document.write("<br>");
      return this.stkArr.length == 0;
  }
  // the size of the stack
  size() {
      document.write("<br>");
      return "The size of the stack is : " + this.stkArr.length;
  }
  display() {
      if (this.stkArr.length !== 0) {
        return "The stack elements are : " + this.stkArr + "<br>";
      } else {
        document.write("The Stack is Empty..! <br>");
      }
  }
  // empty the stack
  clear() {
      document.write("The stack is cleared..!" + "<br>");
      this.stkArr = [];
  }
}
let stack = new Stack();
stack.add(1);
stack.add(2);
stack.add(3);
stack.add(4);
stack.add(5);
document.write(stack.display());






