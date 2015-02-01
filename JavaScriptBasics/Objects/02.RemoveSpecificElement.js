var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

Array.prototype.remove = function (number) {

		arr.sort(function(a, b){return a-b});
		var index = arr.indexOf(number);
		for(var i = arr.length - 1; i >= 0; i--) {
    		if(arr[i] === number) {
    		   arr.splice(i, 1);
    	}
	}
}

arr.remove(1);
for (var index = 0; index < arr.length; index++) {
	console.log(arr[index]);
};