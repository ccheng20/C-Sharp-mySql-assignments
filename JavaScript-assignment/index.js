// problem 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

// sum all salaries and store in variable sum
let sum = 0;
for (let key in salaries) {
    sum += salaries[key];
}
console.log("total salaries are: " + sum);

// problem 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

// multiply all numeric properties by 2
for (let key in menu) {
    if (typeof menu[key] == 'number') {
        menu[key] *= 2;
    }
}

console.log(menu);

// problem 3
function checkEmailId(str) {
    let re = /@.*\./;
    return re.test(str);
}

const email1 = "aa@gmail.com";
const email2 = "aa@gmailcom";
const email3 = "aagmail.";
checkEmailId(email1) ? console.log(email1 + " is valid") : console.log(email1 + " is invalid");
checkEmailId(email2) ? console.log(email2 + " is valid") : console.log(email2 + " is invalid");
checkEmailId(email3) ? console.log(email3 + " is valid") : console.log(email3 + " is invalid");

// problem 4
function truncate(str, maxlength) {
    return str.length > maxlength ? str.slice(0, maxlength - 1) + "..." : str;
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

// problem 5
let arr = ["James", "Brennie"];
arr.push("Robert");
console.log(arr);
arr[Math.floor(arr.length/2)] = "Calvin";
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift("Rose", "Regal");
console.log(arr);
