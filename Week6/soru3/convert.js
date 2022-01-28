//method 1 ---reverse() method---
let string = "asli";
let reversed = string.split("").reverse().join("");
console.log(reversed);

//method 2 ---for/loop---
let str = "deniz";
let reverse = ""; 
for( var x = str.length-1 ; x >= 0 ; x--){
    reverse += str[x]; 
}

console.log(reverse);

//method 3 ---Recursive Function---
let str1 = "ali"
function reverseStr(str){
if(str.length == 0){
 return "" ;
}
else{
    return str[str.length-1] + reverseStr(str.substring(0 , str.length-1))

    //"i" + "al"
}

}
console.log(reverseStr(str1));

//method 4 ---Unshift method ---
let str2 = "zeynep";
let arr = str2.split("");
let newarr = [];
arr.forEach(element => {
    newarr.unshift(element)
});
console.log(newarr.toString().replace(/,/g,""));
