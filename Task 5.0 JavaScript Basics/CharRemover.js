'use strict';

ChangeString('У попа была собака')

function ChangeString(str) {

    let words = str.split(' ');

    let repeat = [];

    for(let i = 0; i < words.length; i++) {

        for(let j = 0; j < words[i].length; j++) {

            if(words[i].indexOf(words[i][j]) !== words[i].lastIndexOf(words[i][j])) {

                repeat.push(words[i][j]);
            }
        }
    }

    RemoveChar(str, repeat);
}

function RemoveChar(str, repeat) {

    let result = [];

    for(let i = 0; i < str.length; i++) {

        if(repeat.indexOf(str[i]) == -1) {

            result.push(str[i]);
        }
    }

    let resultStr = result.join('');

    console.log(resultStr);
}