var str = 'Hello my friend';

function reverseString(string){
	return string.split('').reverse().join('');
}

var reversedString = reverseString(str);
console.log(reversedString);