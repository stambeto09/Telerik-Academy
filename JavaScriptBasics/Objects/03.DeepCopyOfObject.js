function Car(color, manufacturer) {
	this.color = color;
	this.manufacturer = manufacturer;
}

var car = new Car('red','BMW');
console.log(car.manufacturer);

function cloneObject (obj) {

		var clone = {};
		for(var i in obj){
			if (obj[i] && typeof obj[i] == 'object') {
    	        clone[i] = cloneObj(obj[i]);
    	    } else {
    	        clone[i] = obj[i];
    	    }
		}
	return clone;
}

var clonedCar = cloneObject(car);
console.log('Cloned car: ' + clonedCar.color);
console.log('Cloned car: ' + clonedCar.manufacturer);

var outputOrginCar = '';
for(var property in car) {
	outputOrginCar+= property + ': ' + car[property] + '; ';
}
console.log(outputOrginCar);

var outputClonedCar = '';
for(var property in clonedCar) {
	outputClonedCar+= property + ': ' + clonedCar[property] + '; ';
}
console.log(outputClonedCar);