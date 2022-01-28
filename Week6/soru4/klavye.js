let keyboard = ["qwertyuıopğ", "asdfghjklşi", "zxcvbnmöç"]

let arr = ["asli", "menekşe", "çöz", "giresun"];

function findKeys(arr){
    let size = 1;
    let newArr = [];
    let firstCharIndexOnKeyboard = 0;
    for(let i = 0; i < arr.length; i++){
        let firstCharacter = arr[i][0];
        for(let j = 0; j < keyboard.length; j++){
            if(keyboard[j].includes(firstCharacter)){
                firstCharIndexOnKeyboard = j;
                break;
            }
        }

        size = 1;
        for(let j = 1; j < arr[i].length; j++){
            if(keyboard[firstCharIndexOnKeyboard].includes(arr[i][j]) === true){
                size++;
            }
        }
        if(size === arr[i].length){
            newArr.push(arr[i]);
        }
    }
    return newArr;
}

console.log(findKeys(arr));