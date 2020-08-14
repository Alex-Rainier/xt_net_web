'use strict';

Calculator('3.5 +4*10-5.3 /5 =');

function Calculator(str) {

    let regex = /\-?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1}/ig;

    let match = str.match(regex);

    let result = parseFloat(match[0]);

    for(let i = 1; i <= match.length; i++) {

        switch(match[i]) {

            case '+':
                result += parseFloat(match[i + 1]);
                break;
            case '-':
                result -= parseFloat(match[i + 1]);
                break;
            case '*':
                result *= parseFloat(match[i + 1]);
                break;
            case '/':
                result /= parseFloat(match[i + 1]);
                break;
            case '=':
                result = result.toFixed(2);
                console.log(result);
                break;
        }
    }
}