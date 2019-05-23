// https://www.codewars.com/kata/54b724efac3d5402db00065e
// Decode the Morse code

decodeMorse = function (morseCode) {
    let res = [];
    let data = morseCode.split(' ');
    data.forEach(function (v) {
        if (MORSE_CODE[v])
            res.push(MORSE_CODE[v]);
        else
            res.push(' ');
    });
    return res.join('').replace(/ {2}/g, ' ').trim();
};