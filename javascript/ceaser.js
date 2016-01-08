function getString() {
    return  document.getElementById("myText").value;
}

function cipherText(myString) {
   // do stuff with unicode text
   return myString;
}

function displayText(myCipher) {
    document.getElementById("demo").innerHTML = myCipher;
}

var myButton = document.querySelector('button');

myButton.onclick = function() {
   var myString = getString();
   var finalString = cipherText(myString);
   displayText(finalString);
}

